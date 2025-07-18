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

public static class GcomputerEndpoints
{

    public static async void MapGcomputerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gcomputer").WithTags(nameof(Gcomputer));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gcomputers.ToList();
            }

        })
        .WithName("GetAllGcomputers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gcomputers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGcomputerById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gcomputer input) =>
        {
            using (var context = new GemContext())
            {
                Gcomputer[] someGcomputer = context.Gcomputers.Where(m => m.Id == id).ToArray();
                context.Gcomputers.Attach(someGcomputer[0]);
                someGcomputer[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGcomputer")
        .WithOpenApi();

        group.MapPost("/", async (Gcomputer input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gcomputers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGcomputer")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gcomputers.Add(std);
                Gcomputer[] someGcomputers = context.Gcomputers.Where(m => m.Id == id).ToArray();
                context.Gcomputers.Attach(someGcomputers[0]);
                context.Gcomputers.Remove(someGcomputers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGcomputer")
        .WithOpenApi();
    }
}

