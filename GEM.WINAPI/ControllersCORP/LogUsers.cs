using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using Enterprise.Models;
using System.Text.Json;
using GEMAPI.ModelsCORP;

namespace Enterprise.Controllers;

public static class LogUserEndpoints
{
    public static async void MapLogUserEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/LogUsers").WithTags(nameof(User));

        //[HttpGet] Get All Users
        group.MapGet("/", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                var users = context.Users.ToList();

                // Log the API call into Apilog
                var apiLog = new Apilog
                {
	                Descr = "Fetching all users",
                    Logdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                    Apiurl = "/api/Useraction",
                    Apirequestdetail = "Request for all users",
                };

                context.Apilogs.Add(apiLog);
                context.SaveChanges();

                return users;
            }
        })
        .WithName("LogGetAllUsers")
        .WithOpenApi();

        //[HttpGet] Get User by ID
        group.MapGet("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                var user = context.Users.Where(m => m.Id == id).ToList();

                var apiLog = new Apilog
                {
                    Descr = $"Fetching user with ID {id}",
                    Logdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                    Apiurl = $"/api/Useraction",
                    Apirequestdetail = $"Requested User ID: {id}",
                };

                context.Apilogs.Add(apiLog);
                context.SaveChanges();

                return user;
            }
        })
        .WithName("LogGetUserById")
        .WithOpenApi();

        //[HttpPut] Update User
        group.MapPut("/{userid}", (int userid, User input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                User[] someUser = context.Users.Where(m => m.Userid == userid).ToArray();
                context.Users.Attach(someUser[0]);
                someUser[0].Lastname = input.Lastname;
                someUser[0].Firstname = input.Firstname;
                someUser[0].Username = input.Username;
                someUser[0].Email = input.Email;
                someUser[0].Employee = input.Employee;
                someUser[0].Employeeid = input.Employeeid;
                someUser[0].Microsoftid = input.Microsoftid;
                someUser[0].Ncrid = input.Ncrid;
                someUser[0].Oracleid = input.Oracleid;
                someUser[0].Azureid = input.Azureid;
                someUser[0].Plainpassword = input.Plainpassword;
                someUser[0].Hashedpassword = input.Hashedpassword;
                someUser[0].Passwordtype = input.Passwordtype;
                someUser[0].Jid = input.Jid;
                someUser[0].Profileurl = input.Profileurl;
                someUser[0].Role = input.Role;
                someUser[0].Fullname = input.Fullname;
                someUser[0].Resettoken = input.Resettoken;
                someUser[0].Resettokenexpiration = input.Resettokenexpiration;
                someUser[0].Userid = input.Userid;
                context.SaveChanges();

                var apiLog = new Apilog
                {
                    Descr = $"Updated user with ID {userid}",
                    Logdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                    Apiurl = $"/api/Useraction/",
                    Apirequestdetail = JsonSerializer.Serialize(input),
                };

                context.Apilogs.Add(apiLog);
                context.SaveChanges();

                return TypedResults.Accepted($"Updated ID: {input.Id}");
            }
        })
        .WithName("LogUpdateUser")
        .WithOpenApi();

        //[HttpPost] Create User
        group.MapPost("/", async (User input) =>
        {
            using (var context = new Gemcorp2Context())
            {
                Random rnd = new Random();
                int dice = rnd.Next(1000, 10000000);
                input.Id = dice;
                context.Users.Add(input);
                await context.SaveChangesAsync();

                var apiLog = new Apilog
                {
                    Descr = "Created new user",
                    Logdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                    Apiurl = "/api/Useraction",
                    Apirequestdetail = JsonSerializer.Serialize(input),
                };

                context.Apilogs.Add(apiLog);
                await context.SaveChangesAsync();

                return TypedResults.Created($"Created ID: {input.Id}");
            }
        })
        .WithName("LogCreateUser")
        .WithOpenApi();

        //[HttpDelete] Delete User
        group.MapDelete("/{id}", (int id) =>
        {
            using (var context = new Gemcorp2Context())
            {
                User[] someUsers = context.Users.Where(m => m.Id == id).ToArray();
                context.Users.Attach(someUsers[0]);
                context.Users.Remove(someUsers[0]);
                context.SaveChanges();

                var apiLog = new Apilog
                {
                    Descr = $"Deleted user with ID {id}",
                    Logdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                    Apiurl = $"/api/Useraction",
                    Apirequestdetail = $"Deleted User ID: {id}",
                };

                context.Apilogs.Add(apiLog);
                context.SaveChanges();
            }
        })
        .WithName("LogDeleteUser")
        .WithOpenApi();

        //[HttpGet] User Join API
        group.MapGet("/userjoin", () =>
        {
            using (var context = new Gemcorp2Context())
            {
                var result = context.Users
                    .Join(
                        context.Userprofiles,
                        user => user.Id,
                        profile => profile.Userid,
                        (user, profile) => new
                        {
                            UserId = user.Id,
                            Username = user.Username,
                            Fullname = user.Fullname,
                            Email = user.Email,
                            Role = user.Role,
                            ProfileUrl = user.Profileurl,
                            Address1 = profile.Address1,
                            City = profile.City,
                            StateRegion = profile.Stateregion,
                            Country = profile.Country,
                            Phone = profile.Phone,
                            LinkedinUrl = profile.Linkedinurl
                        }
                    )
                    .ToList();

                var apiLog = new Apilog
                {
                    Descr = "User join query executed",
                    Logdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                    Apiurl = "/api/Useraction",
                    Apirequestdetail = "Merged User-Profile data",
                };

                context.Apilogs.Add(apiLog);
                context.SaveChanges();

                return result;
            }
        })
        .WithName("LogGetUserJoin")
        .WithOpenApi();
    }
}
