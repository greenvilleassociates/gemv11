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

public static class GsitetypeEndpoints
{

    public static async void MapGsitetypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gsitetype").WithTags(nameof(Gsitetype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gsitetypes.ToList();
            }

        })
        .WithName("GetAllGsitetypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gsitetypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGsitetypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gsitetype input) =>
        {
            using (var context = new GemContext())
            {
                Gsitetype[] someGsitetype = context.Gsitetypes.Where(m => m.Id == id).ToArray();
                context.Gsitetypes.Attach(someGsitetype[0]);
                someGsitetype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGsitetype")
        .WithOpenApi();

        group.MapPost("/", async (Gsitetype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gsitetypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGsitetype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gsitetypes.Add(std);
                Gsitetype[] someGsitetypes = context.Gsitetypes.Where(m => m.Id == id).ToArray();
                context.Gsitetypes.Attach(someGsitetypes[0]);
                context.Gsitetypes.Remove(someGsitetypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGsitetype")
        .WithOpenApi();
    }
}

