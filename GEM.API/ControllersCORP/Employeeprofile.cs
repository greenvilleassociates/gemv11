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

public static class EmployeeprofileEndpoints
{

    public static async void MapEmployeeprofileEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Employeeprofile").WithTags(nameof(Employeeprofile));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Employeeprofiles.ToList();
            }

        })
        .WithName("GetAllEmployeeprofiles")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Employeeprofiles.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetEmployeeprofileById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Employeeprofile input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Employeeprofile[] someEmployeeprofile = context.Employeeprofiles.Where(m => m.Id == id).ToArray();
                context.Employeeprofiles.Attach(someEmployeeprofile[0]);
                someEmployeeprofile[0].Employeeid = input.Employeeid;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateEmployeeprofile")
        .WithOpenApi();

        group.MapPost("/", async (Employeeprofile input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Employeeprofiles.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateEmployeeprofile")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Employeeprofiles.Add(std);
                Employeeprofile[] someEmployeeprofiles = context.Employeeprofiles.Where(m => m.Id == id).ToArray();
                context.Employeeprofiles.Attach(someEmployeeprofiles[0]);
                context.Employeeprofiles.Remove(someEmployeeprofiles[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteEmployeeprofile")
        .WithOpenApi();
    }
}

