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

public static class GcompanyEndpoints
{

    public static async void MapGcompanyEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gcompany").WithTags(nameof(Gcompany));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gcompanies.ToList();
            }

        })
        .WithName("GetAllGcompanys")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gcompanies.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGcompanyById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gcompany input) =>
        {
            using (var context = new GemContext())
            {
                Gcompany[] someGcompany = context.Gcompanies.Where(m => m.Id == id).ToArray();
                context.Gcompanies.Attach(someGcompany[0]);
                someGcompany[0].Companyname = input.Companyname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGcompany")
        .WithOpenApi();

        group.MapPost("/", async (Gcompany input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gcompanies.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGcompany")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gcompanys.Add(std);
                Gcompany[] someGcompanys = context.Gcompanies.Where(m => m.Id == id).ToArray();
                context.Gcompanies.Attach(someGcompanys[0]);
                context.Gcompanies.Remove(someGcompanys[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGcompany")
        .WithOpenApi();
    }
}

