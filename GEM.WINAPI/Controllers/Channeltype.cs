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

public static class GchanneltypeEndpoints
{

    public static async void MapGchanneltypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gchanneltype").WithTags(nameof(Gchanneltype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gchanneltypes.ToList();
            }

        })
        .WithName("GetAllGchanneltypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gchanneltypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGchanneltypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gchanneltype input) =>
        {
            using (var context = new GemContext())
            {
                Gchanneltype[] someGchanneltype = context.Gchanneltypes.Where(m => m.Id == id).ToArray();
                context.Gchanneltypes.Attach(someGchanneltype[0]);
                someGchanneltype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGchanneltype")
        .WithOpenApi();

        group.MapPost("/", async (Gchanneltype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gchanneltypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGchanneltype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gchanneltypes.Add(std);
                Gchanneltype[] someGchanneltypes = context.Gchanneltypes.Where(m => m.Id == id).ToArray();
                context.Gchanneltypes.Attach(someGchanneltypes[0]);
                context.Gchanneltypes.Remove(someGchanneltypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGchanneltype")
        .WithOpenApi();
    }
}

