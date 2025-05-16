using MyComesticShop.DatabaseLayer;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MyComesticShop.Forms.DangNhap
{
    public partial class QuenMatKhauFrm : Form
    {
        public QuenMatKhauFrm()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(txtEmail.Text.Length == 0)
            {
                ep.SetError(txtEmail, "Hãy nhập email khôi phục!");
                txtEmail.Focus();
                return;
            }
            string message = ForgotPassword(txtEmail.Text.Trim());
            MessageBox.Show(message);
        }

        public string ForgotPassword(string email)
        {
            string message = string.Empty;
            try
            {
                DataTable dt = DatabaseAccess.Retrive("SELECT TOP 1 ten_dang_nhap, mat_khau FROM TaiKhoan WHERE email = '" + email.Trim() + "'");
                if (dt != null && dt.Rows.Count > 0)
                {
                    string receiver = email;
                    string subject = "Phục hồi mật khẩu!";

                    var senderEmail = new MailAddress("nguyennguyen1128204@gmail.com", "Phục hồi mật khẩu shop mỹ phẩm!");
                    var receiverEmail = new MailAddress(receiver, "Người dùng");
                    var password = "vgqeagpojawfshny"; // ⚠️ Không nên để mật khẩu trong code thật!

                    var body = "Tên đăng nhập: " + dt.Rows[0][0].ToString() + " \nMật khẩu: " + dt.Rows[0][1].ToString();
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    message = "Thông tin đăng nhập đã được gửi thành công. Vui lòng kiểm tra Email!";
                }
                else
                {
                    message = "Vui lòng nhập địa chỉ Email chính xác định dạng!";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }

        private void QuenMatKhauFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
