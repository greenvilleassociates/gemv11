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

public static class GchannelEndpoints
{

    public static async void MapGchannelEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gchannel").WithTags(nameof(Gchannel));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gchannels.ToList();
            }

        })
        .WithName("GetAllGchannels")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gchannels.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGchannelById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gchannel input) =>
        {
            using (var context = new GemContext())
            {
                Gchannel[] someGchannel = context.Gchannels.Where(m => m.Id == id).ToArray();
                context.Gchannels.Attach(someGchannel[0]);
                someGchannel[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGchannel")
        .WithOpenApi();

        group.MapPost("/", async (Gchannel input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gchannels.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGchannel")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gchannels.Add(std);
                Gchannel[] someGchannels = context.Gchannels.Where(m => m.Id == id).ToArray();
                context.Gchannels.Attach(someGchannels[0]);
                context.Gchannels.Remove(someGchannels[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGchannel")
        .WithOpenApi();
    }
}

