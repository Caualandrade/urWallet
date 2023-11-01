namespace urWallet.APP
{
    partial class telaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(71, 112);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 22);
            textBox1.TabIndex = 0;
            textBox1.Tag = "";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(71, 160);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 22);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(71, 195);
            button1.Name = "button1";
            button1.Size = new Size(220, 29);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 34);
            label3.Name = "label3";
            label3.Size = new Size(177, 40);
            label3.TabIndex = 5;
            label3.Text = "urWallet";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Location = new Point(196, 230);
            button2.Name = "button2";
            button2.Size = new Size(95, 26);
            button2.TabIndex = 6;
            button2.Text = "Cadastrar-se";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 236);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 7;
            label1.Text = "Ainda não tem conta?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(71, 91);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 8;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 139);
            label4.Name = "label4";
            label4.Size = new Size(48, 16);
            label4.TabIndex = 9;
            label4.Text = "Senha";
            label4.Click += label4_Click;
            // 
            // telaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(384, 361);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "telaLogin";
            Text = "Form1";
            Load += telaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}