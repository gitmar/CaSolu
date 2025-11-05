function async SendEmail()
{
    await fetch("https://api.mysite.com/api/invite/send", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
            to: "someone@example.com",
            subject: "SmartVendor Invitation",
            message: "Hello! You’ve been invited to join SmartVendor. Click below to register.",
            inviteLink: generatedLink,
            qrBase64: qrImageBase64, // from your Blazor QR generation
            logoUrl: "https://mysite.com/images/logo.png" // or base64 if needed
        })
    });
}
