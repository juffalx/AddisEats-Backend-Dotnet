using AddisEats.Api.Services.MenuItemServices;
var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMenuInterfaceService, MenuItemService>();
var freeAboveEtb = builder.Configuration.GetValue<string>("Delivery:FreeAboveEtb");
Console.WriteLine("free above etb");


var app = builder.Build();

// Configure request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();



app.Run();


