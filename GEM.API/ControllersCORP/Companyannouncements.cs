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

public static class CompanyannouncementsEndpoints
{

    public static async void MapCompanyannouncementsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Companyannouncements").WithTags(nameof(Companyannouncements));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Companyannouncements.ToList();
            }

        })
        .WithName("GetAllCompanyannouncements")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Companyannouncements.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetCompanyannouncementsById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Companyannouncements input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Companyannouncement[] someCompanyannouncements = context.Companyannouncements.Where(m => m.Id == id).ToArray();
                context.Companyannouncements.Attach(someCompanyannouncements[0]);
                someCompanyannouncements[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateCompanyannouncements")
        .WithOpenApi();

        group.MapPost("/", async (Companyannouncement input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Companyannouncements.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateCompanyannouncements")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Companyannouncements.Add(std);
                Companyannouncement[] someCompanyannouncements = context.Companyannouncements.Where(m => m.Id == id).ToArray();
                context.Companyannouncements.Attach(someCompanyannouncements[0]);
                context.Companyannouncements.Remove(someCompanyannouncements[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteCompanyannouncements")
        .WithOpenApi();
    }
}

