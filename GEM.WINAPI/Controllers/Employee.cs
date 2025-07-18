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

public static class GemployeeEndpoints
{

    public static async void MapGemployeeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gemployee").WithTags(nameof(Gemployee));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gemployees.ToList();
            }

        })
        .WithName("GetAllGemployees")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gemployees.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGemployeeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gemployee input) =>
        {
            using (var context = new GemContext())
            {
                Gemployee[] someGemployee = context.Gemployees.Where(m => m.Id == id).ToArray();
                context.Gemployees.Attach(someGemployee[0]);
                someGemployee[0].Fullname = input.Fullname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGemployee")
        .WithOpenApi();

        group.MapPost("/", async (Gemployee input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gemployees.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGemployee")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gemployees.Add(std);
                Gemployee[] someGemployees = context.Gemployees.Where(m => m.Id == id).ToArray();
                context.Gemployees.Attach(someGemployees[0]);
                context.Gemployees.Remove(someGemployees[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGemployee")
        .WithOpenApi();
    }
}

