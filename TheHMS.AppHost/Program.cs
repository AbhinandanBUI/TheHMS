var builder = DistributedApplication.CreateBuilder(args);

//var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.TheHMS_ApiService>("apiservice");
 
var webFrontend = builder.AddProject<Projects.TheHMS_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    ;
 


//builder.AddProject<Projects.TheHMS_Web>("webfrontend")
//    .WithExternalHttpEndpoints()
//    //.WithReference(cache)
//    .WithReference(apiService);

builder.Build().Run();
