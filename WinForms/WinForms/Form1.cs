using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace HtmlParserWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string html = rtbInput.Text.Trim();

            rtbOutput.Clear();
            lblTrangThai.Text = "Trạng thái: Đang kiểm tra...";
            lblTrangThai.ForeColor = Color.Blue;

            if (string.IsNullOrWhiteSpace(html))
            {
                lblTrangThai.Text = "Trạng thái: Lỗi";
                lblTrangThai.ForeColor = Color.Red;
                rtbOutput.ForeColor = Color.Red;
                rtbOutput.Text = "Vui lòng nhập nội dung HTML.";
                return;
            }

            FileHTML parser = new FileHTML();
            FileHTMLKetQua result = parser.Parse(html);

            if (!result.IsValid)
            {
                lblTrangThai.Text = "Trạng thái: HTML sai cú pháp";
                lblTrangThai.ForeColor = Color.Red;
                rtbOutput.ForeColor = Color.Red;
                rtbOutput.Text = "LỖI: " + result.ErrorMessage;
            }
            else
            {
                lblTrangThai.Text = "Trạng thái: HTML hợp lệ";
                lblTrangThai.ForeColor = Color.DarkGreen;
                rtbOutput.ForeColor = Color.DarkGreen;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("HTML hợp lệ.");
                sb.AppendLine("Nội dung đọc được:");
                sb.AppendLine();

                if (result.TextContents.Count == 0)
                {
                    sb.AppendLine("(Không có nội dung)");
                }
                else
                {
                    foreach (string text in result.TextContents)
                    {
                        sb.AppendLine("- " + text);
                    }
                }

                rtbOutput.Text = sb.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            rtbOutput.Clear();
            lblTrangThai.Text = "Trạng thái: Chưa kiểm tra";
            lblTrangThai.ForeColor = Color.Black;
            rtbInput.Focus();
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            rtbInput.Text =
@"<html>
<body>
<p>Hello</p>
<span>This is a label</span>
</body>
</html>";

            rtbOutput.Clear();
            lblTrangThai.Text = "Trạng thái: Đã nhập ví dụ";
            lblTrangThai.ForeColor = Color.BlueViolet;
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}