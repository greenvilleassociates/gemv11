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

public static class GhostlparEndpoints
{

    public static async void MapGhostlparEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ghostlpar").WithTags(nameof(Ghostlpar));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ghostlpars.ToList();
            }

        })
        .WithName("GetAllGhostlpars")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ghostlpars.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGhostlparById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ghostlpar input) =>
        {
            using (var context = new GemContext())
            {
                Ghostlpar[] someGhostlpar = context.Ghostlpars.Where(m => m.Id == id).ToArray();
                context.Ghostlpars.Attach(someGhostlpar[0]);
                someGhostlpar[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGhostlpar")
        .WithOpenApi();

        group.MapPost("/", async (Ghostlpar input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ghostlpars.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGhostlpar")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ghostlpars.Add(std);
                Ghostlpar[] someGhostlpars = context.Ghostlpars.Where(m => m.Id == id).ToArray();
                context.Ghostlpars.Attach(someGhostlpars[0]);
                context.Ghostlpars.Remove(someGhostlpars[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGhostlpar")
        .WithOpenApi();
    }
}

