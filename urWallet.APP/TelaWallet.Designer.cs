namespace urWallet.APP
{
    partial class TelaWallet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listView1 = new ListView();
            label7 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(136, 31);
            label3.TabIndex = 6;
            label3.Text = "urWallet";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(363, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 7;
            label1.Text = "Seu saldo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(731, 22);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(15, 405);
            button1.Name = "button1";
            button1.Size = new Size(133, 33);
            button1.TabIndex = 9;
            button1.Text = "Adicionar Finança";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(175, 29);
            label4.Name = "label4";
            label4.Size = new Size(154, 17);
            label4.TabIndex = 10;
            label4.Text = "Olá, caua@gmail.com";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(451, 29);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 13;
            label5.Text = "R$ 10000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 34);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 14;
            label6.Click += label6_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Window;
            listView1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(12, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(600, 284);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 93);
            label7.Name = "label7";
            label7.Size = new Size(168, 19);
            label7.TabIndex = 16;
            label7.Text = "Histórico financeiro: ";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(580, 25);
            button2.Name = "button2";
            button2.Size = new Size(81, 24);
            button2.TabIndex = 17;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_3;
            // 
            // TelaWallet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(673, 450);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "TelaWallet";
            Text = "TelaWallet";
            Load += TelaWallet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView listView1;
        private Label label7;
        private Button button2;
    }
}