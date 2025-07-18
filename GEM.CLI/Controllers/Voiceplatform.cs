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

public static class GvoiceplatformEndpoints
{

    public static async void MapGvoiceplatformEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gvoiceplatform").WithTags(nameof(Gvoiceplatform));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gvoiceplatforms.ToList();
            }

        })
        .WithName("GetAllGvoiceplatforms")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gvoiceplatforms.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGvoiceplatformById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gvoiceplatform input) =>
        {
            using (var context = new GemContext())
            {
                Gvoiceplatform[] someGvoiceplatform = context.Gvoiceplatforms.Where(m => m.Id == id).ToArray();
                context.Gvoiceplatforms.Attach(someGvoiceplatform[0]);
                someGvoiceplatform[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGvoiceplatform")
        .WithOpenApi();

        group.MapPost("/", async (Gvoiceplatform input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gvoiceplatforms.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGvoiceplatform")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gvoiceplatforms.Add(std);
                Gvoiceplatform[] someGvoiceplatforms = context.Gvoiceplatforms.Where(m => m.Id == id).ToArray();
                context.Gvoiceplatforms.Attach(someGvoiceplatforms[0]);
                context.Gvoiceplatforms.Remove(someGvoiceplatforms[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGvoiceplatform")
        .WithOpenApi();
    }
}

