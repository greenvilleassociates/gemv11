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

public static class GinventorytypeEndpoints
{

    public static async void MapGinventorytypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ginventorytype").WithTags(nameof(Ginventorytype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ginventorytypes.ToList();
            }

        })
        .WithName("GetAllGinventorytypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ginventorytypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGinventorytypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ginventorytype input) =>
        {
            using (var context = new GemContext())
            {
                Ginventorytype[] someGinventorytype = context.Ginventorytypes.Where(m => m.Id == id).ToArray();
                context.Ginventorytypes.Attach(someGinventorytype[0]);
                someGinventorytype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGinventorytype")
        .WithOpenApi();

        group.MapPost("/", async (Ginventorytype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ginventorytypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGinventorytype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ginventorytypes.Add(std);
                Ginventorytype[] someGinventorytypes = context.Ginventorytypes.Where(m => m.Id == id).ToArray();
                context.Ginventorytypes.Attach(someGinventorytypes[0]);
                context.Ginventorytypes.Remove(someGinventorytypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGinventorytype")
        .WithOpenApi();
    }
}

