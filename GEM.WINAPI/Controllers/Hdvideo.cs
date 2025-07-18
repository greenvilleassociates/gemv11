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

public static class GhdvideoEndpoints
{

    public static async void MapGhdvideoEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ghdvideo").WithTags(nameof(Ghdvideo));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ghdvideos.ToList();
            }

        })
        .WithName("GetAllGhdvideos")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ghdvideos.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGhdvideoById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ghdvideo input) =>
        {
            using (var context = new GemContext())
            {
                Ghdvideo[] someGhdvideo = context.Ghdvideos.Where(m => m.Id == id).ToArray();
                context.Ghdvideos.Attach(someGhdvideo[0]);
                someGhdvideo[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGhdvideo")
        .WithOpenApi();

        group.MapPost("/", async (Ghdvideo input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ghdvideos.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGhdvideo")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ghdvideos.Add(std);
                Ghdvideo[] someGhdvideos = context.Ghdvideos.Where(m => m.Id == id).ToArray();
                context.Ghdvideos.Attach(someGhdvideos[0]);
                context.Ghdvideos.Remove(someGhdvideos[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGhdvideo")
        .WithOpenApi();
    }
}

