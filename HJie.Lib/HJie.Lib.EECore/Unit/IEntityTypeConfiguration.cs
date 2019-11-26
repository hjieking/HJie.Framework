using HJie.Lib.EECore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HJie.Lib.EECore.Unit
{
    public interface IEntityTypeConfiguration
    {
    }
    public class AspNetUserConfig : IEntityTypeConfiguration
    {
        public AspNetUserConfig(ModelBuilder builder)
        {
            builder.Entity<AspNetUser>().ToTable("AspNetUser");
        }
    }
    public static class ModelBuilderExtensions
    {
        public static void ExecuteConfigurations(this ModelBuilder modelBuilder, string assemblyName)
        {
            var configurationTypes = Assembly.Load(new AssemblyName(assemblyName)).GetTypes()
                .Where(type => !string.IsNullOrWhiteSpace(type.Namespace))
                .Where(type => type.GetTypeInfo().IsClass)
                .Where(type => type.GetTypeInfo().BaseType != null)
                .Where(type => typeof(IEntityTypeConfiguration).IsAssignableFrom(type))
                .ToList();

            foreach (var type in configurationTypes)
                Activator.CreateInstance(type, modelBuilder);
        }
    }
}
