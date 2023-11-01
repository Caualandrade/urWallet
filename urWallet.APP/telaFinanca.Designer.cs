namespace urWallet.APP
{
    partial class telaFinanca
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label4 = new Label();
            textBoxValor = new TextBox();
            listBox1 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            textBoxDescricao = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 22);
            label3.Name = "label3";
            label3.Size = new Size(136, 31);
            label3.TabIndex = 13;
            label3.Text = "urWallet";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 89);
            label1.Name = "label1";
            label1.Size = new Size(196, 19);
            label1.TabIndex = 14;
            label1.Text = "Classificação financeira:";
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(249, 89);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 20);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Receita";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(340, 89);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 20);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Despesa";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 124);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 17;
            label2.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 166);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 19;
            label4.Text = "Valor:";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(166, 166);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(230, 23);
            textBoxValor.TabIndex = 20;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Items.AddRange(new object[] { "Receita", "Saúde e beleza", "Transporte", "Lazer", "Bares e restaurantes", "TV / Internet / Telefone", "Moradia", "Supermercado" });
            listBox1.Location = new Point(166, 219);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(230, 20);
            listBox1.TabIndex = 21;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 219);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 22;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 272);
            label6.Name = "label6";
            label6.Size = new Size(92, 19);
            label6.TabIndex = 23;
            label6.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(166, 268);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(230, 23);
            textBoxDescricao.TabIndex = 24;
            textBoxDescricao.TextChanged += textBoxDescricao_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(157, 344);
            button1.Name = "button1";
            button1.Size = new Size(105, 27);
            button1.TabIndex = 25;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(166, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // telaFinanca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(438, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBoxDescricao);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(textBoxValor);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "telaFinanca";
            Text = "telaFinanca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label4;
        private TextBox textBoxValor;
        private ListBox listBox1;
        private Label label5;
        private Label label6;
        private TextBox textBoxDescricao;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}