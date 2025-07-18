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

public static class GnetworktypeEndpoints
{

    public static async void MapGnetworktypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gnetworktype").WithTags(nameof(Gnetworktype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gnetworktypes.ToList();
            }

        })
        .WithName("GetAllGnetworktypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gnetworktypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGnetworktypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gnetworktype input) =>
        {
            using (var context = new GemContext())
            {
                Gnetworktype[] someGnetworktype = context.Gnetworktypes.Where(m => m.Id == id).ToArray();
                context.Gnetworktypes.Attach(someGnetworktype[0]);
                someGnetworktype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGnetworktype")
        .WithOpenApi();

        group.MapPost("/", async (Gnetworktype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gnetworktypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGnetworktype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gnetworktypes.Add(std);
                Gnetworktype[] someGnetworktypes = context.Gnetworktypes.Where(m => m.Id == id).ToArray();
                context.Gnetworktypes.Attach(someGnetworktypes[0]);
                context.Gnetworktypes.Remove(someGnetworktypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGnetworktype")
        .WithOpenApi();
    }
}

