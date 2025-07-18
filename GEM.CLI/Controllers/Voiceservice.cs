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

public static class GvoiceserviceEndpoints
{

    public static async void MapGvoiceserviceEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gvoiceservice").WithTags(nameof(Gvoiceservice));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gvoiceservices.ToList();
            }

        })
        .WithName("GetAllGvoiceservices")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gvoiceservices.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGvoiceserviceById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gvoiceservice input) =>
        {
            using (var context = new GemContext())
            {
                Gvoiceservice[] someGvoiceservice = context.Gvoiceservices.Where(m => m.Id == id).ToArray();
                context.Gvoiceservices.Attach(someGvoiceservice[0]);
                someGvoiceservice[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGvoiceservice")
        .WithOpenApi();

        group.MapPost("/", async (Gvoiceservice input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gvoiceservices.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGvoiceservice")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gvoiceservices.Add(std);
                Gvoiceservice[] someGvoiceservices = context.Gvoiceservices.Where(m => m.Id == id).ToArray();
                context.Gvoiceservices.Attach(someGvoiceservices[0]);
                context.Gvoiceservices.Remove(someGvoiceservices[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGvoiceservice")
        .WithOpenApi();
    }
}

