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

public static class GvoicetrunktypeEndpoints
{

    public static async void MapGvoicetrunktypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gvoicetrunktype").WithTags(nameof(Gvoicetrunktype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gvoicetrunktypes.ToList();
            }

        })
        .WithName("GetAllGvoicetrunktypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gvoicetrunktypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGvoicetrunktypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gvoicetrunktype input) =>
        {
            using (var context = new GemContext())
            {
                Gvoicetrunktype[] someGvoicetrunktype = context.Gvoicetrunktypes.Where(m => m.Id == id).ToArray();
                context.Gvoicetrunktypes.Attach(someGvoicetrunktype[0]);
                someGvoicetrunktype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGvoicetrunktype")
        .WithOpenApi();

        group.MapPost("/", async (Gvoicetrunktype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gvoicetrunktypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGvoicetrunktype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gvoicetrunktypes.Add(std);
                Gvoicetrunktype[] someGvoicetrunktypes = context.Gvoicetrunktypes.Where(m => m.Id == id).ToArray();
                context.Gvoicetrunktypes.Attach(someGvoicetrunktypes[0]);
                context.Gvoicetrunktypes.Remove(someGvoicetrunktypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGvoicetrunktype")
        .WithOpenApi();
    }
}

