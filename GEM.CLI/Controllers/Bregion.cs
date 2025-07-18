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

public static class GbregionEndpoints
{

    public static async void MapGbregionEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gbregion").WithTags(nameof(Gbregion));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gbregions.ToList();
            }

        })
        .WithName("GetAllGbregions")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gbregions.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGbregionById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gbregion input) =>
        {
            using (var context = new GemContext())
            {
                Gbregion[] someGbregion = context.Gbregions.Where(m => m.Id == id).ToArray();
                context.Gbregions.Attach(someGbregion[0]);
                someGbregion[0].Regiondescription = input.Regiondescription;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGbregion")
        .WithOpenApi();

        group.MapPost("/", async (Gbregion input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gbregions.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGbregion")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gbregions.Add(std);
                Gbregion[] someGbregions = context.Gbregions.Where(m => m.Id == id).ToArray();
                context.Gbregions.Attach(someGbregions[0]);
                context.Gbregions.Remove(someGbregions[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGbregion")
        .WithOpenApi();
    }
}

