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

public static class GhostimageEndpoints
{

    public static async void MapGhostimageEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ghostimage").WithTags(nameof(Ghostimage));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ghostimages.ToList();
            }

        })
        .WithName("GetAllGhostimages")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ghostimages.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGhostimageById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ghostimage input) =>
        {
            using (var context = new GemContext())
            {
                Ghostimage[] someGhostimage = context.Ghostimages.Where(m => m.Id == id).ToArray();
                context.Ghostimages.Attach(someGhostimage[0]);
                someGhostimage[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGhostimage")
        .WithOpenApi();

        group.MapPost("/", async (Ghostimage input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ghostimages.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGhostimage")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ghostimages.Add(std);
                Ghostimage[] someGhostimages = context.Ghostimages.Where(m => m.Id == id).ToArray();
                context.Ghostimages.Attach(someGhostimages[0]);
                context.Ghostimages.Remove(someGhostimages[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGhostimage")
        .WithOpenApi();
    }
}

