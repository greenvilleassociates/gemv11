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

public static class GappEndpoints
{

    public static async void MapGappEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gapp").WithTags(nameof(Gapp));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gapps.ToList();
            }

        })
        .WithName("GetAllGapps")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gapps.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGappById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gapp input) =>
        {
            using (var context = new GemContext())
            {
                Gapp[] someGapp = context.Gapps.Where(m => m.Id == id).ToArray();
                context.Gapps.Attach(someGapp[0]);
                someGapp[0].Appdescription = input.Appdescription;
                someGapp[0].Appid = input.Appid;
                someGapp[0].Appdescription = input.Appdescription;
                someGapp[0].Apptype = input.Apptype;
                someGapp[0].Appregion = input.Appregion;
                someGapp[0].Dbmstype = input.Dbmstype;
                someGapp[0].Dbmsvendor = input.Dbmsvendor;
                someGapp[0].Dbmstopology = input.Dbmstopology;
		someGapp[0].Gridid = input.Gridid;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }
        })
        .WithName("UpdateGapp")
        .WithOpenApi();

        group.MapPost("/", async (Gapp input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gapps.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGapp")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gapps.Add(std);
                Gapp[] someGapps = context.Gapps.Where(m => m.Id == id).ToArray();
                context.Gapps.Attach(someGapps[0]);
                context.Gapps.Remove(someGapps[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGapp")
        .WithOpenApi();
    }
}

