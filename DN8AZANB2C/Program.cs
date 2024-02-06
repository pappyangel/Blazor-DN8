using DN8AZANB2C.Components;
using Microsoft.Identity.Web.UI;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAdB2C"));

// builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
//                 .AddMicrosoftIdentityWebApp(options =>
//                 {
//                     builder.Configuration.Bind("AzureAdB2C", options);
//                     // TODO - remove this line when token validation issue is fixed.
//                     options.TokenValidationParameters.ValidateIssuer = false;
//                 });

// builder.Services.AddControllersWithViews().AddMicrosoftIdentityUI();
builder.Services.AddControllers().AddMicrosoftIdentityUI();
builder.Services.AddCascadingAuthenticationState();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
