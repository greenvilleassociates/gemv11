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

public static class SkillsEndpoints
{

    public static async void MapSkillsdetailEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Skills").WithTags(nameof(Skillsdetail));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Skillsdetails.ToList();
            }

        })
        .WithName("GetAllSkillsdetails")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Skillsdetails.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetSkillsdetailById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Skillsdetail input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Skillsdetail[] someSkillsdetail = context.Skillsdetails.Where(m => m.Id == id).ToArray();
                context.Skillsdetails.Attach(someSkillsdetail[0]);
                someSkillsdetail[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateSkillsdetail")
        .WithOpenApi();

        group.MapPost("/", async (Skillsdetail input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Skillsdetails.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateSkillsdetail")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Skillsdetails.Add(std);
                Skillsdetail[] someSkillsdetails = context.Skillsdetails.Where(m => m.Id == id).ToArray();
                context.Skillsdetails.Attach(someSkillsdetails[0]);
                context.Skillsdetails.Remove(someSkillsdetails[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteSkillsdetail")
        .WithOpenApi();
    }
}

