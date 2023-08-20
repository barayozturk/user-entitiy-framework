using WebApplicationTest.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

//builder.Services.AddCors(options => {
//    options.AddPolicy(name: MyAllowSpecificOrigins, policy => { policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod(); });
//});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("http://localhost",
                "http://localhost:4200",
                "https://localhost:7230",
                "http://localhost:5162")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowAnyOrigin()
            .SetIsOriginAllowedToAllowWildcardSubdomains();
        });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAppRepository, AppRepository>();//apprepository implement,addtransit=> her kullanıcı için 1 tane , add singlty=> tek apprepo kullanır, benimki=>user başına



var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();
//app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();
