namespace TechSoft.MyApplication.Api.Helper.Providers
{
    public class MailNotifyProvider:INotifyProvider
    {
        public void SendNotification()
        {
            Console.WriteLine("Notificacion enviada por mail");
        }
    }
}
