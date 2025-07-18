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

public static class GitsmEndpoints
{

    public static async void MapGitsmEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gitsm").WithTags(nameof(Gitsm));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gitsms.ToList();
            }

        })
        .WithName("GetAllGitsms")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gitsms.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGitsmById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gitsm input) =>
        {
            using (var context = new GemContext())
            {
                Gitsm[] someGitsm = context.Gitsms.Where(m => m.Id == id).ToArray();
                context.Gitsms.Attach(someGitsm[0]);
                someGitsm[0].Summary = input.Summary;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGitsm")
        .WithOpenApi();

        group.MapPost("/", async (Gitsm input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gitsms.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGitsm")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gitsms.Add(std);
                Gitsm[] someGitsms = context.Gitsms.Where(m => m.Id == id).ToArray();
                context.Gitsms.Attach(someGitsms[0]);
                context.Gitsms.Remove(someGitsms[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGitsm")
        .WithOpenApi();
    }
}

