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

public static class GhregionEndpoints
{

    public static async void MapGhregionEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ghregion").WithTags(nameof(Ghregion));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ghregions.ToList();
            }

        })
        .WithName("GetAllGhregions")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ghregions.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGhregionById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ghregion input) =>
        {
            using (var context = new GemContext())
            {
                Ghregion[] someGhregion = context.Ghregions.Where(m => m.Id == id).ToArray();
                context.Ghregions.Attach(someGhregion[0]);
                someGhregion[0].Regiondescription = input.Regiondescription;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGhregion")
        .WithOpenApi();

        group.MapPost("/", async (Ghregion input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ghregions.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGhregion")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ghregions.Add(std);
                Ghregion[] someGhregions = context.Ghregions.Where(m => m.Id == id).ToArray();
                context.Ghregions.Attach(someGhregions[0]);
                context.Ghregions.Remove(someGhregions[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGhregion")
        .WithOpenApi();
    }
}

