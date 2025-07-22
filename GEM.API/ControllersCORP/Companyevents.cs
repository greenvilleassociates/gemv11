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

public static class CompanyeventsEndpoints
{

    public static async void MapCompanyeventsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Companyevents").WithTags(nameof(Companyevent));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Companyevents.ToList();
            }

        })
        .WithName("GetAllCompanyevents")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Companyevents.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetCompanyeventById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Companyevent input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Companyevent[] someCompanyevents = context.Companyevents.Where(m => m.Id == id).ToArray();
                context.Companyevents.Attach(someCompanyevents[0]);
                someCompanyevents[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateCompanyevents")
        .WithOpenApi();

        group.MapPost("/", async (Companyevent input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Companyevents.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateCompanyevents")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Companyevents.Add(std);
                Companyevent[] someCompanyevents = context.Companyevents.Where(m => m.Id == id).ToArray();
                context.Companyevents.Attach(someCompanyevents[0]);
                context.Companyevents.Remove(someCompanyevents[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteCompanyevents")
        .WithOpenApi();
    }
}

