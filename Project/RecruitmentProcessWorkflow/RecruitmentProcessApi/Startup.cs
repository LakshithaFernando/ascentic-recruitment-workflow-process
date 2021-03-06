﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecruitmentProcessApi.Exceptions;
using RecruitmentProcessApi.Models;
using RecruitmentProcessApi.Repository;
using RecruitmentProcessApi.Repository.Interfaces;
using System.Net;

namespace RecruitmentProcessApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.
            services.AddMvc();

            // Registering RecruitmentContext using DI
            services.AddDbContext<RecruitmentContext>(options => options.UseSqlServer(Configuration
                                                                            .GetConnectionString("RecruitmentContext")));
            services.AddScoped<IworkflowRepository, WorkflowRepository>();
            services.AddScoped<IrecruitmentRepository, RecruitmentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
        }
    }
}
