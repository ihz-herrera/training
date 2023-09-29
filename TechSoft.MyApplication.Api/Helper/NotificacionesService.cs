using TechSoft.MyApplication.Api.Helper.Providers;

namespace TechSoft.MyApplication.Api.Helper
{
    public class NotificacionesService
    {
        //private readonly ILogger _logger;
        private readonly INotifyProvider _provider;
        public NotificacionesService(//ILogger<NotificacionesService> logger,
            INotifyProvider provider)
        {
            //_logger = logger;  
            _provider = provider;
        }


        public void Notificacion()
        {
            //throw new NotImplementedException();
            _provider.SendNotification();
            
        }
    }
}
