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

public static class GsiteEndpoints
{

    public static async void MapGsiteEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gsite").WithTags(nameof(Gsite));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gsites.ToList();
            }

        })
        .WithName("GetAllGsites")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gsites.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGsiteById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gsite input) =>
        {
            using (var context = new GemContext())
            {
                Gsite[] someGsite = context.Gsites.Where(m => m.Id == id).ToArray();
                context.Gsites.Attach(someGsite[0]);
                someGsite[0].Phone = input.Phone;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGsite")
        .WithOpenApi();

        group.MapPost("/", async (Gsite input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gsites.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGsite")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gsites.Add(std);
                Gsite[] someGsites = context.Gsites.Where(m => m.Id == id).ToArray();
                context.Gsites.Attach(someGsites[0]);
                context.Gsites.Remove(someGsites[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGsite")
        .WithOpenApi();
    }
}

