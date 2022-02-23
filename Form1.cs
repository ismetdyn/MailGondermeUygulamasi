using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5_27MailGondermeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string mailGonder(string aliciMail, string baslik, string mesaj, string ccler,
            string bccler, string ekliDosyaSunucuYolu)
        {
            string
                mailIstamcisi = "smtp.gmail.com",
                gonMail = "ismetdayan1@gmail.com",
                gonMailSifre = "41797296184";

            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(aliciMail);
                if (ccler != null) msg.CC.Add(ccler);
                if (bccler != null) msg.CC.Add(bccler);
                if (ekliDosyaSunucuYolu != null)
                {
                    System.Net.Mail.Attachment data = new System.Net.Mail.Attachment(ekliDosyaSunucuYolu, 
                        System.Net.Mime.MediaTypeNames.Application.Octet);
                    msg.Attachments.Add(data);
                }

                msg.From = new System.Net.Mail.MailAddress(gonMail);
                msg.Subject = baslik;
                msg.IsBodyHtml = true;
                msg.Body = mesaj;

                System.Net.NetworkCredential guvenlikKarti = new System.Net.NetworkCredential(gonMail, 
                    gonMailSifre);
                client.Credentials = guvenlikKarti;
                client.Port = 465;
                client.Host = mailIstamcisi;
                client.EnableSsl = true;
                client.Send(msg);
                client = null;
                msg = null;
                guvenlikKarti = null;
                return "Mailiniz başarılı bir şekilde gönderildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            string sonuc = mailGonder(tbAliciEpostaAdresi.Text, tbKonu.Text, tbMesaj.Text, null, null,
                null);
            MessageBox.Show(sonuc);
        }
    }
}
