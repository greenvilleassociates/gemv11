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

public static class GuserEndpoints
{

    public static async void MapGuserEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Guser").WithTags(nameof(Guser));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gusers.ToList();
            }

        })
        .WithName("GetAllGusers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gusers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGuserById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Guser input) =>
        {
            using (var context = new GemContext())
            {
                Guser[] someGuser = context.Gusers.Where(m => m.Id == id).ToArray();
                context.Gusers.Attach(someGuser[0]);
                someGuser[0].Fullname = input.Fullname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGuser")
        .WithOpenApi();

        group.MapPost("/", async (Guser input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gusers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGuser")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gusers.Add(std);
                Guser[] someGusers = context.Gusers.Where(m => m.Id == id).ToArray();
                context.Gusers.Attach(someGusers[0]);
                context.Gusers.Remove(someGusers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGuser")
        .WithOpenApi();
    }
}

