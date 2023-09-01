
namespace consultaCep
{
    partial class ConsultaCEP
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
            this.lbCep = new System.Windows.Forms.Label();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.ltDados = new System.Windows.Forms.ListBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCep.Location = new System.Drawing.Point(13, 9);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(53, 25);
            this.lbCep.TabIndex = 0;
            this.lbCep.Text = "CEP";
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLocalizar.Location = new System.Drawing.Point(199, 31);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(98, 40);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ltDados
            // 
            this.ltDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ltDados.FormattingEnabled = true;
            this.ltDados.ItemHeight = 25;
            this.ltDados.Location = new System.Drawing.Point(16, 88);
            this.ltDados.Name = "ltDados";
            this.ltDados.Size = new System.Drawing.Size(366, 154);
            this.ltDados.TabIndex = 2;
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(16, 38);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(165, 23);
            this.txtCep.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(-10, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 17);
            this.panel1.TabIndex = 4;
            // 
            // ConsultaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(398, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.ltDados);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.lbCep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ConsultaCEP";
            this.Text = "Consulta de CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.ListBox ltDados;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Panel panel1;
    }
}

