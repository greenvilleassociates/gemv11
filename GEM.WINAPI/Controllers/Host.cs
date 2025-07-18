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

public static class GhostEndpoints
{

    public static async void MapGhostEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ghost").WithTags(nameof(Ghost));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ghosts.ToList();
            }

        })
        .WithName("GetAllGhosts")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ghosts.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGhostById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ghost input) =>
        {
            using (var context = new GemContext())
            {
                Ghost[] someGhost = context.Ghosts.Where(m => m.Id == id).ToArray();
                context.Ghosts.Attach(someGhost[0]);
                someGhost[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGhost")
        .WithOpenApi();

        group.MapPost("/", async (Ghost input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ghosts.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGhost")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ghosts.Add(std);
                Ghost[] someGhosts = context.Ghosts.Where(m => m.Id == id).ToArray();
                context.Ghosts.Attach(someGhosts[0]);
                context.Ghosts.Remove(someGhosts[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGhost")
        .WithOpenApi();
    }
}

