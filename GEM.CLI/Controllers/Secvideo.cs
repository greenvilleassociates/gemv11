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

public static class GsecvideoEndpoints
{

    public static async void MapGsecvideoEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gsecvideo").WithTags(nameof(Gsecvideo));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gsecvideos.ToList();
            }

        })
        .WithName("GetAllGsecvideos")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gsecvideos.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGsecvideoById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gsecvideo input) =>
        {
            using (var context = new GemContext())
            {
                Gsecvideo[] someGsecvideo = context.Gsecvideos.Where(m => m.Id == id).ToArray();
                context.Gsecvideos.Attach(someGsecvideo[0]);
                someGsecvideo[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGsecvideo")
        .WithOpenApi();

        group.MapPost("/", async (Gsecvideo input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gsecvideos.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGsecvideo")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gsecvideos.Add(std);
                Gsecvideo[] someGsecvideos = context.Gsecvideos.Where(m => m.Id == id).ToArray();
                context.Gsecvideos.Attach(someGsecvideos[0]);
                context.Gsecvideos.Remove(someGsecvideos[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGsecvideo")
        .WithOpenApi();
    }
}

