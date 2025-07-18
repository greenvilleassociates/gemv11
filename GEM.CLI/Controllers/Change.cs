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

public static class GchangeEndpoints
{

    public static async void MapGchangeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gchange").WithTags(nameof(Gchange));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gchanges.ToList();
            }

        })
        .WithName("GetAllGchanges")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gchanges.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGchangeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gchange input) =>
        {
            using (var context = new GemContext())
            {
                Gchange[] someGchange = context.Gchanges.Where(m => m.Id == id).ToArray();
                context.Gchanges.Attach(someGchange[0]);
                someGchange[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGchange")
        .WithOpenApi();

        group.MapPost("/", async (Gchange input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gchanges.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGchange")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gchanges.Add(std);
                Gchange[] someGchanges = context.Gchanges.Where(m => m.Id == id).ToArray();
                context.Gchanges.Attach(someGchanges[0]);
                context.Gchanges.Remove(someGchanges[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGchange")
        .WithOpenApi();
    }
}

