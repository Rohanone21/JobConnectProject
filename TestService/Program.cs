using Microsoft.EntityFrameworkCore;
using TestService.Data;

var builder = WebApplication.CreateBuilder(args);

/* ==========================
 * SERVICES
 * ========================== */

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* ==========================
 * DATABASE
 * ========================== */
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("constr")
    )
);

/* ==========================
 * CORS (React)
 * ========================== */
builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactCorsPolicy", policy =>
    {
        policy
            .WithOrigins(
                "http://localhost:3000", // CRA
                "http://localhost:5173"  // Vite
            )
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

var app = builder.Build();

/* ==========================
 * MIDDLEWARE PIPELINE
 * ========================== */
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

/* ?? CORS MUST BE HERE */
app.UseCors("ReactCorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
