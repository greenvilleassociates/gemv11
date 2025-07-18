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

public static class GcpeotherEndpoints
{

    public static async void MapGcpeotherEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gcpeother").WithTags(nameof(Gcpeother));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gcpeothers.ToList();
            }

        })
        .WithName("GetAllGcpeothers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gcpeothers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGcpeotherById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gcpeother input) =>
        {
            using (var context = new GemContext())
            {
                Gcpeother[] someGcpeother = context.Gcpeothers.Where(m => m.Id == id).ToArray();
                context.Gcpeothers.Attach(someGcpeother[0]);
                someGcpeother[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGcpeother")
        .WithOpenApi();

        group.MapPost("/", async (Gcpeother input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gcpeothers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGcpeother")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gcpeothers.Add(std);
                Gcpeother[] someGcpeothers = context.Gcpeothers.Where(m => m.Id == id).ToArray();
                context.Gcpeothers.Attach(someGcpeothers[0]);
                context.Gcpeothers.Remove(someGcpeothers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGcpeother")
        .WithOpenApi();
    }
}

