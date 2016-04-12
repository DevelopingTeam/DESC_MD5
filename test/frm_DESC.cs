using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace test
{
    public partial class frm_DESC : Form
    {
        public frm_DESC()
        {
            InitializeComponent();
        }

        public string EncryptDES(string code)
        {
            string str;
            byte[] bytes = Encoding.UTF8.GetBytes(code);
            using (TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider())
            {
                provider.Key = Encoding.ASCII.GetBytes("6\x0017^mM*\"p:ed\x001a\acO@jPH9^Px#");
                provider.IV = Encoding.ASCII.GetBytes("De 63A&*");
                using (MemoryStream stream = new MemoryStream())
                {
                    using (CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        stream2.Write(bytes, 0, bytes.Length);
                        stream2.FlushFinalBlock();
                    }
                    str = Convert.ToBase64String(stream.ToArray());
                }
            }
            return str;
        }

        public string DecryptDES(string password, string verify)
        {
            string str;
            if (verify != "ZZR")
            {
                return "";
            }
            byte[] buffer = Convert.FromBase64String(password);
            using (TripleDESCryptoServiceProvider provider = new TripleDESCryptoServiceProvider())
            {
                provider.Key = Encoding.ASCII.GetBytes("6\x0017^mM*\"p:ed\x001a\acO@jPH9^Px#");
                provider.IV = Encoding.ASCII.GetBytes("De 63A&*");
                using (MemoryStream stream = new MemoryStream())
                {
                    using (CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        stream2.Write(buffer, 0, buffer.Length);
                        stream2.FlushFinalBlock();
                        stream2.Close();
                    }
                    str = Encoding.UTF8.GetString(stream.ToArray());
                }
            }
            return str;
        }

        public static string GetEncryptionPwd(string pwd, string number)
        {
            int num;
            pwd = pwd.ToLower();
            string str = "QIAN" + pwd;
            for (num = 0; num < number.Length; num += 2)
            {
                str = str + number.Substring(num, 1);
            }
            str = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str + "CHUANG", "MD5");

            var list = new ArrayList();
            for (num = 0; num < str.Length; num++)
            {
                list.Add(str.Substring(num, 1));
            }
            list.Reverse();
            str = "";
            for (num = 0; num < list.Count; num++)
            {
                str = str + list[num];
            }
            return str;
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string str = txt_Decrypt.Text.Trim();
            txt_Enctry.Text = DecryptDES(str, "ZZR");
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string str = txt_Enctry.Text.Trim();
            txt_Decrypt.Text = EncryptDES(str);
        }

        private void btn_MD5_Click(object sender, EventArgs e)
        {
            string number = txt_Number.Text.Trim();
            string pwd = txt_Enctry.Text.Trim();
            txt_Decrypt.Text = GetEncryptionPwd(pwd, number);
        }
    }
}
