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

public static class GfirewallEndpoints
{

    public static async void MapGfirewallEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gfirewall").WithTags(nameof(Gfirewall));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gfirewalls.ToList();
            }

        })
        .WithName("GetAllGfirewalls")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gfirewalls.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGfirewallById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gfirewall input) =>
        {
            using (var context = new GemContext())
            {
                Gfirewall[] someGfirewall = context.Gfirewalls.Where(m => m.Id == id).ToArray();
                context.Gfirewalls.Attach(someGfirewall[0]);
                someGfirewall[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGfirewall")
        .WithOpenApi();

        group.MapPost("/", async (Gfirewall input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gfirewalls.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGfirewall")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gfirewalls.Add(std);
                Gfirewall[] someGfirewalls = context.Gfirewalls.Where(m => m.Id == id).ToArray();
                context.Gfirewalls.Attach(someGfirewalls[0]);
                context.Gfirewalls.Remove(someGfirewalls[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGfirewall")
        .WithOpenApi();
    }
}

