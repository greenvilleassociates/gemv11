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

public static class GrackEndpoints
{

    public static async void MapRackEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Grack").WithTags(nameof(Grack));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gracks.ToList();
            }

        })
        .WithName("GetAllGracks")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gracks.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGracksById")
        .WithOpenApi();
        //[HttpPut]
        group.MapPut("/{id}", (int id, Grack input) =>
        {
            using (var context = new GemContext())
            {
                Grack[] someGrack = context.Gracks.Where(m => m.Id == id).ToArray();
                context.Gracks.Attach(someGrack[0]);
                someGrack[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGrack")
        .WithOpenApi();

        group.MapPost("/", async (Grack input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gracks.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGrack")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                Grack[] someGrack = context.Gracks.Where(m => m.Id == id).ToArray();
                context.Gracks.Attach(someGrack[0]);
                context.Gracks.Remove(someGrack[0]);
                context.SaveChangesAsync();
            }

        })
        .WithName("DeleteGrack")
        .WithOpenApi();
    }
}

