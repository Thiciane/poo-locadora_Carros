namespace LocadoraCarros.Telinhas
{
    partial class Cadastrar
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
            this.lb_menu = new System.Windows.Forms.Label();
            this.dt_nascimento = new System.Windows.Forms.DateTimePicker();
            this.bt_concluir = new System.Windows.Forms.Button();
            this.lb_nascimento = new System.Windows.Forms.Label();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lb_menu
            // 
            this.lb_menu.AutoSize = true;
            this.lb_menu.BackColor = System.Drawing.Color.Transparent;
            this.lb_menu.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lb_menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menu.ForeColor = System.Drawing.Color.Black;
            this.lb_menu.Location = new System.Drawing.Point(12, 9);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(136, 32);
            this.lb_menu.TabIndex = 34;
            this.lb_menu.Text = "Cadastro";
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nascimento.Location = new System.Drawing.Point(243, 219);
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.Size = new System.Drawing.Size(281, 20);
            this.dt_nascimento.TabIndex = 32;
            // 
            // bt_concluir
            // 
            this.bt_concluir.BackColor = System.Drawing.Color.White;
            this.bt_concluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_concluir.ForeColor = System.Drawing.Color.Black;
            this.bt_concluir.Location = new System.Drawing.Point(585, 374);
            this.bt_concluir.Name = "bt_concluir";
            this.bt_concluir.Size = new System.Drawing.Size(124, 37);
            this.bt_concluir.TabIndex = 30;
            this.bt_concluir.Text = "Concluir";
            this.bt_concluir.UseVisualStyleBackColor = false;
            // 
            // lb_nascimento
            // 
            this.lb_nascimento.AutoSize = true;
            this.lb_nascimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nascimento.Location = new System.Drawing.Point(65, 219);
            this.lb_nascimento.Name = "lb_nascimento";
            this.lb_nascimento.Size = new System.Drawing.Size(172, 18);
            this.lb_nascimento.TabIndex = 24;
            this.lb_nascimento.Text = "Data de nascimento:";
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(65, 288);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(82, 18);
            this.lb_telefone.TabIndex = 23;
            this.lb_telefone.Text = "Telefone:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(65, 154);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(46, 18);
            this.lb_cpf.TabIndex = 22;
            this.lb_cpf.Text = "CPF:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(65, 87);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(59, 18);
            this.lb_nome.TabIndex = 20;
            this.lb_nome.Text = "Nome:";
            this.lb_nome.Click += new System.EventHandler(this.lb_marca_Click);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(65, 357);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(56, 18);
            this.lb_email.TabIndex = 35;
            this.lb_email.Text = "Email:";
            this.lb_email.Click += new System.EventHandler(this.label2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(117, 151);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(244, 26);
            this.maskedTextBox1.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 26);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(127, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 26);
            this.textBox2.TabIndex = 39;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(153, 285);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(244, 26);
            this.maskedTextBox2.TabIndex = 40;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_menu);
            this.Controls.Add(this.dt_nascimento);
            this.Controls.Add(this.bt_concluir);
            this.Controls.Add(this.lb_nascimento);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_nome);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_menu;
        private System.Windows.Forms.DateTimePicker dt_nascimento;
        private System.Windows.Forms.Button bt_concluir;
        private System.Windows.Forms.Label lb_nascimento;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}