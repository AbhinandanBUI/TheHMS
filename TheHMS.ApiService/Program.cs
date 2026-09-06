using TheHMS.IService.IService.Auth;
using TheHMS.IService.IService.Common;
using TheHMS.IService.IService.UserManagement;
using TheHMS.Service.Service.Auth;
using TheHMS.Service.Service.Common;
using TheHMS.Service.Service.UserManagement;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

builder.Services.AddTransient<IDapperAsync, DapperAsync>();
builder.Services.AddTransient<IUserManagement, UserManagement>();
builder.Services.AddTransient<IAuth, Auth>();

// Add services to the container.
builder.Services.AddProblemDetails();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

// Enable Swagger only in development (optional)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

 

app.MapDefaultEndpoints();

app.Run();

 