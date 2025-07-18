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

public static class ActivitydetailsEndpoints
{

    public static async void MapActivitydetailsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Activitydetail").WithTags(nameof(Activitydetail));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Activitydetails.ToList();
            }

        })
        .WithName("GetAllActivitydetails")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Activitydetails.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetActivitydetailsById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Activitydetail input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Activitydetail[] someActivitydetails = context.Activitydetails.Where(m => m.Id == id).ToArray();
                context.Activitydetails.Attach(someActivitydetails[0]);
                someActivitydetails[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateActivitydetails")
        .WithOpenApi();

        group.MapPost("/", async (Activitydetail input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Activitydetails.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateActivitydetail")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Activitydetailsdetails.Add(std);
                Activitydetail[] someActivitydetails = context.Activitydetails.Where(m => m.Id == id).ToArray();
                context.Activitydetails.Attach(someActivitydetails[0]);
                context.Activitydetails.Remove(someActivitydetails[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteActivitydetails")
        .WithOpenApi();
    }
}
