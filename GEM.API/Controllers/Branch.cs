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

public static class GbranchEndpoints
{

    public static async void MapGbranchEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gbranch").WithTags(nameof(Gbranch));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gbranches.ToList();
            }

        })
        .WithName("GetAllGbranchs")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gbranches.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGbranchById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gbranch input) =>
        {
            using (var context = new GemContext())
            {
                Gbranch[] someGbranch = context.Gbranches.Where(m => m.Id == id).ToArray();
                context.Gbranches.Attach(someGbranch[0]);
                someGbranch[0].Brancdescription = input.Brancdescription;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGbranch")
        .WithOpenApi();

        group.MapPost("/", async (Gbranch input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gbranches.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGbranch")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gbranchs.Add(std);
                Gbranch[] someGbranchs = context.Gbranches.Where(m => m.Id == id).ToArray();
                context.Gbranches.Attach(someGbranchs[0]);
                context.Gbranches.Remove(someGbranchs[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGbranch")
        .WithOpenApi();
    }
}

