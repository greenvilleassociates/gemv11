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

public static class GserviceordertypeEndpoints
{

    public static async void MapGserviceordertypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gserviceordertype").WithTags(nameof(Gserviceordertype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gserviceordertypes.ToList();
            }

        })
        .WithName("GetAllGserviceordertypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gserviceordertypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGserviceordertypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gserviceordertype input) =>
        {
            using (var context = new GemContext())
            {
                Gserviceordertype[] someGserviceordertype = context.Gserviceordertypes.Where(m => m.Id == id).ToArray();
                context.Gserviceordertypes.Attach(someGserviceordertype[0]);
                someGserviceordertype[0].Servicetypedescription = input.Servicetypedescription;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGserviceordertype")
        .WithOpenApi();

        group.MapPost("/", async (Gserviceordertype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gserviceordertypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGserviceordertype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gserviceordertypes.Add(std);
                Gserviceordertype[] someGserviceordertypes = context.Gserviceordertypes.Where(m => m.Id == id).ToArray();
                context.Gserviceordertypes.Attach(someGserviceordertypes[0]);
                context.Gserviceordertypes.Remove(someGserviceordertypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGserviceordertype")
        .WithOpenApi();
    }
}

