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

public static class GproductEndpoints
{

    public static async void MapGproductEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gproduct").WithTags(nameof(Gproduct));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gproducts.ToList();
            }

        })
        .WithName("GetAllGproducts")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gproducts.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGproductById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gproduct input) =>
        {
            using (var context = new GemContext())
            {
                Gproduct[] someGproduct = context.Gproducts.Where(m => m.Id == id).ToArray();
                context.Gproducts.Attach(someGproduct[0]);
                someGproduct[0].Vendorid = input.Vendorid;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGproduct")
        .WithOpenApi();

        group.MapPost("/", async (Gproduct input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gproducts.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGproduct")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gproducts.Add(std);
                Gproduct[] someGproducts = context.Gproducts.Where(m => m.Id == id).ToArray();
                context.Gproducts.Attach(someGproducts[0]);
                context.Gproducts.Remove(someGproducts[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGproduct")
        .WithOpenApi();
    }
}

