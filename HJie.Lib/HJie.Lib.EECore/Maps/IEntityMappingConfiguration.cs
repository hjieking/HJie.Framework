using HJie.Lib.EECore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HJie.Lib.EECore.Unit
{
    public interface IEntityMappingConfiguration
    {
        void Map(ModelBuilder b);
    }

    public interface IEntityMappingConfiguration<T> : IEntityMappingConfiguration where T : class
    {
        void Map(EntityTypeBuilder<T> builder);
    }

    public abstract class EntityMappingConfiguration<T> : IEntityMappingConfiguration<T> where T : class
    {
        public abstract void Map(EntityTypeBuilder<T> b);

        public void Map(ModelBuilder b)
        {
            Map(b.Entity<T>());
        }
    }

    public static class ModelBuilderExtenions
    {
        private static IEnumerable<Type> GetMappingTypes(this Assembly assembly, Type mappingInterface)
        {
            return assembly.GetTypes().Where(x => !x.IsAbstract && x.GetInterfaces().Any(y => y.GetTypeInfo().IsGenericType && y.GetGenericTypeDefinition() == mappingInterface));
        }

        public static void AddEntityConfigurationsFromAssembly(this ModelBuilder modelBuilder, Assembly assembly)
        {
            var mappingTypes = assembly.GetMappingTypes(typeof(IEntityMappingConfiguration<>));
            foreach (var config in mappingTypes.Select(Activator.CreateInstance).Cast<IEntityMappingConfiguration>())
            {
                config.Map(modelBuilder);
            }
        }
    }


    //public interface IEntityTypeConfiguration
    //{
    //}

    //public static class ModelBuilderExtensions
    //{
    //    public static void ExecuteConfigurations(this ModelBuilder modelBuilder, string assemblyName)
    //    {
    //        var configurationTypes = Assembly.Load(new AssemblyName(assemblyName)).GetTypes()
    //            .Where(type => !string.IsNullOrWhiteSpace(type.Namespace))
    //            .Where(type => type.GetTypeInfo().IsClass)
    //            .Where(type => type.GetTypeInfo().BaseType != null)
    //            .Where(type => typeof(IEntityTypeConfiguration).IsAssignableFrom(type))
    //            .ToList();

    //        foreach (var type in configurationTypes)
    //            Activator.CreateInstance(type, modelBuilder);
    //    }
    //}
}
