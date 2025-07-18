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

public static class GgridEndpoints
{

    public static async void MapGgridEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ggrid").WithTags(nameof(Ggrid));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ggrids.ToList();
            }

        })
        .WithName("GetAllGgrids")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ggrids.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGgridById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ggrid input) =>
        {
            using (var context = new GemContext())
            {
                Ggrid[] someGgrid = context.Ggrids.Where(m => m.Id == id).ToArray();
                context.Ggrids.Attach(someGgrid[0]);
                someGgrid[0].Vendor = input.Vendor;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGgrid")
        .WithOpenApi();

        group.MapPost("/", async (Ggrid input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ggrids.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGgrid")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ggrids.Add(std);
                Ggrid[] someGgrids = context.Ggrids.Where(m => m.Id == id).ToArray();
                context.Ggrids.Attach(someGgrids[0]);
                context.Ggrids.Remove(someGgrids[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGgrid")
        .WithOpenApi();
    }
}

