
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.send_message = new System.Windows.Forms.TextBox();
            this.send_bt = new System.Windows.Forms.Button();
            this.console_output_tb = new System.Windows.Forms.TextBox();
            this.token_tb = new System.Windows.Forms.TextBox();
            this.channeli_id_tb = new System.Windows.Forms.TextBox();
            this.connect_bt = new System.Windows.Forms.Button();
            this.messages_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // send_message
            // 
            this.send_message.Location = new System.Drawing.Point(12, 228);
            this.send_message.Multiline = true;
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(359, 82);
            this.send_message.TabIndex = 0;
            this.send_message.Text = "Text to send";
            this.send_message.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // send_bt
            // 
            this.send_bt.Location = new System.Drawing.Point(12, 316);
            this.send_bt.Name = "send_bt";
            this.send_bt.Size = new System.Drawing.Size(179, 46);
            this.send_bt.TabIndex = 1;
            this.send_bt.Text = "Send";
            this.send_bt.UseVisualStyleBackColor = true;
            this.send_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // console_output_tb
            // 
            this.console_output_tb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.console_output_tb.Location = new System.Drawing.Point(382, 12);
            this.console_output_tb.Multiline = true;
            this.console_output_tb.Name = "console_output_tb";
            this.console_output_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.console_output_tb.Size = new System.Drawing.Size(190, 298);
            this.console_output_tb.TabIndex = 2;
            this.console_output_tb.Text = "Output of bot";
            // 
            // token_tb
            // 
            this.token_tb.Location = new System.Drawing.Point(197, 316);
            this.token_tb.Name = "token_tb";
            this.token_tb.Size = new System.Drawing.Size(174, 20);
            this.token_tb.TabIndex = 3;
            this.token_tb.Text = "Token";
            this.token_tb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // channeli_id_tb
            // 
            this.channeli_id_tb.Location = new System.Drawing.Point(197, 342);
            this.channeli_id_tb.Name = "channeli_id_tb";
            this.channeli_id_tb.Size = new System.Drawing.Size(174, 20);
            this.channeli_id_tb.TabIndex = 4;
            this.channeli_id_tb.Text = "Channel id";
            this.channeli_id_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // connect_bt
            // 
            this.connect_bt.Location = new System.Drawing.Point(382, 314);
            this.connect_bt.Name = "connect_bt";
            this.connect_bt.Size = new System.Drawing.Size(190, 48);
            this.connect_bt.TabIndex = 5;
            this.connect_bt.Text = "Connect";
            this.connect_bt.UseVisualStyleBackColor = true;
            this.connect_bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // messages_tb
            // 
            this.messages_tb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.messages_tb.Location = new System.Drawing.Point(12, 12);
            this.messages_tb.Multiline = true;
            this.messages_tb.Name = "messages_tb";
            this.messages_tb.ReadOnly = true;
            this.messages_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messages_tb.Size = new System.Drawing.Size(359, 210);
            this.messages_tb.TabIndex = 6;
            this.messages_tb.TabStop = false;
            this.messages_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 366);
            this.Controls.Add(this.messages_tb);
            this.Controls.Add(this.connect_bt);
            this.Controls.Add(this.channeli_id_tb);
            this.Controls.Add(this.token_tb);
            this.Controls.Add(this.console_output_tb);
            this.Controls.Add(this.send_bt);
            this.Controls.Add(this.send_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Discord Bot login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox send_message;
        private System.Windows.Forms.Button send_bt;
        private System.Windows.Forms.TextBox console_output_tb;
        private System.Windows.Forms.TextBox token_tb;
        private System.Windows.Forms.TextBox channeli_id_tb;
        private System.Windows.Forms.Button connect_bt;
        private System.Windows.Forms.TextBox messages_tb;
    }
}

