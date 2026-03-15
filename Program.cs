using KycAgentPlatform.Agents;
using KycAgentPlatform.Services;
using KycAgentPlatform.Tools;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IdentityTool>();
builder.Services.AddSingleton<RiskTool>();

builder.Services.AddSingleton<IdentityAgent>();
builder.Services.AddSingleton<RiskAgent>();
builder.Services.AddSingleton<FraudAgent>();

builder.Services.AddSingleton<OcrService>();
builder.Services.AddSingleton<FraudService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();
