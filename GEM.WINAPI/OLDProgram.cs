/*using Enterprise.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;


var builder = WebApplication.CreateBuilder(args);
//var  MyAllowSpecificOrigins = "_MyAllowSubdomainPolicy";
//builder.Logging.ClearProviders();
//builder.Logging.AddConsole();

// Load environment variables from .env file
//Env.Load();

// Disable HTTPS Redirection Middleware (for local dev)
builder.Services.AddHttpsRedirection(options =>
{
    // Disable HTTPS redirection
    options.HttpsPort = null;
});

// Configures CORS to allow all origins, methods, and headers.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Load environment variables from .env file
//Env.Load();

var app = builder.Build();

builder.WebHost.ConfigureKestrel(options =>
{
    options.Listen(System.Net.IPAddress.Any, 5033); // Listen on all IPs at port 5033
    options.Listen(System.Net.IPAddress.Any, 5034); // Listen on all IPs at port 5033
});


// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}
/*builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowSpecificOrigins", policy =>
    {
        policy.WithOrigins("https://*.590team1.info", "http://0.0.0.0:5033") // Domain wildcard handled via regex or specific listing
              .SetIsOriginAllowedToAllowWildcardSubdomains()
              .AllowAnyHeader()
              .AllowAnyMethod();

        policy.SetIsOriginAllowed(origin =>
        {
            return origin.StartsWith("https://") && origin.EndsWith(".590team1.info") ||
                   origin.StartsWith("http://") && origin.EndsWith(".590team1.info") || origin.StartsWith("http://") && origin.EndsWith("0.0.0.0/5034");
        });

        policy.WithExposedHeaders("Authorization");

        policy.SetIsOriginAllowed(ip =>
        {
            return ip.StartsWith("10.") || ip.StartsWith("192.168.") || ip.StartsWith("172."); // Adjust for private ranges
        });
    });
});
    
//app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGaccountEndpoints();
app.MapGappEndpoints();
app.MapGapptypeEndpoints();
app.MapGbranchEndpoints();
app.MapGbregionEndpoints();
app.MapGchangeEndpoints();
app.MapGchannelEndpoints();
app.MapGchanneltypeEndpoints();
app.MapGcircuittypeEndpoints();
app.MapGcompanyEndpoints();
app.MapGcomputerEndpoints();
app.MapGconduitEndpoints();
app.MapGcountryEndpoints();
app.MapGcpeotherEndpoints();
app.MapGcpetypeEndpoints();
app.MapGcustomerEndpoints();
app.MapGdataservicesEndpoints();
app.MapGdiskEndpoints();
app.MapGdisktypeEndpoints();
app.MapGdservicetypeEndpoints();
app.MapGemployeeEndpoints();
app.MapGengineregionEndpoints();
app.MapGfirewallEndpoints();
app.MapGgatewayEndpoints();
app.MapGgridEndpoints();
app.MapGgridnodeEndpoints();
app.MapGgridtopologyEndpoints();
app.MapGhdvideoEndpoints();
app.MapGhostEndpoints();
app.MapGhostimageEndpoints();
app.MapGhregionEndpoints();
app.MapGhostlparEndpoints();
app.MapGhostvmEndpoints();
app.MapGinventoryEndpoints();
app.MapGinventorytypeEndpoints();
app.MapGitsmEndpoints();
app.MapGmanagerEndpoints();
app.MapGnetworkEndpoints();
app.MapGnetworktypeEndpoints();
app.MapGopticalringEndpoints();
app.MapGopticalsegmentEndpoints();
app.MapGopttypeEndpoints();
app.MapGphoneEndpoints();
app.MapGphysicalparEndpoints();
app.MapGproductEndpoints();
app.MapGrouterEndpoints();
app.MapGsecvideoEndpoints();
app.MapGserverEndpoints();
app.MapGserviceorderEndpoints();
app.MapGserviceordertypeEndpoints();
app.MapGsiteEndpoints();
app.MapGsitetypeEndpoints();
app.MapGswitchEndpoints();
app.MapGtelephonenumberEndpoints();
app.MapGtrunktypeEndpoints();
app.MapGuserEndpoints();
app.MapGusergroupEndpoints();
app.MapGvendorEndpoints();
app.MapGvoicegatewayEndpoints();
app.MapGvoiceplatformEndpoints();
app.MapGvoiceplatformtypeEndpoints();
app.MapGvoiceserviceEndpoints();
app.MapGvoicetrunkEndpoints();
app.MapGvoicetrunktypeEndpoints();
app.MapGvolumeEndpoints();
app.MapGvpnEndpoints();
app.MapGvpntypeEndpoints();
app.MapGvservicetypeEndpoints();
app.MapGwholesalerEndpoints();
app.MapGworkorderEndpoints();
app.MapHUserEndpoints();
//app.MapWordpressEndpoints(); 
//app.UseCors(MyAllowSpecificOrigins);
//app.UseRouting();
//app.UseCors(x => x
//    .AllowAnyOrigin()
//    .AllowAnyMethod()
//    .AllowAnyHeader()
//    .WithExposedHeaders("X-total-count"));
app.Run();*/
