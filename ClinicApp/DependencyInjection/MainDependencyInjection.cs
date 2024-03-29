﻿using ClinicApp.Commands.CreateRequest;
using ClinicApp.Dtos.Validation;
using ClinicApp.Entities;
using ClinicApp.Repositories;
using ClinicApp.Repositories.Interfaces;
using ClinicApp.Services.LogoutService;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace ClinicApp.DependencyInjection
{
    public static class MainDependencyInjection
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public static IHostBuilder CreateHostBuilder()
        {

            return Host
                .CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddFormsToDependencyInjection();
                    services.AddSeedersDependencyInjection();
                    services.AddDbContext<ClinicDbContext>(options => options.UseSqlServer(_connectionString));
                    services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
                    services.AddScoped<IUserRepository, UserRepository>();
                    services.AddScoped<IDayOffTypeRepository, DayOffTypeRepository>();
                    services.AddScoped<IRequestRepository, RequestRepository>();
                    services.AddScoped<IScheduleRepository, ScheduleRepository>();
                    services.AddScoped<IRequestStateRepository, RequestStateRepository>();
                    services.AddScoped<IResponseRepository, ResponseRepository>();
                    services.AddScoped<IDayOffRepository, DayOffRepository>();
                    services.AddScoped<ISubstitutionRepository, SubstitutionRepository>();
                    services.AddScoped(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
                    services.AddMediatR(typeof(Program));
                    services.AddScoped<IValidator<CreateRequestCommand>, CreateRequestCommandValidator>();
                    services.AddScoped<ILogoutService, LogoutService>();
                });
        }
    }
}
