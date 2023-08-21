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
            this.mk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txB_usuarioCad = new System.Windows.Forms.TextBox();
            this.txB_email = new System.Windows.Forms.TextBox();
            this.mk_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txB_senha = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
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
            this.dt_nascimento.Location = new System.Drawing.Point(239, 191);
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
            this.bt_concluir.Click += new System.EventHandler(this.bt_concluir_Click);
            // 
            // lb_nascimento
            // 
            this.lb_nascimento.AutoSize = true;
            this.lb_nascimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nascimento.Location = new System.Drawing.Point(61, 191);
            this.lb_nascimento.Name = "lb_nascimento";
            this.lb_nascimento.Size = new System.Drawing.Size(172, 18);
            this.lb_nascimento.TabIndex = 24;
            this.lb_nascimento.Text = "Data de nascimento:";
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(61, 260);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(82, 18);
            this.lb_telefone.TabIndex = 23;
            this.lb_telefone.Text = "Telefone:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(61, 126);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(46, 18);
            this.lb_cpf.TabIndex = 22;
            this.lb_cpf.Text = "CPF:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(61, 59);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(59, 18);
            this.lb_nome.TabIndex = 20;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(61, 329);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(56, 18);
            this.lb_email.TabIndex = 35;
            this.lb_email.Text = "Email:";
            // 
            // mk_cpf
            // 
            this.mk_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mk_cpf.Location = new System.Drawing.Point(113, 123);
            this.mk_cpf.Name = "mk_cpf";
            this.mk_cpf.Size = new System.Drawing.Size(244, 26);
            this.mk_cpf.TabIndex = 37;
            // 
            // txB_usuarioCad
            // 
            this.txB_usuarioCad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_usuarioCad.Location = new System.Drawing.Point(126, 56);
            this.txB_usuarioCad.Name = "txB_usuarioCad";
            this.txB_usuarioCad.Size = new System.Drawing.Size(244, 26);
            this.txB_usuarioCad.TabIndex = 38;
            // 
            // txB_email
            // 
            this.txB_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_email.Location = new System.Drawing.Point(123, 326);
            this.txB_email.Name = "txB_email";
            this.txB_email.Size = new System.Drawing.Size(244, 26);
            this.txB_email.TabIndex = 39;
            // 
            // mk_telefone
            // 
            this.mk_telefone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mk_telefone.Location = new System.Drawing.Point(149, 257);
            this.mk_telefone.Name = "mk_telefone";
            this.mk_telefone.Size = new System.Drawing.Size(244, 26);
            this.mk_telefone.TabIndex = 40;
            // 
            // txB_senha
            // 
            this.txB_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_senha.Location = new System.Drawing.Point(131, 380);
            this.txB_senha.Name = "txB_senha";
            this.txB_senha.Size = new System.Drawing.Size(244, 26);
            this.txB_senha.TabIndex = 42;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(61, 383);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(64, 18);
            this.lb_senha.TabIndex = 41;
            this.lb_senha.Text = "Senha:";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txB_senha);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.mk_telefone);
            this.Controls.Add(this.txB_email);
            this.Controls.Add(this.txB_usuarioCad);
            this.Controls.Add(this.mk_cpf);
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
        private System.Windows.Forms.MaskedTextBox mk_cpf;
        private System.Windows.Forms.TextBox txB_usuarioCad;
        private System.Windows.Forms.TextBox txB_email;
        private System.Windows.Forms.MaskedTextBox mk_telefone;
        private System.Windows.Forms.TextBox txB_senha;
        private System.Windows.Forms.Label lb_senha;
    }
}