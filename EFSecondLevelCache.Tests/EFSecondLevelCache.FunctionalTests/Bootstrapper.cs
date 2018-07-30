using System;
using System.Data.Entity;
using EFSecondLevelCachePlus.TestDataLayer.DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFSecondLevelCachePlus.FunctionalTests
{
    [TestClass]
    public class Bootstrapper
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            startDb();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
        }

        private static void startDb()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SampleContext, Configuration>());
            using (var ctx = new SampleContext())
            {
                ctx.Database.Initialize(force: true);
            }
        }
    }
}