namespace c_sharp_learning
{
    public class Installer
    {
        private readonly Logger _logger;

        // Installer has Logger - Compostion
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        // Install Method
        public void Install()
        {
            _logger.Log("We are installing the application.");
        }

    }
}






















