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

public static class GdisktypeEndpoints
{

    public static async void MapGdisktypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gdisktype").WithTags(nameof(Gdisktype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gdisktypes.ToList();
            }

        })
        .WithName("GetAllGdisktypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gdisktypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGdisktypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gdisktype input) =>
        {
            using (var context = new GemContext())
            {
                Gdisktype[] someGdisktype = context.Gdisktypes.Where(m => m.Id == id).ToArray();
                context.Gdisktypes.Attach(someGdisktype[0]);
                someGdisktype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGdisktype")
        .WithOpenApi();

        group.MapPost("/", async (Gdisktype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gdisktypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGdisktype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gdisktypes.Add(std);
                Gdisktype[] someGdisktypes = context.Gdisktypes.Where(m => m.Id == id).ToArray();
                context.Gdisktypes.Attach(someGdisktypes[0]);
                context.Gdisktypes.Remove(someGdisktypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGdisktype")
        .WithOpenApi();
    }
}

