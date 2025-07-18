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

public static class GgatewayEndpoints
{

    public static async void MapGgatewayEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ggateway").WithTags(nameof(Ggateway));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ggateways.ToList();
            }

        })
        .WithName("GetAllGgateways")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ggateways.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGgatewayById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ggateway input) =>
        {
            using (var context = new GemContext())
            {
                Ggateway[] someGgateway = context.Ggateways.Where(m => m.Id == id).ToArray();
                context.Ggateways.Attach(someGgateway[0]);
                someGgateway[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGgateway")
        .WithOpenApi();

        group.MapPost("/", async (Ggateway input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ggateways.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGgateway")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ggateways.Add(std);
                Ggateway[] someGgateways = context.Ggateways.Where(m => m.Id == id).ToArray();
                context.Ggateways.Attach(someGgateways[0]);
                context.Ggateways.Remove(someGgateways[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGgateway")
        .WithOpenApi();
    }
}

