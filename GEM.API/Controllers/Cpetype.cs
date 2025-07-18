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

public static class GcpetypeEndpoints
{

    public static async void MapGcpetypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gcpetype").WithTags(nameof(Gcpetype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gcpetypes.ToList();
            }

        })
        .WithName("GetAllGcpetypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gcpetypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGcpetypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gcpetype input) =>
        {
            using (var context = new GemContext())
            {
                Gcpetype[] someGcpetype = context.Gcpetypes.Where(m => m.Id == id).ToArray();
                context.Gcpetypes.Attach(someGcpetype[0]);
                someGcpetype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGcpetype")
        .WithOpenApi();

        group.MapPost("/", async (Gcpetype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gcpetypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGcpetype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gcpetypes.Add(std);
                Gcpetype[] someGcpetypes = context.Gcpetypes.Where(m => m.Id == id).ToArray();
                context.Gcpetypes.Attach(someGcpetypes[0]);
                context.Gcpetypes.Remove(someGcpetypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGcpetype")
        .WithOpenApi();
    }
}

