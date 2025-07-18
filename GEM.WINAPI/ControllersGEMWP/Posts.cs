using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using GEMWP.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http;
namespace Enterprise.Controllers;

public static class WpPostEndpoints
{

    public static async void MapWpPostEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/WpPost").WithTags(nameof(WpPost));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new GemwpContext())
            {
                return context.WpPosts.ToList();
            }

        })
        .WithName("GetAllWpPosts")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new GemwpContext())
            {
                return context.WpPosts.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetWpPostById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", async (int id, WpPost input) =>
        {
            using (var context = new GemwpContext())
            {
                WpPost[] someWpPost = context.WpPosts.Where(m => m.Id == id).ToArray();
                context.WpPosts.Attach(someWpPost[0]);
                someWpPost[0].PostTitle = input.PostTitle;
                someWpPost[0].PostTitle = input.PostContent;
                await context.SaveChangesAsync();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateWpPost")
        .WithOpenApi();

        group.MapPost("/", async (WpPost input) =>
        {
            using (var context = new GemwpContext())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.WpPosts.Add(input);
                context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateWpPost")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new GemwpContext())
            {
                //context.WpPosts.Add(std);
                WpPost[] someWpPosts = context.WpPosts.Where(m => m.Id == id).ToArray();
                context.WpPosts.Attach(someWpPosts[0]);
                context.WpPosts.Remove(someWpPosts[0]);
                context.SaveChangesAsync();
            }

        })
        .WithName("DeleteWpPost")
        .WithOpenApi();
    }
}

