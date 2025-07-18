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

public static class GapptypeEndpoints
{

    public static async void MapGapptypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gapptype").WithTags(nameof(Gapptype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gapptypes.ToList();
            }

        })
        .WithName("GetAllGapptypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gapptypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGapptypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gapptype input) =>
        {
            using (var context = new GemContext())
            {
                Gapptype[] someGapptype = context.Gapptypes.Where(m => m.Id == id).ToArray();
                context.Gapptypes.Attach(someGapptype[0]);
                someGapptype[0].Apptypedescription = input.Apptypedescription;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGapptype")
        .WithOpenApi();

        group.MapPost("/", async (Gapptype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gapptypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGapptype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gapptypes.Add(std);
                Gapptype[] someGapptypes = context.Gapptypes.Where(m => m.Id == id).ToArray();
                context.Gapptypes.Attach(someGapptypes[0]);
                context.Gapptypes.Remove(someGapptypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGapptype")
        .WithOpenApi();
    }
}

