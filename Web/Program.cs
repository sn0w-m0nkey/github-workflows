using Microsoft.EntityFrameworkCore;
using Web.Components;
using Web.Data;
using Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .RegisterDataComponents(builder.Configuration)
    .ConfigureAuthentication(builder.Configuration)
    .RegisterWebComponents(builder.Configuration);

var app = builder.Build();

// Ensure database and tables exist
// TODO: Make this conditional based on input --RunMigrations
// https://medium.com/geekculture/ways-to-run-entity-framework-migrations-in-asp-net-core-6-37719993ddcb
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    //await context.Database.MigrateAsync();
    //await context.Database.EnsureCreatedAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();