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

public static class GvpnEndpoints
{

    public static async void MapGvpnEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gvpn").WithTags(nameof(Gvpn));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gvpns.ToList();
            }

        })
        .WithName("GetAllGvpns")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gvpns.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGvpnById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gvpn input) =>
        {
            using (var context = new GemContext())
            {
                Gvpn[] someGvpn = context.Gvpns.Where(m => m.Id == id).ToArray();
                context.Gvpns.Attach(someGvpn[0]);
                someGvpn[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGvpn")
        .WithOpenApi();

        group.MapPost("/", async (Gvpn input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gvpns.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGvpn")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gvpns.Add(std);
                Gvpn[] someGvpns = context.Gvpns.Where(m => m.Id == id).ToArray();
                context.Gvpns.Attach(someGvpns[0]);
                context.Gvpns.Remove(someGvpns[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGvpn")
        .WithOpenApi();
    }
}

