using System.Diagnostics;

var builder = DistributedApplication.CreateBuilder(args);

//var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.TheHMS_ApiService>("apiservice");

var process = new Process
{
    StartInfo = new ProcessStartInfo
    {
        FileName = "cmd.exe",
        Arguments = "/c npm start", // or ng serve
        WorkingDirectory = @"D:\Client\TheHMS\TheHMS.Web\",
        UseShellExecute = false
    }
};

process.Start();

var webFrontend = builder.AddProject<Projects.TheHMS_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);


//builder.AddProject<Projects.TheHMS_Web>("webfrontend")
//    .WithExternalHttpEndpoints()
//    //.WithReference(cache)
//    .WithReference(apiService);

builder.Build().Run();
