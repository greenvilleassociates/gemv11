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

public static class GgatewaytypeEndpoints
{

    public static async void MapGgatewaytypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ggatewaytype").WithTags(nameof(Ggatewaytype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Ggatewaytypes.ToList();
            }

        })
        .WithName("GetAllGgatewaytypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Ggatewaytypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGgatewaytypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ggatewaytype input) =>
        {
            using (var context = new GemContext())
            {
                Ggatewaytype[] someGgatewaytype = context.Ggatewaytypes.Where(m => m.Id == id).ToArray();
                context.Ggatewaytypes.Attach(someGgatewaytype[0]);
                someGgatewaytype[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGgatewaytype")
        .WithOpenApi();

        group.MapPost("/", async (Ggatewaytype input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ggatewaytypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGgatewaytype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Ggatewaytypes.Add(std);
                Ggatewaytype[] someGgatewaytypes = context.Ggatewaytypes.Where(m => m.Id == id).ToArray();
                context.Ggatewaytypes.Attach(someGgatewaytypes[0]);
                context.Ggatewaytypes.Remove(someGgatewaytypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGgatewaytype")
        .WithOpenApi();
    }
}

