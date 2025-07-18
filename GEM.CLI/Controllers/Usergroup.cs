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

public static class GusergroupEndpoints
{

    public static async void MapGusergroupEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gusergroup").WithTags(nameof(Gusergroup));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gusergroups.ToList();
            }

        })
        .WithName("GetAllGusergroups")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gusergroups.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGusergroupById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gusergroup input) =>
        {
            using (var context = new GemContext())
            {
                Gusergroup[] someGusergroup = context.Gusergroups.Where(m => m.Id == id).ToArray();
                context.Gusergroups.Attach(someGusergroup[0]);
                someGusergroup[0].Groupname = input.Groupname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGusergroup")
        .WithOpenApi();

        group.MapPost("/", async (Gusergroup input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gusergroups.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGusergroup")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gusergroups.Add(std);
                Gusergroup[] someGusergroups = context.Gusergroups.Where(m => m.Id == id).ToArray();
                context.Gusergroups.Attach(someGusergroups[0]);
                context.Gusergroups.Remove(someGusergroups[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGusergroup")
        .WithOpenApi();
    }
}

