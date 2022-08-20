namespace c_sharp_learning
{
    // Composition
    public class DbMigrator
    {
        private readonly Logger _logger;

        // DbMigrator has Logger 
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("Migrating...");
        }
    }
}






















