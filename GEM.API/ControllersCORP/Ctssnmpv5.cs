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

public static class Ctssnmpv5Endpoints
{

    public static async void MapCtssnmpv5Endpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Ctssnmpv5").WithTags(nameof(Ctssnmpv5));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Ctssnmpv5s.ToList();
            }

        })
        .WithName("GetAllCtssnmpv5s")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Ctssnmpv5s.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetCtssnmpv5ById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Ctssnmpv5 input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Ctssnmpv5[] someCtssnmpv5 = context.Ctssnmpv5s.Where(m => m.Id == id).ToArray();
                context.Ctssnmpv5s.Attach(someCtssnmpv5[0]);
                someCtssnmpv5[0].TrapId = input.TrapId;
                someCtssnmpv5[0].Timestamp = input.Timestamp;
                someCtssnmpv5[0].SourceIp = input.SourceIp;
                someCtssnmpv5[0].CommunityString = input.CommunityString;
                someCtssnmpv5[0].SnmpVersion = input.SnmpVersion;
                someCtssnmpv5[0].EnterpriseOid = input.EnterpriseOid;
                someCtssnmpv5[0].LoopbackSourceIp = input.LoopbackSourceIp;
                someCtssnmpv5[0].User1 = input.User1;
                someCtssnmpv5[0].User2 = input.User2;
                someCtssnmpv5[0].User3 = input.User3;
                someCtssnmpv5[0].User4 = input.User4;
                someCtssnmpv5[0].User5 = input.User5;
                someCtssnmpv5[0].Vpnid = input.Vpnid;
                someCtssnmpv5[0].GenericTrapType = input.GenericTrapType;
                someCtssnmpv5[0].Lat = input.Lat;
                someCtssnmpv5[0].Long = input.Long;
                someCtssnmpv5[0].Ctsfulllocation = input.Ctsfulllocation;
                someCtssnmpv5[0].AgentAddress = input.AgentAddress;
                someCtssnmpv5[0].SpecificTrapCode = input.SpecificTrapCode;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateCtssnmpv5")
        .WithOpenApi();

        group.MapPost("/", async (Ctssnmpv5 input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Ctssnmpv5s.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateCtssnmpv5")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Ctssnmpv5s.Add(std);
                Ctssnmpv5[] someCtssnmpv5s = context.Ctssnmpv5s.Where(m => m.Id == id).ToArray();
                context.Ctssnmpv5s.Attach(someCtssnmpv5s[0]);
                context.Ctssnmpv5s.Remove(someCtssnmpv5s[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteCtssnmpv5")
        .WithOpenApi();
    }
}

