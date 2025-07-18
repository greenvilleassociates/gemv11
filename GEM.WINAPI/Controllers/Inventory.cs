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

public static class GinventoryEndpoints
{

    public static async void MapGinventoryEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ginventory").WithTags(nameof(Ginventory));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ginventories.ToList();
            }

        })
        .WithName("GetAllGinventories")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ginventories.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGinventoryById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ginventory input) =>
        {
            using (var context = new GemContext())
            {
                Ginventory[] someGinventory = context.Ginventories.Where(m => m.Id == id).ToArray();
                context.Ginventories.Attach(someGinventory[0]);
                someGinventory[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGinventory")
        .WithOpenApi();

        group.MapPost("/", async (Ginventory input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ginventories.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGinventory")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ginventories.Add(std);
                Ginventory[] someGinventories = context.Ginventories.Where(m => m.Id == id).ToArray();
                context.Ginventories.Attach(someGinventories[0]);
                context.Ginventories.Remove(someGinventories[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGinventory")
        .WithOpenApi();
    }
}

