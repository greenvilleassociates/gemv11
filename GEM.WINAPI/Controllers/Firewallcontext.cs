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

public static class GfirewallcontextEndpoints
{

    public static async void MapGfirewallcontextEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gfirewallcontext").WithTags(nameof(Gfirewallcontext));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gfirewallcontexts.ToList();
            }

        })
        .WithName("GetAllGfirewallcontexts")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gfirewallcontexts.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGfirewallcontextById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gfirewallcontext input) =>
        {
            using (var context = new GemContext())
            {
                Gfirewallcontext[] someGfirewallcontext = context.Gfirewallcontexts.Where(m => m.Id == id).ToArray();
                context.Gfirewallcontexts.Attach(someGfirewallcontext[0]);
                someGfirewallcontext[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGfirewallcontext")
        .WithOpenApi();

        group.MapPost("/", async (Gfirewallcontext input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gfirewallcontexts.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGfirewallcontext")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gfirewallcontexts.Add(std);
                Gfirewallcontext[] someGfirewallcontexts = context.Gfirewallcontexts.Where(m => m.Id == id).ToArray();
                context.Gfirewallcontexts.Attach(someGfirewallcontexts[0]);
                context.Gfirewallcontexts.Remove(someGfirewallcontexts[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGfirewallcontext")
        .WithOpenApi();
    }
}

