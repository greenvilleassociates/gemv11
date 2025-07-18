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

public static class GdataservicesEndpoints
{

    public static async void MapGdataservicesEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gdataservices").WithTags(nameof(Gdataservice));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gdataservices.ToList();
            }

        })
        .WithName("GetAllGdataservices")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gdataservices.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGdataservicesById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gdataservice input) =>
        {
            using (var context = new GemContext())
            {
                Gdataservice[] someGdataservices = context.Gdataservices.Where(m => m.Id == id).ToArray();
                context.Gdataservices.Attach(someGdataservices[0]);
                someGdataservices[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGdataservices")
        .WithOpenApi();

        group.MapPost("/", async (Gdataservice input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gdataservices.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGdataservices")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gdataservicess.Add(std);
                Gdataservice[] someGdataservicess = context.Gdataservices.Where(m => m.Id == id).ToArray();
                context.Gdataservices.Attach(someGdataservicess[0]);
                context.Gdataservices.Remove(someGdataservicess[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGdataservices")
        .WithOpenApi();
    }
}

