var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSpaStaticFiles(config => {
  config.RootPath = "/dist";
});

var app = builder.Build();

app.UseSpaStaticFiles();
app.UseSpa(spa => {
  spa.Options.SourcePath = "";
  if (app.Environment.IsDevelopment())
  {
    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
  }
});

app.Run();
