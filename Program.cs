using KycAgentPlatform.Agents;
using KycAgentPlatform.Tools;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IdentityTool>();
builder.Services.AddSingleton<RiskTool>();

builder.Services.AddSingleton<IdentityAgent>();
builder.Services.AddSingleton<RiskAgent>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();
