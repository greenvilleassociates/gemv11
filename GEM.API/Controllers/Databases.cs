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

public static class GdatabasesEndpoints
{

    public static async void MapGdatabasesEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gdatabases").WithTags(nameof(Gdatabase));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gdatabases.ToList();
            }

        })
        .WithName("GetAllGdatabases")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gdatabases.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGdatabasesById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gdatabase input) =>
        {
            using (var context = new GemContext())
            {
                Gdatabase[] someGdatabase = context.Gdatabases.Where(m => m.Id == id).ToArray();
                context.Gdatabases.Attach(someGdatabase[0]);
someGdatabase[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGdatabases")
        .WithOpenApi();

        group.MapPost("/", async (Gdatabase input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gdatabases.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGdatabases")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Grouters.Add(std);
                Gdatabase[] someGdatabase = context.Gdatabases.Where(m => m.Id == id).ToArray();
                context.Gdatabases.Attach(someGdatabase[0]);
                context.Gdatabases.Remove(someGdatabase[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGdatabases")
        .WithOpenApi();
    }
}

