﻿namespace Avtotest.Web.Services;

public class CookiesService
{
    public string? GetUserPhoneFromCookie(HttpContext context) 
    {
        if (context.Request.Cookies.ContainsKey("UserPhone")) return context.Request.Cookies["UserPhone"]!;

        return null;

    }
    public void SendUserPhoneToCookie(string userPhone, HttpContext context) // userni phonini eslabqoladi
    {
        var option = new CookieOptions
        {
            Expires = DateTime.Now.AddDays(1)

        };
        
        context.Response.Cookies.Append("UserPhone", userPhone,option);
    }
}
