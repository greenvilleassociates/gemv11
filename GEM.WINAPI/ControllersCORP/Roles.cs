using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using Enterprise.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http;
using GEMAPI.ModelsCORP;
namespace Enterprise.Controllers;

public static class RoleEndpoints
{

    public static async void MapRoleEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Role").WithTags(nameof(Role));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Roles.ToList();
            }

        })
        .WithName("GetAllRoles")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Roles.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetRoleById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Role input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Role[] someRole = context.Roles.Where(m => m.Id == id).ToArray();
                context.Roles.Attach(someRole[0]);
                someRole[0].Roledescription = input.Roledescription;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateRole")
        .WithOpenApi();

        group.MapPost("/", async (Role input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Roles.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateRole")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Roles.Add(std);
                Role[] someRoles = context.Roles.Where(m => m.Id == id).ToArray();
                context.Roles.Attach(someRoles[0]);
                context.Roles.Remove(someRoles[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteRole")
        .WithOpenApi();
    }
}

