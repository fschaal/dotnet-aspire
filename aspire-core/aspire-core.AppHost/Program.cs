var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.web_api_backend>("webapi");
builder.AddProject<Projects.blazor_frontend>("frontend").WithReference(api);

builder.Build().Run();