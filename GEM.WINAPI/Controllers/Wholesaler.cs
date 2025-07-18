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

public static class GwholesalerEndpoints
{

    public static async void MapGwholesalerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gwholesaler").WithTags(nameof(Gwholesaler));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gwholesalers.ToList();
            }

        })
        .WithName("GetAllGwholesalers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gwholesalers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGwholesalerById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gwholesaler input) =>
        {
            using (var context = new GemContext())
            {
                Gwholesaler[] someGwholesaler = context.Gwholesalers.Where(m => m.Id == id).ToArray();
                context.Gwholesalers.Attach(someGwholesaler[0]);
                someGwholesaler[0].Alohaid = input.Alohaid;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGwholesaler")
        .WithOpenApi();

        group.MapPost("/", async (Gwholesaler input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gwholesalers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGwholesaler")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gwholesalers.Add(std);
                Gwholesaler[] someGwholesalers = context.Gwholesalers.Where(m => m.Id == id).ToArray();
                context.Gwholesalers.Attach(someGwholesalers[0]);
                context.Gwholesalers.Remove(someGwholesalers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGwholesaler")
        .WithOpenApi();
    }
}

