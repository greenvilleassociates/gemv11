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

public static class GaccountEndpoints
{

    public static async void MapGaccountEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gaccount").WithTags(nameof(Gaccount));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gaccounts.ToList();
            }

        })
        .WithName("GetAllGaccounts")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gaccounts.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGaccountById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gaccount input) =>
        {
            using (var context = new GemContext())
            {
                Gaccount[] someGaccount = context.Gaccounts.Where(m => m.Id == id).ToArray();
                context.Gaccounts.Attach(someGaccount[0]);
                someGaccount[0].Accountname = input.Accountname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGaccount")
        .WithOpenApi();

        group.MapPost("/", async (Gaccount input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gaccounts.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGaccount")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gaccounts.Add(std);
                Gaccount[] someGaccounts = context.Gaccounts.Where(m => m.Id == id).ToArray();
                context.Gaccounts.Attach(someGaccounts[0]);
                context.Gaccounts.Remove(someGaccounts[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGaccount")
        .WithOpenApi();
    }
}

