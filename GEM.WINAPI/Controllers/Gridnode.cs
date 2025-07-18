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

public static class GgridnodeEndpoints
{

    public static async void MapGgridnodeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ggridnode").WithTags(nameof(Ggridnode));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ggridnodes.ToList();
            }

        })
        .WithName("GetAllGgridnodes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ggridnodes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGgridnodeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ggridnode input) =>
        {
            using (var context = new GemContext())
            {
                Ggridnode[] someGgridnode = context.Ggridnodes.Where(m => m.Id == id).ToArray();
                context.Ggridnodes.Attach(someGgridnode[0]);
                someGgridnode[0].Ipaddress = input.Ipaddress;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGgridnode")
        .WithOpenApi();

        group.MapPost("/", async (Ggridnode input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ggridnodes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGgridnode")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ggridnodes.Add(std);
                Ggridnode[] someGgridnodes = context.Ggridnodes.Where(m => m.Id == id).ToArray();
                context.Ggridnodes.Attach(someGgridnodes[0]);
                context.Ggridnodes.Remove(someGgridnodes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGgridnode")
        .WithOpenApi();
    }
}

