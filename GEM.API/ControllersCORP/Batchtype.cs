﻿using System;
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

public static class BatchtypeEndpoints
{

    public static async void MapBatchtypeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Batchtype").WithTags(nameof(Batchtype));

        //[HttpGet]
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Batchtypes.ToList();
            }

        })
        .WithName("GetAllBatchtypes")
        .WithOpenApi();

        //[HttpGet]
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                return context.Batchtypes.Where(m => m.Id == id).ToList();
            }
        })
        .WithName("GetBatchtypeById")
        .WithOpenApi();

        //[HttpPut]
        group.MapPut("/{id}", (int id, Batchtype input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Batchtype[] someBatchtype = context.Batchtypes.Where(m => m.Id == id).ToArray();
                context.Batchtypes.Attach(someBatchtype[0]);
                someBatchtype[0].Batchtypename = input.Batchtypename;
                context.SaveChanges();
                return TypedResults.Accepted("Updated ID:" + input.Id);
            }


        })
        .WithName("UpdateBatchtype")
        .WithOpenApi();

        group.MapPost("/", async (Batchtype input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                //input.Id = dice;
                context.Batchtypes.Add(input);
                await context.SaveChangesAsync();
                return TypedResults.Created("Created ID:" + input.Id);
            }

        })
        .WithName("CreateBatchtype")
        .WithOpenApi();

        group.MapDelete("/{id}", async (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                //context.Batchtypes.Add(std);
                Batchtype[] someBatchtypes = context.Batchtypes.Where(m => m.Id == id).ToArray();
                context.Batchtypes.Attach(someBatchtypes[0]);
                context.Batchtypes.Remove(someBatchtypes[0]);
                context.SaveChanges();
            }

        })
        .WithName("DeleteBatchtype")
        .WithOpenApi();
    }
}

