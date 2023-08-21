namespace LocadoraCarros
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_usuarioLog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.txB_usuario = new System.Windows.Forms.TextBox();
            this.txB_senha = new System.Windows.Forms.TextBox();
            this.bt_cadastro = new System.Windows.Forms.Button();
            this.bt_entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_usuarioLog
            // 
            this.lb_usuarioLog.AutoSize = true;
            this.lb_usuarioLog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuarioLog.ForeColor = System.Drawing.Color.White;
            this.lb_usuarioLog.Location = new System.Drawing.Point(189, 268);
            this.lb_usuarioLog.Name = "lb_usuarioLog";
            this.lb_usuarioLog.Size = new System.Drawing.Size(59, 18);
            this.lb_usuarioLog.TabIndex = 0;
            this.lb_usuarioLog.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.ForeColor = System.Drawing.Color.White;
            this.lb_senha.Location = new System.Drawing.Point(184, 308);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(64, 18);
            this.lb_senha.TabIndex = 2;
            this.lb_senha.Text = "Senha:";
            // 
            // txB_usuario
            // 
            this.txB_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_usuario.Location = new System.Drawing.Point(254, 265);
            this.txB_usuario.Name = "txB_usuario";
            this.txB_usuario.Size = new System.Drawing.Size(323, 26);
            this.txB_usuario.TabIndex = 3;
            this.txB_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txB_senha
            // 
            this.txB_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_senha.Location = new System.Drawing.Point(254, 305);
            this.txB_senha.Name = "txB_senha";
            this.txB_senha.Size = new System.Drawing.Size(323, 26);
            this.txB_senha.TabIndex = 4;
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastro.Location = new System.Drawing.Point(395, 369);
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Size = new System.Drawing.Size(110, 34);
            this.bt_cadastro.TabIndex = 5;
            this.bt_cadastro.Text = "Cadastrar";
            this.bt_cadastro.UseVisualStyleBackColor = true;
            this.bt_cadastro.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // bt_entrar
            // 
            this.bt_entrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_entrar.Location = new System.Drawing.Point(541, 369);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(110, 34);
            this.bt_entrar.TabIndex = 6;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_entrar);
            this.Controls.Add(this.bt_cadastro);
            this.Controls.Add(this.txB_senha);
            this.Controls.Add(this.txB_usuario);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_usuarioLog);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_usuarioLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox txB_usuario;
        private System.Windows.Forms.TextBox txB_senha;
        private System.Windows.Forms.Button bt_cadastro;
        private System.Windows.Forms.Button bt_entrar;
    }
}

