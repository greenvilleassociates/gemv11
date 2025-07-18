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

public static class GtelephonenumberEndpoints
{

    public static async void MapGtelephonenumberEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gtelephonenumber").WithTags(nameof(Gtelephonenumber));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gtelephonenumbers.ToList();
            }

        })
        .WithName("GetAllGtelephonenumbers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gtelephonenumbers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGtelephonenumberById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gtelephonenumber input) =>
        {
            using (var context = new GemContext())
            {
                Gtelephonenumber[] someGtelephonenumber = context.Gtelephonenumbers.Where(m => m.Id == id).ToArray();
                context.Gtelephonenumbers.Attach(someGtelephonenumber[0]);
                someGtelephonenumber[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGtelephonenumber")
        .WithOpenApi();

        group.MapPost("/", async (Gtelephonenumber input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gtelephonenumbers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGtelephonenumber")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gtelephonenumbers.Add(std);
                Gtelephonenumber[] someGtelephonenumbers = context.Gtelephonenumbers.Where(m => m.Id == id).ToArray();
                context.Gtelephonenumbers.Attach(someGtelephonenumbers[0]);
                context.Gtelephonenumbers.Remove(someGtelephonenumbers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGtelephonenumber")
        .WithOpenApi();
    }
}

