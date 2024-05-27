namespace Estudo.AutoFac.Services;

public class NotificationSender
{
    public IMobileService? _mobileService = null;
    public IMailService? _mailService = null;

    public NotificationSender(IMobileService mobileService)
    {
        _mobileService = mobileService;
    }

    public IMailService SetMailService
    {
        set { _mailService = value; }
    }

    void SendNotification()
    {
        _mobileService.Execute();
        _mailService.Execute();
    }
}
