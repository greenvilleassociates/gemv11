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

public static class ProclassesdetailEndpoints
{

    public static async void MapProclassesdetailEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Proclassesdetail").WithTags(nameof(Proclassesdetail));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Proclassesdetails.ToList();
            }

        })
        .WithName("GetAllProclassesdetails")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Proclassesdetails.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetProclassesdetailById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Proclassesdetail input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Proclassesdetail[] someProclassesdetail = context.Proclassesdetails.Where(m => m.Id == id).ToArray();
                context.Proclassesdetails.Attach(someProclassesdetail[0]);
                someProclassesdetail[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateProclassesdetail")
        .WithOpenApi();

        group.MapPost("/", async (Proclassesdetail input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Proclassesdetails.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateProclassesdetail")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Proclassesdetails.Add(std);
                Proclassesdetail[] someProclassesdetails = context.Proclassesdetails.Where(m => m.Id == id).ToArray();
                context.Proclassesdetails.Attach(someProclassesdetails[0]);
                context.Proclassesdetails.Remove(someProclassesdetails[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteProclassesdetail")
        .WithOpenApi();
    }
}


