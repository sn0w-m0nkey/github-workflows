using System.Web;
using Microsoft.AspNetCore.Identity;
using Web.Data;

namespace Web.Services;

public class EmailSender(IMailService mailService) : IEmailSender<ApplicationUser>
{
    public IMailService MailService { get; } = mailService;
    
    public async Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
    {
        var link = HttpUtility.HtmlDecode(confirmationLink);

        var message = $@"
            <h1>Email Confirmation</h1>
            <p>Dear {user.UserName},</p>
            <p>Thank you for registering with us. Please confirm your email by clicking on the link below.</p>
            <a href=""{link}"">Confirm Email</a>
            <p>Thank you!</p>";

        await MailService.SendEmailAsync(email, "Email Confirmation", message);
    }

    public async Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
    {
        var link = HttpUtility.HtmlDecode(resetLink);
        
        var message = $@"
            <h1>Password Reset</h1>
            <p>Dear {user.UserName},</p>
            <p>We received a request to reset your password. Please click on the link below to reset your password.</p>
            <a href=""{link}"">Reset Password</a>
            <p>Thank you!</p>";
        
        await MailService.SendEmailAsync(email, "Password Reset Link", message);
    }

    public async Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
    {
        var code = HttpUtility.HtmlDecode(resetCode);
        
        var message = $@"
            <h1>Password Reset</h1>
            <p>Dear {user.UserName},</p>
            <p>We received a request to reset your password. Please use the following code to reset your password.</p>
            <p><strong>{code}</strong></p>
            <p>Thank you!</p>";
        
        await MailService.SendEmailAsync(email, "Password Reset Code", message);
    }
}