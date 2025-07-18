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

public static class GmanagerEndpoints
{

    public static async void MapGmanagerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gmanager").WithTags(nameof(Gmanager));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gmanagers.ToList();
            }

        })
        .WithName("GetAllGmanagers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gmanagers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGmanagerById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gmanager input) =>
        {
            using (var context = new GemContext())
            {
                Gmanager[] someGmanager = context.Gmanagers.Where(m => m.Id == id).ToArray();
                context.Gmanagers.Attach(someGmanager[0]);
                someGmanager[0].Fullname = input.Fullname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGmanager")
        .WithOpenApi();

        group.MapPost("/", async (Gmanager input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gmanagers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGmanager")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gmanagers.Add(std);
                Gmanager[] someGmanagers = context.Gmanagers.Where(m => m.Id == id).ToArray();
                context.Gmanagers.Attach(someGmanagers[0]);
                context.Gmanagers.Remove(someGmanagers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGmanager")
        .WithOpenApi();
    }
}

