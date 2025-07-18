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

public static class GopttypeEndpoints
{

    public static async void MapGopttypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gopttype").WithTags(nameof(Gopttype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gopttypes.ToList();
            }

        })
        .WithName("GetAllGopttypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gopttypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGopttypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gopttype input) =>
        {
            using (var context = new GemContext())
            {
                Gopttype[] someGopttype = context.Gopttypes.Where(m => m.Id == id).ToArray();
                context.Gopttypes.Attach(someGopttype[0]);
                someGopttype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGopttype")
        .WithOpenApi();

        group.MapPost("/", async (Gopttype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gopttypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGopttype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gopttypes.Add(std);
                Gopttype[] someGopttypes = context.Gopttypes.Where(m => m.Id == id).ToArray();
                context.Gopttypes.Attach(someGopttypes[0]);
                context.Gopttypes.Remove(someGopttypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGopttype")
        .WithOpenApi();
    }
}

