namespace RelogioDigital
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblHoras = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnHorasMais = new System.Windows.Forms.Button();
            this.btnHorasMenos = new System.Windows.Forms.Button();
            this.btnMinutosMais = new System.Windows.Forms.Button();
            this.btnMinutosMenos = new System.Windows.Forms.Button();
            this.btnSegundosMais = new System.Windows.Forms.Button();
            this.btnSegundosMenos = new System.Windows.Forms.Button();
            this.timerRelogioDigital = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(144)))));
            this.lblHoras.Location = new System.Drawing.Point(3, 10);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(109, 85);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(345, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 85);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(144)))));
            this.lblSegundos.Location = new System.Drawing.Point(3, 10);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(109, 85);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "00";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(144)))));
            this.lblMinutos.Location = new System.Drawing.Point(3, 10);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(109, 85);
            this.lblMinutos.TabIndex = 3;
            this.lblMinutos.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(172, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 85);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(204, 248);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 5;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(285, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnHorasMais
            // 
            this.btnHorasMais.BackColor = System.Drawing.Color.Peru;
            this.btnHorasMais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHorasMais.Location = new System.Drawing.Point(69, 207);
            this.btnHorasMais.Name = "btnHorasMais";
            this.btnHorasMais.Size = new System.Drawing.Size(34, 23);
            this.btnHorasMais.TabIndex = 7;
            this.btnHorasMais.Text = "+";
            this.btnHorasMais.UseVisualStyleBackColor = false;
            this.btnHorasMais.Visible = false;
            this.btnHorasMais.Click += new System.EventHandler(this.btnHorasMais_Click);
            // 
            // btnHorasMenos
            // 
            this.btnHorasMenos.BackColor = System.Drawing.Color.Peru;
            this.btnHorasMenos.Location = new System.Drawing.Point(109, 207);
            this.btnHorasMenos.Name = "btnHorasMenos";
            this.btnHorasMenos.Size = new System.Drawing.Size(34, 23);
            this.btnHorasMenos.TabIndex = 8;
            this.btnHorasMenos.Text = "-";
            this.btnHorasMenos.UseVisualStyleBackColor = false;
            this.btnHorasMenos.Visible = false;
            this.btnHorasMenos.Click += new System.EventHandler(this.btnHorasMenos_Click);
            // 
            // btnMinutosMais
            // 
            this.btnMinutosMais.BackColor = System.Drawing.Color.Peru;
            this.btnMinutosMais.Location = new System.Drawing.Point(245, 207);
            this.btnMinutosMais.Name = "btnMinutosMais";
            this.btnMinutosMais.Size = new System.Drawing.Size(34, 23);
            this.btnMinutosMais.TabIndex = 9;
            this.btnMinutosMais.Text = "+";
            this.btnMinutosMais.UseVisualStyleBackColor = false;
            this.btnMinutosMais.Visible = false;
            this.btnMinutosMais.Click += new System.EventHandler(this.btnMinutosMais_Click);
            // 
            // btnMinutosMenos
            // 
            this.btnMinutosMenos.BackColor = System.Drawing.Color.Peru;
            this.btnMinutosMenos.Location = new System.Drawing.Point(285, 207);
            this.btnMinutosMenos.Name = "btnMinutosMenos";
            this.btnMinutosMenos.Size = new System.Drawing.Size(34, 23);
            this.btnMinutosMenos.TabIndex = 10;
            this.btnMinutosMenos.Text = "-";
            this.btnMinutosMenos.UseVisualStyleBackColor = false;
            this.btnMinutosMenos.Visible = false;
            this.btnMinutosMenos.Click += new System.EventHandler(this.btnMinutosMenos_Click);
            // 
            // btnSegundosMais
            // 
            this.btnSegundosMais.BackColor = System.Drawing.Color.Peru;
            this.btnSegundosMais.Location = new System.Drawing.Point(417, 207);
            this.btnSegundosMais.Name = "btnSegundosMais";
            this.btnSegundosMais.Size = new System.Drawing.Size(34, 23);
            this.btnSegundosMais.TabIndex = 11;
            this.btnSegundosMais.Text = "+";
            this.btnSegundosMais.UseVisualStyleBackColor = false;
            this.btnSegundosMais.Visible = false;
            this.btnSegundosMais.Click += new System.EventHandler(this.btnSegundosMais_Click);
            // 
            // btnSegundosMenos
            // 
            this.btnSegundosMenos.BackColor = System.Drawing.Color.Peru;
            this.btnSegundosMenos.Location = new System.Drawing.Point(457, 207);
            this.btnSegundosMenos.Name = "btnSegundosMenos";
            this.btnSegundosMenos.Size = new System.Drawing.Size(34, 23);
            this.btnSegundosMenos.TabIndex = 12;
            this.btnSegundosMenos.Text = "-";
            this.btnSegundosMenos.UseVisualStyleBackColor = false;
            this.btnSegundosMenos.Visible = false;
            this.btnSegundosMenos.Click += new System.EventHandler(this.btnSegundosMenos_Click);
            // 
            // timerRelogioDigital
            // 
            this.timerRelogioDigital.Enabled = true;
            this.timerRelogioDigital.Interval = 1000;
            this.timerRelogioDigital.Tick += new System.EventHandler(this.timerRelogioDigital_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(95)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.lblHoras);
            this.panel1.Location = new System.Drawing.Point(54, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 95);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(95)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.lblMinutos);
            this.panel2.Location = new System.Drawing.Point(230, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 95);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(95)))), ((int)(((byte)(19)))));
            this.panel3.Controls.Add(this.lblSegundos);
            this.panel3.Location = new System.Drawing.Point(403, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 95);
            this.panel3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(595, 340);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSegundosMenos);
            this.Controls.Add(this.btnSegundosMais);
            this.Controls.Add(this.btnMinutosMenos);
            this.Controls.Add(this.btnMinutosMais);
            this.Controls.Add(this.btnHorasMenos);
            this.Controls.Add(this.btnHorasMais);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relógio Digital";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnHorasMais;
        private System.Windows.Forms.Button btnHorasMenos;
        private System.Windows.Forms.Button btnMinutosMais;
        private System.Windows.Forms.Button btnMinutosMenos;
        private System.Windows.Forms.Button btnSegundosMais;
        private System.Windows.Forms.Button btnSegundosMenos;
        private System.Windows.Forms.Timer timerRelogioDigital;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

