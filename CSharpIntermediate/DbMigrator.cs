using System;

namespace CSharpIntermediate
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo(string.Format("Migration started at {0}", DateTime.Now));
            _logger.LogInfo(string.Format("Migration finished at {0}", DateTime.Now));
        }
    }
}