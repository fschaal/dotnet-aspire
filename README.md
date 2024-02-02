# dotnet-aspire

## update workload
```bash
dotnet workload update
```
## install workload
```bash
dotnet workload install aspire
```

## Add aspire to solution
Add aspire to solution by right clicking on the solution and selecting "Add" -> "New Project" -> "Aspire" -> "Next" -> "Create"

## Add project reference to aspire AppHost
add project reference to aspire AppHost by right clicking on the project and selecting "Add" -> "Reference" -> "Projects" -> "{projects}" -> "OK"

## Add ServiceDefaults project reference to API and Frontend
add project reference to aspire AppHost by right clicking on the project and selecting "Add" -> "Reference" -> "Projects" -> "ServiceDefaults" -> "OK"

## Modify Program.cs in aspire AppHost
```csharp
var api = builder.AddProject<Projects.web_api_backend>("webapi");
builder.AddProject<Projects.blazor_frontend>("frontend").WithReference(api);
```