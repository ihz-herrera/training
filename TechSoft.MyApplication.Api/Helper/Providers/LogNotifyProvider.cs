namespace TechSoft.MyApplication.Api.Helper.Providers
{
    public class LogNotifyProvider
    {
        private readonly ILogger _logger;

        public LogNotifyProvider(ILogger<LogNotifyProvider> logger)
        {
            _logger = logger;
        }   


        public void SendNotification()
        {
            _logger.LogInformation("Notificacion enviada");
        }
    }
}
