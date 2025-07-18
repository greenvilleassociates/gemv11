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

public static class CertcomplianceEndpoints
{

    public static async void MapCertcomplianceEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Certcompliance").WithTags(nameof(Certcompliance));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Certcompliances.ToList();
            }

        })
        .WithName("GetAllCertcompliances")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Certcompliances.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetCertcomplianceById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Certcompliance input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Certcompliance[] someCertcompliance = context.Certcompliances.Where(m => m.Id == id).ToArray();
                context.Certcompliances.Attach(someCertcompliance[0]);
                someCertcompliance[0].Complianceid = input.Complianceid;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateCertcompliance")
        .WithOpenApi();

        group.MapPost("/", async (Certcompliance input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Certcompliances.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateCertcompliance")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Certcompliances.Add(std);
                Certcompliance[] someCertcompliances = context.Certcompliances.Where(m => m.Id == id).ToArray();
                context.Certcompliances.Attach(someCertcompliances[0]);
                context.Certcompliances.Remove(someCertcompliances[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteCertcompliance")
        .WithOpenApi();
    }
}

