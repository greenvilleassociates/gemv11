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

public static class GvolumeEndpoints
{

    public static async void MapGvolumeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gvolume").WithTags(nameof(Gvolume));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gvolumes.ToList();
            }

        })
        .WithName("GetAllGvolumes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gvolumes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGvolumeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gvolume input) =>
        {
            using (var context = new GemContext())
            {
                Gvolume[] someGvolume = context.Gvolumes.Where(m => m.Id == id).ToArray();
                context.Gvolumes.Attach(someGvolume[0]);
                someGvolume[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGvolume")
        .WithOpenApi();

        group.MapPost("/", async (Gvolume input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gvolumes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGvolume")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gvolumes.Add(std);
                Gvolume[] someGvolumes = context.Gvolumes.Where(m => m.Id == id).ToArray();
                context.Gvolumes.Attach(someGvolumes[0]);
                context.Gvolumes.Remove(someGvolumes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGvolume")
        .WithOpenApi();
    }
}

