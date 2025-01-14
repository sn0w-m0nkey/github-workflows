namespace Web.Configuration;

public class GmailConfig
{
    public const string SectionName = "GmailConfig";
    
    public string Server { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string FromName { get; set; }
    public string FromEmail { get; set; }
}
