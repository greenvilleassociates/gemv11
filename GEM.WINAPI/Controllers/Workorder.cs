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

public static class GworkorderEndpoints
{

    public static async void MapGworkorderEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gworkorder").WithTags(nameof(Gworkorder));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gworkorders.ToList();
            }

        })
        .WithName("GetAllGworkorders")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gworkorders.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGworkorderById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gworkorder input) =>
        {
            using (var context = new GemContext())
            {
                Gworkorder[] someGworkorder = context.Gworkorders.Where(m => m.Id == id).ToArray();
                context.Gworkorders.Attach(someGworkorder[0]);
                someGworkorder[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGworkorder")
        .WithOpenApi();

        group.MapPost("/", async (Gworkorder input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gworkorders.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGworkorder")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gworkorders.Add(std);
                Gworkorder[] someGworkorders = context.Gworkorders.Where(m => m.Id == id).ToArray();
                context.Gworkorders.Attach(someGworkorders[0]);
                context.Gworkorders.Remove(someGworkorders[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGworkorder")
        .WithOpenApi();
    }
}

