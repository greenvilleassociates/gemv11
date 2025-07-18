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

public static class GengineregionEndpoints
{

    public static async void MapGengineregionEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gengineregion").WithTags(nameof(Gengineregion));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gengineregions.ToList();
            }

        })
        .WithName("GetAllGengineregions")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gengineregions.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGengineregionById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gengineregion input) =>
        {
            using (var context = new GemContext())
            {
                Gengineregion[] someGengineregion = context.Gengineregions.Where(m => m.Id == id).ToArray();
                context.Gengineregions.Attach(someGengineregion[0]);
                someGengineregion[0].Regiondescription = input.Regiondescription;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGengineregion")
        .WithOpenApi();

        group.MapPost("/", async (Gengineregion input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gengineregions.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGengineregion")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gengineregions.Add(std);
                Gengineregion[] someGengineregions = context.Gengineregions.Where(m => m.Id == id).ToArray();
                context.Gengineregions.Attach(someGengineregions[0]);
                context.Gengineregions.Remove(someGengineregions[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGengineregion")
        .WithOpenApi();
    }
}

