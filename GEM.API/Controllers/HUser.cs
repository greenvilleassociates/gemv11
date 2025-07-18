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

public static class HUserEndpoints
{

    public static async void MapHUserEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/HUser").WithTags(nameof(HUser));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.HUsers.ToList();
            }

        })
        .WithName("GetAllHUsers")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.HUsers.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetHUserById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, HUser input) =>
        {
            using (var context = new GemContext())
            {
                HUser[] someHUser = context.HUsers.Where(m => m.Id == id).ToArray();
                context.HUsers.Attach(someHUser[0]);
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateHUser")
        .WithOpenApi();

        group.MapPost("/", async (HUser input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.HUsers.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateHUser")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.HUsers.Add(std);
                HUser[] someHUsers = context.HUsers.Where(m => m.Id == id).ToArray();
                context.HUsers.Attach(someHUsers[0]);
                context.HUsers.Remove(someHUsers[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteHUser")
        .WithOpenApi();
    }
}

