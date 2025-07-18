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

public static class GrouterEndpoints
{

    public static async void MapGrouterEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Grouter").WithTags(nameof(Grouter));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Grouters.ToList();
            }

        })
        .WithName("GetAllGrouters")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Grouters.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGrouterById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Grouter input) =>
        {
            using (var context = new GemContext())
            {
                Grouter[] someGrouter = context.Grouters.Where(m => m.Id == id).ToArray();
                context.Grouters.Attach(someGrouter[0]);
                someGrouter[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGrouter")
        .WithOpenApi();

        group.MapPost("/", async (Grouter input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Grouters.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGrouter")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Grouters.Add(std);
                Grouter[] someGrouters = context.Grouters.Where(m => m.Id == id).ToArray();
                context.Grouters.Attach(someGrouters[0]);
                context.Grouters.Remove(someGrouters[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGrouter")
        .WithOpenApi();
    }
}

