using PersonelApp.WebAPI.Context;
using PersonelApp.WebAPI.Filters;
using PersonelApp.WebAPI.Repositories;
using PersonelApp.WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddControllers();

builder.Services.AddTransient<ApplicationDbContext>();
builder.Services.AddTransient<IPersonelRepository,PersonelRepository>();
builder.Services.AddTransient<IPersonelService,PersonelService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAuthTokenRepository,AuthTokenRepository>();
builder.Services.AddTransient<IAuthTokenService,AuthTokenService>();

builder.Services.AddExceptionHandler<MyExceptionHandler>().AddProblemDetails();

builder.Services.AddMemoryCache();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

//app.Use(async (context, next) =>
//{
//	try
//	{
//		await next(context);
//	}
//	catch (Exception ex)
//	{
//		context.Response.StatusCode = 500;
//		await context.Response.WriteAsync(ex.Message);

//	}

//});

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(x => x.AllowAnyOrigin());
app.MapControllers();

app.UseExceptionHandler();

app.Run();
