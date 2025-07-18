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

public static class GcircuittypeEndpoints
{

    public static async void MapGcircuittypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gcircuittype").WithTags(nameof(Gcircuittype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gcircuittypes.ToList();
            }

        })
        .WithName("GetAllGcircuittypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gcircuittypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGcircuittypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gcircuittype input) =>
        {
            using (var context = new GemContext())
            {
                Gcircuittype[] someGcircuittype = context.Gcircuittypes.Where(m => m.Id == id).ToArray();
                context.Gcircuittypes.Attach(someGcircuittype[0]);
                someGcircuittype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGcircuittype")
        .WithOpenApi();

        group.MapPost("/", async (Gcircuittype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gcircuittypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGcircuittype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gcircuittypes.Add(std);
                Gcircuittype[] someGcircuittypes = context.Gcircuittypes.Where(m => m.Id == id).ToArray();
                context.Gcircuittypes.Attach(someGcircuittypes[0]);
                context.Gcircuittypes.Remove(someGcircuittypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGcircuittype")
        .WithOpenApi();
    }
}

