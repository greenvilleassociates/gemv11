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

public static class GconduitEndpoints
{

    public static async void MapGconduitEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gconduit").WithTags(nameof(Gconduit));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gconduits.ToList();
            }

        })
        .WithName("GetAllGconduits")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gconduits.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGconduitById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gconduit input) =>
        {
            using (var context = new GemContext())
            {
                Gconduit[] someGconduit = context.Gconduits.Where(m => m.Id == id).ToArray();
                context.Gconduits.Attach(someGconduit[0]);
                someGconduit[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGconduit")
        .WithOpenApi();

        group.MapPost("/", async (Gconduit input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gconduits.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGconduit")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gconduits.Add(std);
                Gconduit[] someGconduits = context.Gconduits.Where(m => m.Id == id).ToArray();
                context.Gconduits.Attach(someGconduits[0]);
                context.Gconduits.Remove(someGconduits[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGconduit")
        .WithOpenApi();
    }
}

