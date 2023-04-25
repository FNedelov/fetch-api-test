var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddCors(setup =>
//{
//    setup.AddDefaultPolicy(policyBuilder => 
//    {
//        policyBuilder.WithOrigins("https://localhost:7274");
//    });
//});
builder.Services.AddCors(setup =>
{
    setup.AddDefaultPolicy(policyBuilder =>
    {
        policyBuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
// Add services to the container.

builder.Services.AddControllers();
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

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
