using System;
using System.Collections.Generic;
using System.Text;
using Gestion_Convention_stage.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using System.Linq;
using MailKit;
using MimeKit;
using MailKit.Net.Smtp;

namespace Gestion_Convention_stage.Utils
{

  public class Mail
  {



public static void sendMail(string name , string email, string subject , string msg){
  var message = new MimeMessage ();
message.From.Add (new MailboxAddress ("Ensa Convention De Stage", "kadas2003@gmail.com"));
message.To.Add (new MailboxAddress (name,email));
message.Subject = subject;

message.Body = new TextPart ("plain") {
    Text = msg};

    using(var Client = new SmtpClient()){
      Client.Connect("smtp.gmail.com",587,false);
      Client.Authenticate("kadas2003@gmail.com","kadasabdo123159147");
      Client.Send(message);
      Client.Disconnect(true);
    };
}

}}