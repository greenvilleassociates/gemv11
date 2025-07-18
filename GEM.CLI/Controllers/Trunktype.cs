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

public static class GtrunktypeEndpoints
{

    public static async void MapGtrunktypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gtrunktype").WithTags(nameof(Gtrunktype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gtrunktypes.ToList();
            }

        })
        .WithName("GetAllGtrunktypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gtrunktypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGtrunktypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gtrunktype input) =>
        {
            using (var context = new GemContext())
            {
                Gtrunktype[] someGtrunktype = context.Gtrunktypes.Where(m => m.Id == id).ToArray();
                context.Gtrunktypes.Attach(someGtrunktype[0]);
                someGtrunktype[0].Description = input.Description;
                someGtrunktype[0].Trunktypeid = input.Trunktypeid;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGtrunktype")
        .WithOpenApi();

        group.MapPost("/", async (Gtrunktype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gtrunktypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGtrunktype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gtrunktypes.Add(std);
                Gtrunktype[] someGtrunktypes = context.Gtrunktypes.Where(m => m.Id == id).ToArray();
                context.Gtrunktypes.Attach(someGtrunktypes[0]);
                context.Gtrunktypes.Remove(someGtrunktypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGtrunktype")
        .WithOpenApi();
    }
}

