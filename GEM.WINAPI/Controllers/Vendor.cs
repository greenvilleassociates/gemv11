using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using GEMAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http;
namespace Enterprise.Controllers;

public static class GvendorEndpoints
{

    public static async void MapGvendorEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gvendor").WithTags(nameof(Gvendor));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gvendors.ToList();
            }

        })
        .WithName("GetAllGvendors")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gvendors.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGvendorById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gvendor input) =>
        {
            using (var context = new GemContext())
            {
                Gvendor[] someGvendor = context.Gvendors.Where(m => m.Id == id).ToArray();
                context.Gvendors.Attach(someGvendor[0]);
                someGvendor[0].Vendorname = input.Vendorname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGvendor")
        .WithOpenApi();

        group.MapPost("/", async (Gvendor input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gvendors.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGvendor")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gvendors.Add(std);
                Gvendor[] someGvendors = context.Gvendors.Where(m => m.Id == id).ToArray();
                context.Gvendors.Attach(someGvendors[0]);
                context.Gvendors.Remove(someGvendors[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGvendor")
        .WithOpenApi();
    }
}

