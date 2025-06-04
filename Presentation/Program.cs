using Microsoft.EntityFrameworkCore;
using Presentation.Data;
using Presentation.Repositories;
using Presentation.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
builder.Services.AddScoped<ContactInfoService>();

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddHttpClient("Profile", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["Services:AccountProfileServiceUrl"]!);
});
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProfileDb")));



var app = builder.Build();
app.MapOpenApi();
app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());


app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
