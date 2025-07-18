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

public static class GphysicalparEndpoints
{

    public static async void MapGphysicalparEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gphysicalpar").WithTags(nameof(Gphysicalpar));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gphysicalpars.ToList();
            }

        })
        .WithName("GetAllGphysicalpars")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gphysicalpars.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGphysicalparById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gphysicalpar input) =>
        {
            using (var context = new GemContext())
            {
                Gphysicalpar[] someGphysicalpar = context.Gphysicalpars.Where(m => m.Id == id).ToArray();
                context.Gphysicalpars.Attach(someGphysicalpar[0]);
                someGphysicalpar[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGphysicalpar")
        .WithOpenApi();

        group.MapPost("/", async (Gphysicalpar input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gphysicalpars.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGphysicalpar")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gphysicalpars.Add(std);
                Gphysicalpar[] someGphysicalpars = context.Gphysicalpars.Where(m => m.Id == id).ToArray();
                context.Gphysicalpars.Attach(someGphysicalpars[0]);
                context.Gphysicalpars.Remove(someGphysicalpars[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGphysicalpar")
        .WithOpenApi();
    }
}

