/*using Azure.Storage.Blobs;
using FileOps;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Amqp.Framing;
using static System.Net.WebRequestMethods;
namespace Enterprise.Controllers;

using GEMAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;


[Route("api/[controller]")]
[ApiController]
public class FileController : ControllerBase
{
    private readonly BlobServiceClient _blobServiceClient;
    private readonly string _containerName = "uploads";

    public FileController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("AzureBlobStorage");
        _blobServiceClient = new BlobServiceClient(connectionString);
    }

    [HttpPost("upload")]
    // Optional parameter for file category to change blob storage path depending on file category
    // Optional parameter for employeeId to add metadata to the blob when uploading certs
    public async Task<Dictionary<string, string>> UploadFile(IFormFile file, string? fileCategory = null)
    {
        var response = new Dictionary<string, string>();

        if (file == null || file.Length == 0)
        {
            response["message"] = "No file uploaded.";
            return response;
        }

        var containerName = string.IsNullOrEmpty(fileCategory) ? _containerName : fileCategory;
        var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync();

        var blobClient = containerClient.GetBlobClient(file.FileName);

        using (var stream = file.OpenReadStream())
        {
            await blobClient.UploadAsync(stream, true);
        }

        var blobUrl = blobClient.Uri.ToString();
        response["message"] = "File uploaded successfully";
        response["fileName"] = file.FileName;
        response["blobUrl"] = blobUrl;

        return response;
    }
}

[Route("[controller]")]
[ApiController]
public class ProfileController : ControllerBase
{
    private readonly BlobServiceClient _blobServiceClient;
    private readonly string _containerName = "projectimages";

    public ProfileController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("AzureBlobStorage");
        _blobServiceClient = new BlobServiceClient(connectionString);
    }
  

    [HttpPost("upload")]
    // Optional parameter for file category to change blob storage path depending on file category
    // Optional parameter for employeeId to add metadata to the blob when uploading certs
    public async Task<Dictionary<string, string>> UploadFile(IFormFile file, string? fileCategory = null)
    {
        var response = new Dictionary<string, string>();

        if (file == null || file.Length == 0)
        {
            response["message"] = "No file uploaded.";
            return response;
        }

        var containerName = string.IsNullOrEmpty(fileCategory) ? _containerName : fileCategory;
        var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync();

        var blobClient = containerClient.GetBlobClient(file.FileName);

        using (var stream = file.OpenReadStream())
        {
            await blobClient.UploadAsync(stream, true);
        }

        var blobUrl = blobClient.Uri.ToString();
        response["message"] = "File uploaded successfully";
        response["fileName"] = file.FileName;
        response["blobUrl"] = blobUrl;

        return response;
    }
    
    [HttpPost("uploadWithId")]
    public async Task<ActionResult<Dictionary<string, string>>> UploadFileWithId(IFormFile file, int id)
    {
        var response = new Dictionary<string, string>();
        string fileCategory = "";
        if (file == null || file.Length == 0)
        {
            response["message"] = "No file uploaded.";
            return BadRequest(response);
        }

        // Determine the container name
        var containerName = string.IsNullOrEmpty(fileCategory) ? _containerName : fileCategory;
        var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync();

        // Upload the file to Blob Storage
        var blobClient = containerClient.GetBlobClient(file.FileName);

        using (var stream = file.OpenReadStream())
        {
            await blobClient.UploadAsync(stream, true);
        }

        // Generate file name and prepare the response
        var blobUrl = blobClient.Uri.ToString();
        response["message"] = "File uploaded successfully";
        response["fileName"] = file.FileName;
        response["blobUrl"] = blobUrl;

        //FIRST UPDATE THE USERPROFILE TABLE WITH THE NEW URL
        using (var context = new Gemcorp2Context())
        {
            var stringurl = blobUrl;
            Userprofile[] someUserprofile = context.Userprofiles.Where(m => m.Id == id).ToArray();
            context.Userprofiles.Attach(someUserprofile[0]);
            someUserprofile[0].Activepictureurl = stringurl;
            context.SaveChanges();
        }
        //SECOND UPDATE THE USER TABLE WITH THE NEW URL
        using (var context = new Gemcorp2Context())
        {
            var stringurl2 = blobUrl;
            User[] someUser = context.Users.Where(m => m.Id == id).ToArray();
            someUser[0].Profileurl = stringurl2;
            context.SaveChanges();
        }

        response["userProfileUpdateMessage"] = "Change successful. Both User, and UserProfile updated.";
        return Ok(response);
    }
}*/