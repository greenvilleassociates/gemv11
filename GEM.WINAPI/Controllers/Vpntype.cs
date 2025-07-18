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

public static class GvpntypeEndpoints
{

    public static async void MapGvpntypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gvpntype").WithTags(nameof(Gvpntype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gvpntypes.ToList();
            }

        })
        .WithName("GetAllGvpntypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gvpntypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGvpntypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gvpntype input) =>
        {
            using (var context = new GemContext())
            {
                Gvpntype[] someGvpntype = context.Gvpntypes.Where(m => m.Id == id).ToArray();
                context.Gvpntypes.Attach(someGvpntype[0]);
                someGvpntype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGvpntype")
        .WithOpenApi();

        group.MapPost("/", async (Gvpntype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gvpntypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGvpntype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gvpntypes.Add(std);
                Gvpntype[] someGvpntypes = context.Gvpntypes.Where(m => m.Id == id).ToArray();
                context.Gvpntypes.Attach(someGvpntypes[0]);
                context.Gvpntypes.Remove(someGvpntypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGvpntype")
        .WithOpenApi();
    }
}

