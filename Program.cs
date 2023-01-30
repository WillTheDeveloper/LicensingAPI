using LearningThisToday;
using LearningThisToday.DataLayer;
using LearningThisToday.ServiceLayer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency injection
builder.Services.AddSingleton<Context>();
builder.Services.AddScoped<IWhateverService, WhateverService>();
builder.Services.AddScoped<IWhateverData, WhateverData>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapEndpoints();

app.UseHttpsRedirection();

app.Run();
