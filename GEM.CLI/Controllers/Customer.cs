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

public static class GcustomerEndpoints
{

    public static async void MapGcustomerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gcustomer").WithTags(nameof(Gcustomer));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gcustomers.ToList();
            }

        })
        .WithName("GetAllGcustomers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gcustomers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGcustomerById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gcustomer input) =>
        {
            using (var context = new GemContext())
            {
                Gcustomer[] someGcustomer = context.Gcustomers.Where(m => m.Id == id).ToArray();
                context.Gcustomers.Attach(someGcustomer[0]);
                someGcustomer[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGcustomer")
        .WithOpenApi();

        group.MapPost("/", async (Gcustomer input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gcustomers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGcustomer")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gcustomers.Add(std);
                Gcustomer[] someGcustomers = context.Gcustomers.Where(m => m.Id == id).ToArray();
                context.Gcustomers.Attach(someGcustomers[0]);
                context.Gcustomers.Remove(someGcustomers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGcustomer")
        .WithOpenApi();
    }
}

