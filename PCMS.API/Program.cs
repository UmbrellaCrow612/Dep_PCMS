using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PCMS.API.Auth;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseInMemoryDatabase("AppDb"));

builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    await SeedRolesAndAdminUser(roleManager, userManager);
}

app.MapIdentityApi<IdentityUser>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseSerilogRequestLogging();


try
{
    Log.Information("Starting App");
    app.Run();

}
catch (Exception ex)
{
    Log.Error(ex, "Unhandled exception");
}
finally
{
    await Log.CloseAndFlushAsync();
}

async Task SeedRolesAndAdminUser(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
{
    // Seed Roles
    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

    // Seed Admin User
    var adminUser = new IdentityUser
    {
        UserName = "admin@example.com",
        Email = "admin@example.com",
        EmailConfirmed = true
    };

    if (await userManager.FindByEmailAsync(adminUser.Email) == null)
    {
        await userManager.CreateAsync(adminUser, "AdminPassword123!");
        await userManager.AddToRoleAsync(adminUser, UserRoles.Admin);
    }
}