﻿using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using EntityMigrate.EntityFramework;
using EntityMigrate.EntityFramework.Migrations;

namespace EntityMigrate.Console
{

    public class Program
    {
        /// <summary>
        /// Runs the migration
        /// </summary>
        /// <remarks>
        /// We can do this, or just run Update-Database in the IDE command line
        /// </remarks>
        /// <param name="args">Console arguments</param>
        static void Main(string[] args)
        {
            
            SetConnectionString(args);

            var databaseInitializer = new MigrateDatabaseToLatestVersion<EntityMigrateDatabaseContext, EntityMigrationConfiguration>();
            var databaseContext = new EntityMigrateDatabaseContext();

            databaseInitializer.InitializeDatabase(databaseContext);
  
        }

        private static void SetConnectionString(IList<string> args)
        {
            var connectionString = string.Format("Server={0};Database={1};Integrated Security=True;", args[0], args[1]);
            var connectionStringSettings = new ConnectionStringSettings("EntityMigrateDatabaseContext", connectionString, "System.Data.SqlClient");

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings.Add(connectionStringSettings);
            config.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
