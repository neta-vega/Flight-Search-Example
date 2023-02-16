using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace lastMinuteTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/api/flight/search", async context =>
                {
                    string jsonString = File.ReadAllText("Raw_data RT - 2pax .JSON");
                    //string jsonString = File.ReadAllText("Raw_data OW - 2pax .JSON");
                    //string jsonString = File.ReadAllText("Raw_data OW.JSON");
                    Flight[] flights = JsonSerializer.Deserialize<Flight[]>(jsonString);
                    ClientData[] clientData = utils.CopyFlightToClientData(flights);
                    await context.Response.WriteAsJsonAsync(clientData);
                });
            });
        }



    }
}

