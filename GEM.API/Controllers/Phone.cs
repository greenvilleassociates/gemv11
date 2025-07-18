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

public static class GphoneEndpoints
{

    public static async void MapGphoneEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gphone").WithTags(nameof(Gphone));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gphones.ToList();
            }

        })
        .WithName("GetAllGphones")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gphones.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGphoneById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gphone input) =>
        {
            using (var context = new GemContext())
            {
                Gphone[] someGphone = context.Gphones.Where(m => m.Id == id).ToArray();
                context.Gphones.Attach(someGphone[0]);
                someGphone[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGphone")
        .WithOpenApi();

        group.MapPost("/", async (Gphone input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gphones.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGphone")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gphones.Add(std);
                Gphone[] someGphones = context.Gphones.Where(m => m.Id == id).ToArray();
                context.Gphones.Attach(someGphones[0]);
                context.Gphones.Remove(someGphones[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGphone")
        .WithOpenApi();
    }
}

