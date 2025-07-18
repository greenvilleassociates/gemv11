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

public static class GserverEndpoints
{

    public static async void MapGserverEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gserver").WithTags(nameof(Gserver));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gservers.ToList();
            }

        })
        .WithName("GetAllGservers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gservers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGserverById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gserver input) =>
        {
            using (var context = new GemContext())
            {
                Gserver[] someGserver = context.Gservers.Where(m => m.Id == id).ToArray();
                context.Gservers.Attach(someGserver[0]);
                someGserver[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGserver")
        .WithOpenApi();

        group.MapPost("/", async (Gserver input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gservers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGserver")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gservers.Add(std);
                Gserver[] someGservers = context.Gservers.Where(m => m.Id == id).ToArray();
                context.Gservers.Attach(someGservers[0]);
                context.Gservers.Remove(someGservers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGserver")
        .WithOpenApi();
    }
}

