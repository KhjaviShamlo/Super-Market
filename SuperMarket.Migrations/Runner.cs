using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.Migrations
{
   class Runner
    {
        static void Main(string[] args)
        {
            var options = GetCommandLineArgs(args);

            var connectionString = options.GetValue("connection-string", defaultValue: "Data Source=data.db");

            CreateDatabase(connectionString);

            var runner = CreateRunner(connectionString);

            runner.MigrateUp();
        }

        private static object CreateRunner(object connectionString)
        {
            throw new NotImplementedException();
        }

        private static void CreateDatabase(object connectionString)
        {
            throw new NotImplementedException();
        }

        private static object GetCommandLineArgs(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
