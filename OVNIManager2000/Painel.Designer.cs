namespace OVNIManager2000
{
    partial class Painel
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnAdicionarTripulante = new System.Windows.Forms.Button();
            this.btnRemoverTripulante = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.btnMudar = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.bntRetornarOrigem = new System.Windows.Forms.Button();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.lblPlaneta);
            this.grbDados.Controls.Add(this.lblTripulantes);
            this.grbDados.Controls.Add(this.lblAbduzidos);
            this.grbDados.Controls.Add(this.lblSituacao);
            this.grbDados.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(10, 17);
            this.grbDados.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grbDados.Name = "grbDados";
            this.grbDados.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grbDados.Size = new System.Drawing.Size(288, 167);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(2, 19);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(55, 16);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(2, 46);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(66, 16);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(2, 74);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(68, 16);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes:";
            this.lblTripulantes.Click += new System.EventHandler(this.lblTripulantes_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(10, 187);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(288, 45);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(10, 238);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(288, 45);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnAdicionarTripulante
            // 
            this.btnAdicionarTripulante.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTripulante.Location = new System.Drawing.Point(303, 24);
            this.btnAdicionarTripulante.Name = "btnAdicionarTripulante";
            this.btnAdicionarTripulante.Size = new System.Drawing.Size(150, 41);
            this.btnAdicionarTripulante.TabIndex = 3;
            this.btnAdicionarTripulante.Text = "Adicionar tripulante";
            this.btnAdicionarTripulante.UseVisualStyleBackColor = true;
            // 
            // btnRemoverTripulante
            // 
            this.btnRemoverTripulante.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverTripulante.Location = new System.Drawing.Point(305, 71);
            this.btnRemoverTripulante.Name = "btnRemoverTripulante";
            this.btnRemoverTripulante.Size = new System.Drawing.Size(148, 36);
            this.btnRemoverTripulante.TabIndex = 4;
            this.btnRemoverTripulante.Text = "Remover tripulante";
            this.btnRemoverTripulante.UseVisualStyleBackColor = true;
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbduzir.Location = new System.Drawing.Point(305, 114);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(148, 33);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesabduzir.Location = new System.Drawing.Point(303, 153);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(150, 31);
            this.btnDesabduzir.TabIndex = 6;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = true;
            // 
            // btnMudar
            // 
            this.btnMudar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudar.Location = new System.Drawing.Point(396, 242);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(57, 37);
            this.btnMudar.TabIndex = 7;
            this.btnMudar.Text = "Mudar";
            this.btnMudar.UseVisualStyleBackColor = true;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Uighur", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(303, 249);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(87, 28);
            this.cmbPlanetas.TabIndex = 8;
            // 
            // bntRetornarOrigem
            // 
            this.bntRetornarOrigem.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRetornarOrigem.Location = new System.Drawing.Point(303, 187);
            this.bntRetornarOrigem.Name = "bntRetornarOrigem";
            this.bntRetornarOrigem.Size = new System.Drawing.Size(150, 45);
            this.bntRetornarOrigem.TabIndex = 9;
            this.bntRetornarOrigem.Text = "Retornar a origem";
            this.bntRetornarOrigem.UseVisualStyleBackColor = true;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(6, 97);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(46, 16);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta";
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 330);
            this.Controls.Add(this.bntRetornarOrigem);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.btnMudar);
            this.Controls.Add(this.btnDesabduzir);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnRemoverTripulante);
            this.Controls.Add(this.btnAdicionarTripulante);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.grbDados);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Painel";
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnAdicionarTripulante;
        private System.Windows.Forms.Button btnRemoverTripulante;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.Button btnMudar;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button bntRetornarOrigem;
        private System.Windows.Forms.Label lblPlaneta;
    }
}