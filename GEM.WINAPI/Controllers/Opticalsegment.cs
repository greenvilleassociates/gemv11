using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using GEMAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http;
namespace Enterprise.Controllers;

public static class GopticalsegmentEndpoints
{

    public static async void MapGopticalsegmentEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gopticalsegment").WithTags(nameof(Gopticalsegment));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemContext())
            {
                return context.Gopticalsegments.ToList();
            }

        })
        .WithName("GetAllGopticalsegments")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemContext())
            {
                return context.Gopticalsegments.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetGopticalsegmentById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Gopticalsegment input) =>
        {
            using (var context = new GemContext())
            {
                Gopticalsegment[] someGopticalsegment = context.Gopticalsegments.Where(m => m.Id == id).ToArray();
                context.Gopticalsegments.Attach(someGopticalsegment[0]);
                someGopticalsegment[0].Description = input.Description;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateGopticalsegment")
        .WithOpenApi();

        group.MapPost("/", async (Gopticalsegment input) =>
        {
            using (var context = new GemContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Gopticalsegments.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateGopticalsegment")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemContext())
            {
                //context.Gopticalsegments.Add(std);
                Gopticalsegment[] someGopticalsegments = context.Gopticalsegments.Where(m => m.Id == id).ToArray();
                context.Gopticalsegments.Attach(someGopticalsegments[0]);
                context.Gopticalsegments.Remove(someGopticalsegments[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteGopticalsegment")
        .WithOpenApi();
    }
}

