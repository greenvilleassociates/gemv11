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

public static class CertcatEndpoints
{

    public static async void MapCertcatEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Certcat").WithTags(nameof(Certcat));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Certcats.ToList();
            }

        })
        .WithName("GetAllCertcats")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Certcats.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetCertcatById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Certcat input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Certcat[] someCertcat = context.Certcats.Where(m => m.Id == id).ToArray();
                context.Certcats.Attach(someCertcat[0]);
                someCertcat[0].Certname = input.Certname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateCertcat")
        .WithOpenApi();

        group.MapPost("/", async (Certcat input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Certcats.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateCertcat")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Certcats.Add(std);
                Certcat[] someCertcats = context.Certcats.Where(m => m.Id == id).ToArray();
                context.Certcats.Attach(someCertcats[0]);
                context.Certcats.Remove(someCertcats[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteCertcat")
        .WithOpenApi();
    }
}

