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

public static class EmployeesEndpoints
{

    public static async void MapEmployeeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Employees").WithTags(nameof(Employee));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Employees.ToList();
            }

        })
        .WithName("GetAllEmployeess")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Employees.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetEmployeesById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Employee input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Employee[] someEmployees = context.Employees.Where(m => m.Id == id).ToArray();
                context.Employees.Attach(someEmployees[0]);
                someEmployees[0].Fullname = input.Fullname;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateEmployees")
        .WithOpenApi();

        group.MapPost("/", async (Employee input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Employees.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateEmployees")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Employeess.Add(std);
                Employee[] someEmployeess = context.Employees.Where(m => m.Id == id).ToArray();
                context.Employees.Attach(someEmployeess[0]);
                context.Employees.Remove(someEmployeess[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteEmployees")
        .WithOpenApi();
    }
}

