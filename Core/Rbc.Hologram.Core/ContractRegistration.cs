using Microsoft.Extensions.DependencyInjection;
using Rbc.Hologram.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Rbc.Hologram.Core
{
    public class ContractRegistration
    {
        public static void RegisterContracts(IServiceCollection container)
        {
            var assemblyNames = Assembly.GetCallingAssembly().GetReferencedAssemblies()
                .Where(a => a.FullName.ToLower().StartsWith("rbc"))
                .ToList();

            var assemblies = new List<Assembly>();
            foreach (var am in assemblyNames)
            {
                assemblies.Add(Assembly.Load(am));
            }

            var types = (
                from t in assemblies.SelectMany(a => a.GetExportedTypes()
                        .Where(c => !c.Name.ToLower().EndsWith("controller"))).ToList()
                from i in assemblies.SelectMany(a => a.GetExportedTypes()
                        .Where(it => it.IsInterface && it.Name.EndsWith("Contract"))).ToList()
                where t.GetInterface(i.Name) != null
                select new { type = t, itype = i }
            ).ToList();

            foreach (var t in types)
            {
                container.AddTransient(t.itype, t.type);
            }

            assemblyNames = Assembly.GetExecutingAssembly().GetReferencedAssemblies()
               .Where(a => a.FullName.ToLower().StartsWith("rbc"))
               .ToList();

            assemblies.Clear();
            foreach (var am in assemblyNames)
            {
                assemblies.Add(Assembly.Load(am));
            }

            types = (
                from t in assemblies.SelectMany(a => a.GetExportedTypes()
                        .Where(c => c.Name.ToLower().EndsWith("context"))).ToList()
                from i in assemblies.SelectMany(a => a.GetExportedTypes()
                        .Where(it => it.IsInterface && it.Name.ToLower().EndsWith("context"))).ToList()
                where t.GetInterface(i.Name) != null
                select new { type = t, itype = i }
            ).ToList();

            foreach (var t in types)
            {
                container.AddTransient(t.itype, t.type);
            }
        }

        public static string ConnectionString
        {
            set
            {
                CelebrityHologramContext.ConnectionString = value;
            }
        }

        public static string JwtTokenKey
        {
            get;set;
        }

        public static void Migrate()
        {
            MigrationContext.Migrate();
        }
    }
}
