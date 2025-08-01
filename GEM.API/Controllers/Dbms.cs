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

public static class GdbmsEndpoints
{

    public static async void MapGdbmsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gdbms").WithTags(nameof(Gdbmsinstance));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gdbmsinstances.ToList();

            }

        })
        .WithName("GetAllGdbms")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gdbmsinstances.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGdbmsById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gdbmsinstance input) =>
        {
            using (var context = new GemContext())
            {
                Gdbmsinstance[] someGdbms = context.Gdbmsinstances.Where(m => m.Id == id).ToArray();
                context.Gdbmsinstances.Attach(someGdbms[0]);
                someGdbms[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGdbms")
        .WithOpenApi();

        group.MapPost("/", async (Gdbmsinstance input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gdbmsinstances.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGdbms")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Grouters.Add(std);
                Gdbmsinstance[] someGdbms = context.Gdbmsinstances.Where(m => m.Id == id).ToArray();
                context.Gdbmsinstances.Attach(someGdbms[0]);
                context.Gdbmsinstances.Remove(someGdbms[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGdbms")
        .WithOpenApi();
    }
}

