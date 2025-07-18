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

public static class GswitchEndpoints
{

    public static async void MapGswitchEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gswitch").WithTags(nameof(Gswitch));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gswitches.ToList();
            }

        })
        .WithName("GetAllGswitchs")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gswitches.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGswitchById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gswitch input) =>
        {
            using (var context = new GemContext())
            {
                Gswitch[] someGswitch = context.Gswitches.Where(m => m.Id == id).ToArray();
                context.Gswitches.Attach(someGswitch[0]);
                someGswitch[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGswitch")
        .WithOpenApi();

        group.MapPost("/", async (Gswitch input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gswitches.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGswitch")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gswitchs.Add(std);
                Gswitch[] someGswitchs = context.Gswitches.Where(m => m.Id == id).ToArray();
                context.Gswitches.Attach(someGswitchs[0]);
                context.Gswitches.Remove(someGswitchs[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGswitch")
        .WithOpenApi();
    }
}

