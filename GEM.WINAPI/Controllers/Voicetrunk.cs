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

public static class GvoicetrunkEndpoints
{

    public static async void MapGvoicetrunkEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gvoicetrunk").WithTags(nameof(Gvoicetrunk));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gvoicetrunks.ToList();
            }

        })
        .WithName("GetAllGvoicetrunks")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gvoicetrunks.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGvoicetrunkById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gvoicetrunk input) =>
        {
            using (var context = new GemContext())
            {
                Gvoicetrunk[] someGvoicetrunk = context.Gvoicetrunks.Where(m => m.Id == id).ToArray();
                context.Gvoicetrunks.Attach(someGvoicetrunk[0]);
                someGvoicetrunk[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGvoicetrunk")
        .WithOpenApi();

        group.MapPost("/", async (Gvoicetrunk input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gvoicetrunks.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGvoicetrunk")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gvoicetrunks.Add(std);
                Gvoicetrunk[] someGvoicetrunks = context.Gvoicetrunks.Where(m => m.Id == id).ToArray();
                context.Gvoicetrunks.Attach(someGvoicetrunks[0]);
                context.Gvoicetrunks.Remove(someGvoicetrunks[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGvoicetrunk")
        .WithOpenApi();
    }
}

