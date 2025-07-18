using Enterprise.Controllers;
using Enterprise.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Azure;
using Azure.AI.FormRecognizer.DocumentAnalysis;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

//ADD WINDOWS SERVICE LOGIC
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.Configure<HostOptions>(options => options.ShutdownTimeout = TimeSpan.FromSeconds(30));
builder.Services.AddWindowsService(options => options.ServiceName = "GEMCONTOLLER");
using IHost host = builder.Build();


//Add HTTP Client
builder.Services.AddHttpClient();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseAuthorization();
app.MapEmployeeEndpoints();
app.MapBuEndpoints();
app.MapLearndetailEndpoints();
//app.MapGEMEndpoints();
app.MapResdetailEndpoints();
app.MapCertificationEndpoints();
app.MapUserlogEndpoints();
app.MapUserprofileEndpoints();
app.MapUserEndpoints();
app.MapUseractionEndpoints();
app.MapUserhelpEndpoints();
app.MapUsersessionEndpoints();
app.MapControllers();
//app.MapAuthEndpoints();
app.MapBatchEndpoints();
app.MapBatchtypeEndpoints();
app.MapCerttypeEndpoints();
app.MapCertrequirementsEndpoints();
//app.MapCertcatEndpoints();
app.MapManagerEndpoints();
app.MapStoreEndpoints();
app.MapRegionEndpoints();
app.MapCompanyEndpoints();
app.MapActivitydetailsEndpoints();
app.MapSkillsdetailEndpoints();
app.MapCertcomplianceEndpoints();
app.MapLogUserEndpoints();
app.MapProclassesdetailEndpoints();
app.MapCompanyeventsEndpoints();
app.MapUsergroupsEndpoints();
app.MapEmployeeprofileEndpoints();
app.MapRoleEndpoints();
//app.MapFileEndpoints();
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
app.Run();
host.Run();
