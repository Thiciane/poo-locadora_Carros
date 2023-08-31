namespace LocadoraCarros.Telinhas
{
    partial class Alugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alugar));
            this.lb_alugar = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.lb_modelo = new System.Windows.Forms.Label();
            this.lb_cor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_marca = new System.Windows.Forms.ComboBox();
            this.cB_modelo = new System.Windows.Forms.ComboBox();
            this.cB_ano = new System.Windows.Forms.ComboBox();
            this.cB_cor = new System.Windows.Forms.ComboBox();
            this.bt_concluir = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cB_dias = new System.Windows.Forms.ComboBox();
            this.lb_dias = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbDados = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_alugar
            // 
            this.lb_alugar.AutoSize = true;
            this.lb_alugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alugar.Location = new System.Drawing.Point(12, 12);
            this.lb_alugar.Name = "lb_alugar";
            this.lb_alugar.Size = new System.Drawing.Size(101, 32);
            this.lb_alugar.TabIndex = 0;
            this.lb_alugar.Text = "Alugar";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_marca.Location = new System.Drawing.Point(25, 110);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(63, 18);
            this.lb_marca.TabIndex = 1;
            this.lb_marca.Text = "Marca:";
            // 
            // lb_modelo
            // 
            this.lb_modelo.AutoSize = true;
            this.lb_modelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modelo.Location = new System.Drawing.Point(28, 171);
            this.lb_modelo.Name = "lb_modelo";
            this.lb_modelo.Size = new System.Drawing.Size(70, 18);
            this.lb_modelo.TabIndex = 4;
            this.lb_modelo.Text = "Modelo:";
            // 
            // lb_cor
            // 
            this.lb_cor.AutoSize = true;
            this.lb_cor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cor.Location = new System.Drawing.Point(319, 171);
            this.lb_cor.Name = "lb_cor";
            this.lb_cor.Size = new System.Drawing.Size(42, 18);
            this.lb_cor.TabIndex = 5;
            this.lb_cor.Text = "Cor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ano:";
            // 
            // cB_marca
            // 
            this.cB_marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_marca.FormattingEnabled = true;
            this.cB_marca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Ford",
            "Peugeot",
            "Reno",
            "Volkswagen"});
            this.cB_marca.Location = new System.Drawing.Point(94, 107);
            this.cB_marca.Name = "cB_marca";
            this.cB_marca.Size = new System.Drawing.Size(201, 26);
            this.cB_marca.TabIndex = 8;
            this.cB_marca.SelectedIndexChanged += new System.EventHandler(this.cB_marca_SelectedIndexChanged);
            // 
            // cB_modelo
            // 
            this.cB_modelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_modelo.FormattingEnabled = true;
            this.cB_modelo.Location = new System.Drawing.Point(104, 171);
            this.cB_modelo.Name = "cB_modelo";
            this.cB_modelo.Size = new System.Drawing.Size(201, 26);
            this.cB_modelo.TabIndex = 9;
            // 
            // cB_ano
            // 
            this.cB_ano.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_ano.FormattingEnabled = true;
            this.cB_ano.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2023",
            "2024"});
            this.cB_ano.Location = new System.Drawing.Point(370, 107);
            this.cB_ano.Name = "cB_ano";
            this.cB_ano.Size = new System.Drawing.Size(193, 26);
            this.cB_ano.TabIndex = 10;
            // 
            // cB_cor
            // 
            this.cB_cor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_cor.FormattingEnabled = true;
            this.cB_cor.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Prata",
            "Azul",
            "Vermelho"});
            this.cB_cor.Location = new System.Drawing.Point(370, 168);
            this.cB_cor.Name = "cB_cor";
            this.cB_cor.Size = new System.Drawing.Size(193, 26);
            this.cB_cor.TabIndex = 11;
            // 
            // bt_concluir
            // 
            this.bt_concluir.BackColor = System.Drawing.Color.White;
            this.bt_concluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_concluir.ForeColor = System.Drawing.Color.Black;
            this.bt_concluir.Location = new System.Drawing.Point(38, 464);
            this.bt_concluir.Name = "bt_concluir";
            this.bt_concluir.Size = new System.Drawing.Size(251, 34);
            this.bt_concluir.TabIndex = 12;
            this.bt_concluir.Text = "Alugar";
            this.bt_concluir.UseVisualStyleBackColor = false;
            this.bt_concluir.Click += new System.EventHandler(this.bt_concluir_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.White;
            this.bt_cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.Black;
            this.bt_cancelar.Location = new System.Drawing.Point(304, 464);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(251, 34);
            this.bt_cancelar.TabIndex = 13;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 86);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "TriCar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cB_dias
            // 
            this.cB_dias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_dias.FormattingEnabled = true;
            this.cB_dias.Items.AddRange(new object[] {
            "15 dias",
            "1 mês",
            "2 meses",
            "3 meses",
            "4 meses",
            "5 meses",
            "6 meses"});
            this.cB_dias.Location = new System.Drawing.Point(84, 231);
            this.cB_dias.Name = "cB_dias";
            this.cB_dias.Size = new System.Drawing.Size(193, 26);
            this.cB_dias.TabIndex = 20;
            // 
            // lb_dias
            // 
            this.lb_dias.AutoSize = true;
            this.lb_dias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dias.Location = new System.Drawing.Point(30, 231);
            this.lb_dias.Name = "lb_dias";
            this.lb_dias.Size = new System.Drawing.Size(48, 18);
            this.lb_dias.TabIndex = 19;
            this.lb_dias.Text = "Dias:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 156);
            this.dataGridView1.TabIndex = 21;
            // 
            // lbDados
            // 
            this.lbDados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDados.FormattingEnabled = true;
            this.lbDados.ItemHeight = 18;
            this.lbDados.Location = new System.Drawing.Point(580, 107);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(321, 328);
            this.lbDados.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(619, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(929, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cB_dias);
            this.Controls.Add(this.lb_dias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_concluir);
            this.Controls.Add(this.cB_cor);
            this.Controls.Add(this.cB_ano);
            this.Controls.Add(this.cB_modelo);
            this.Controls.Add(this.cB_marca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_cor);
            this.Controls.Add(this.lb_modelo);
            this.Controls.Add(this.lb_marca);
            this.Controls.Add(this.lb_alugar);
            this.Name = "Alugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carro";
            this.Load += new System.EventHandler(this.Alugar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_alugar;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.Label lb_modelo;
        private System.Windows.Forms.Label lb_cor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_marca;
        private System.Windows.Forms.ComboBox cB_modelo;
        private System.Windows.Forms.ComboBox cB_ano;
        private System.Windows.Forms.ComboBox cB_cor;
        private System.Windows.Forms.Button bt_concluir;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cB_dias;
        private System.Windows.Forms.Label lb_dias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}