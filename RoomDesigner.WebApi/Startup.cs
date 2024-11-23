public void ConfigureServices(IServiceCollection services)
{
    services.AddAuthentication(AzureADB2CDefaults.AuthenticationScheme)
            .AddAzureADB2C(options => Configuration.Bind("AzureAdB2C", options));
    services.AddControllers();
    services.AddApplicationInsightsTelemetry(Configuration["ApplicationInsights:InstrumentationKey"]);
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseHttpsRedirection();
    app.UseRouting();
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
