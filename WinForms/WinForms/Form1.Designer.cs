namespace HtmlParserWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblInput = new Label();
            rtbInput = new RichTextBox();
            btnCheck = new Button();
            btnXoa = new Button();
            btnVidu = new Button();
            lblOutput = new Label();
            rtbOutput = new RichTextBox();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bahnschrift SemiCondensed", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.ForeColor = SystemColors.MenuHighlight;
            lblTitle.Location = new Point(368, 40);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(549, 64);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HTML Parser dùng Queue";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.BackColor = Color.LavenderBlush;
            lblInput.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblInput.Location = new Point(47, 130);
            lblInput.Margin = new Padding(5, 0, 5, 0);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(226, 32);
            lblInput.TabIndex = 1;
            lblInput.Text = "  Nhập mã HTML  ";
            // 
            // rtbInput
            // 
            rtbInput.Font = new Font("Cambria", 10.125F);
            rtbInput.Location = new Point(47, 180);
            rtbInput.Margin = new Padding(5);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(1168, 269);
            rtbInput.TabIndex = 2;
            rtbInput.Text = "";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.LightYellow;
            btnCheck.Font = new Font("Cambria", 10.125F, FontStyle.Bold);
            btnCheck.ForeColor = SystemColors.ActiveCaptionText;
            btnCheck.Location = new Point(47, 475);
            btnCheck.Margin = new Padding(5);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(244, 50);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Kiểm tra HTML";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnParse_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightYellow;
            btnXoa.Font = new Font("Cambria", 10.125F, FontStyle.Bold);
            btnXoa.ForeColor = SystemColors.ActiveCaptionText;
            btnXoa.Location = new Point(315, 476);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 49);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnClear_Click;
            // 
            // btnVidu
            // 
            btnVidu.BackColor = Color.LightYellow;
            btnVidu.Font = new Font("Cambria", 10.125F, FontStyle.Bold);
            btnVidu.ForeColor = SystemColors.ActiveCaptionText;
            btnVidu.Location = new Point(487, 475);
            btnVidu.Margin = new Padding(5);
            btnVidu.Name = "btnVidu";
            btnVidu.Size = new Size(211, 50);
            btnVidu.TabIndex = 5;
            btnVidu.Text = "Nhập ví dụ";
            btnVidu.UseVisualStyleBackColor = false;
            btnVidu.Click += btnExample_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.BackColor = Color.LavenderBlush;
            lblOutput.Font = new Font("Cambria", 10.125F, FontStyle.Bold);
            lblOutput.Location = new Point(47, 564);
            lblOutput.Margin = new Padding(5, 0, 5, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(132, 32);
            lblOutput.TabIndex = 6;
            lblOutput.Text = "  Kết quả  ";
            // 
            // rtbOutput
            // 
            rtbOutput.BackColor = SystemColors.ButtonHighlight;
            rtbOutput.Font = new Font("Cambria", 10.125F);
            rtbOutput.Location = new Point(47, 612);
            rtbOutput.Margin = new Padding(5);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(1168, 295);
            rtbOutput.TabIndex = 7;
            rtbOutput.Text = "";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Cambria", 10.125F, FontStyle.Bold);
            lblTrangThai.ForeColor = SystemColors.InactiveCaptionText;
            lblTrangThai.Location = new Point(887, 564);
            lblTrangThai.Margin = new Padding(5, 0, 5, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(328, 32);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng thái: Chưa kiểm tra";
            lblTrangThai.Click += lblTrangThai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1268, 960);
            Controls.Add(lblTrangThai);
            Controls.Add(rtbOutput);
            Controls.Add(lblOutput);
            Controls.Add(btnVidu);
            Controls.Add(btnXoa);
            Controls.Add(btnCheck);
            Controls.Add(rtbInput);
            Controls.Add(lblInput);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HTML Parser - Queue";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnVidu;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblTrangThai;
    }
}