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
using static System.Runtime.InteropServices.JavaScript.JSType;
using GEMAPI.ModelsCORP;
namespace Enterprise.Controllers;

public static class UsersessionEndpoints
{

    public static async void MapUsersessionEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Usersession").WithTags(nameof(Usersession));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Usersessions.ToList();
            }

        })
        .WithName("GetAllUsersessions")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Usersessions.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetUsersessionById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Usersession input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Usersession[] someUsersession = context.Usersessions.Where(m => m.Id == id).ToArray();
                context.Usersessions.Attach(someUsersession[0]);
                someUsersession[0].Sessiondescription = input.Sessiondescription;
                someUsersession[0].Token = input.Token;
                someUsersession[0].Sessionusername = input.Sessionusername;
                someUsersession[0].Sessionemail = input.Sessionemail;
                someUsersession[0].Sessionfirstname = input.Sessionfirstname;
                someUsersession[0].Sessionlastname = input.Sessionlastname;
                someUsersession[0].Sessionfullname = input.Sessionfullname;
                someUsersession[0].Sessionstart = input.Sessionstart;
                someUsersession[0].Sessionend = input.Sessionend;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateUsersession")
        .WithOpenApi();

        group.MapPost("/", async (Usersession input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                DateTime utcNow = DateTime.UtcNow;
                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, easternZone);
                //Console.WriteLine("Current time in EST: " + easternTime);
                input.Sessionstart = DateOnly.FromDateTime(easternTime);
                DateTime specifiedTime = new DateTime(2000, 1, 1, 1, 1, 1, DateTimeKind.Utc);
                TimeZoneInfo easternZone2 = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                DateTime easternTime2 = TimeZoneInfo.ConvertTimeFromUtc(specifiedTime, easternZone2);
                input.Sessionend = DateOnly.FromDateTime(easternTime2);
                context.Usersessions.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateUsersession")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Usersessions.Add(std);
                Usersession[] someUsersessions = context.Usersessions.Where(m => m.Id == id).ToArray();
                context.Usersessions.Attach(someUsersessions[0]);
                context.Usersessions.Remove(someUsersessions[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteUsersession")
        .WithOpenApi();
    }
}

