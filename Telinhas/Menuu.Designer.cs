namespace LocadoraCarros.Telinhas
{
    partial class Menuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_sairHis = new System.Windows.Forms.Label();
            this.lb_usuarioHis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_menu = new System.Windows.Forms.Label();
            this.bt_alugar = new System.Windows.Forms.Button();
            this.bt_historico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lb_sairHis);
            this.panel1.Controls.Add(this.lb_usuarioHis);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 82);
            this.panel1.TabIndex = 5;
            // 
            // lb_sairHis
            // 
            this.lb_sairHis.AutoSize = true;
            this.lb_sairHis.BackColor = System.Drawing.Color.Transparent;
            this.lb_sairHis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sairHis.ForeColor = System.Drawing.Color.White;
            this.lb_sairHis.Location = new System.Drawing.Point(735, 30);
            this.lb_sairHis.Name = "lb_sairHis";
            this.lb_sairHis.Size = new System.Drawing.Size(40, 18);
            this.lb_sairHis.TabIndex = 3;
            this.lb_sairHis.Text = "Sair";
            // 
            // lb_usuarioHis
            // 
            this.lb_usuarioHis.AutoSize = true;
            this.lb_usuarioHis.BackColor = System.Drawing.Color.Transparent;
            this.lb_usuarioHis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuarioHis.ForeColor = System.Drawing.Color.White;
            this.lb_usuarioHis.Location = new System.Drawing.Point(85, 12);
            this.lb_usuarioHis.Name = "lb_usuarioHis";
            this.lb_usuarioHis.Size = new System.Drawing.Size(70, 18);
            this.lb_usuarioHis.TabIndex = 2;
            this.lb_usuarioHis.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_menu
            // 
            this.lb_menu.AutoSize = true;
            this.lb_menu.BackColor = System.Drawing.Color.Transparent;
            this.lb_menu.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lb_menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menu.ForeColor = System.Drawing.Color.Black;
            this.lb_menu.Location = new System.Drawing.Point(5, 143);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(84, 32);
            this.lb_menu.TabIndex = 4;
            this.lb_menu.Text = "Menu";
            this.lb_menu.Click += new System.EventHandler(this.lb_menu_Click);
            // 
            // bt_alugar
            // 
            this.bt_alugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alugar.Location = new System.Drawing.Point(196, 254);
            this.bt_alugar.Name = "bt_alugar";
            this.bt_alugar.Size = new System.Drawing.Size(170, 112);
            this.bt_alugar.TabIndex = 4;
            this.bt_alugar.Text = "Alugar";
            this.bt_alugar.UseVisualStyleBackColor = true;
            this.bt_alugar.Click += new System.EventHandler(this.bt_alugar_Click);
            // 
            // bt_historico
            // 
            this.bt_historico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_historico.Location = new System.Drawing.Point(406, 254);
            this.bt_historico.Name = "bt_historico";
            this.bt_historico.Size = new System.Drawing.Size(170, 112);
            this.bt_historico.TabIndex = 6;
            this.bt_historico.Text = "Histórico";
            this.bt_historico.UseVisualStyleBackColor = true;
            this.bt_historico.Click += new System.EventHandler(this.bt_historico_Click);
            // 
            // Menuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_historico);
            this.Controls.Add(this.bt_alugar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_menu);
            this.Name = "Menuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_sairHis;
        private System.Windows.Forms.Label lb_usuarioHis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_menu;
        private System.Windows.Forms.Button bt_alugar;
        private System.Windows.Forms.Button bt_historico;
    }
}