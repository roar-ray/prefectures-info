using PrefecturesInfo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/prefectures/{id}", (int id) => PrefectureDB.GetPrefecture(id));
app.MapGet("/prefectures", () => PrefectureDB.GetPrefectures());
app.MapPost("/prefectures", (Prefecture prefecture) => PrefectureDB.CreatePrefecture(prefecture));
app.MapPut("/prefectures", (Prefecture prefecture) => PrefectureDB.UpdatePrefecture(prefecture));
app.MapDelete("/prefectures/{id}", (int id) => PrefectureDB.RemovePrefecture(id));

app.Run();
