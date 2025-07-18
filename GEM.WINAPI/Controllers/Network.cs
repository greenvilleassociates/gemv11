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

public static class GnetworkEndpoints
{

    public static async void MapGnetworkEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gnetwork").WithTags(nameof(Gnetwork));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gnetworks.ToList();
            }

        })
        .WithName("GetAllGnetworks")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gnetworks.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGnetworkById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gnetwork input) =>
        {
            using (var context = new GemContext())
            {
                Gnetwork[] someGnetwork = context.Gnetworks.Where(m => m.Id == id).ToArray();
                context.Gnetworks.Attach(someGnetwork[0]);
                someGnetwork[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGnetwork")
        .WithOpenApi();

        group.MapPost("/", async (Gnetwork input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gnetworks.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGnetwork")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gnetworks.Add(std);
                Gnetwork[] someGnetworks = context.Gnetworks.Where(m => m.Id == id).ToArray();
                context.Gnetworks.Attach(someGnetworks[0]);
                context.Gnetworks.Remove(someGnetworks[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGnetwork")
        .WithOpenApi();
    }
}

