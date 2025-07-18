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

public static class GdiskEndpoints
{

    public static async void MapGdiskEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gdisk").WithTags(nameof(Gdisk));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gdisks.ToList();
            }

        })
        .WithName("GetAllGdisks")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gdisks.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGdiskById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gdisk input) =>
        {
            using (var context = new GemContext())
            {
                Gdisk[] someGdisk = context.Gdisks.Where(m => m.Id == id).ToArray();
                context.Gdisks.Attach(someGdisk[0]);
                someGdisk[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGdisk")
        .WithOpenApi();

        group.MapPost("/", async (Gdisk input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gdisks.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGdisk")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gdisks.Add(std);
                Gdisk[] someGdisks = context.Gdisks.Where(m => m.Id == id).ToArray();
                context.Gdisks.Attach(someGdisks[0]);
                context.Gdisks.Remove(someGdisks[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGdisk")
        .WithOpenApi();
    }
}

