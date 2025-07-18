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

public static class GopticalringEndpoints
{

    public static async void MapGopticalringEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gopticalring").WithTags(nameof(Gopticalring));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gopticalrings.ToList();
            }

        })
        .WithName("GetAllGopticalrings")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gopticalrings.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGopticalringById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gopticalring input) =>
        {
            using (var context = new GemContext())
            {
                Gopticalring[] someGopticalring = context.Gopticalrings.Where(m => m.Id == id).ToArray();
                context.Gopticalrings.Attach(someGopticalring[0]);
                someGopticalring[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGopticalring")
        .WithOpenApi();

        group.MapPost("/", async (Gopticalring input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gopticalrings.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGopticalring")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gopticalrings.Add(std);
                Gopticalring[] someGopticalrings = context.Gopticalrings.Where(m => m.Id == id).ToArray();
                context.Gopticalrings.Attach(someGopticalrings[0]);
                context.Gopticalrings.Remove(someGopticalrings[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGopticalring")
        .WithOpenApi();
    }
}

