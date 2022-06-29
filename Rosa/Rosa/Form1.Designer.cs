
namespace Rosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CadastroRosa = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.ciclo = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CadastroRosa
            // 
            this.CadastroRosa.AutoSize = true;
            this.CadastroRosa.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroRosa.Location = new System.Drawing.Point(534, 157);
            this.CadastroRosa.Name = "CadastroRosa";
            this.CadastroRosa.Size = new System.Drawing.Size(358, 75);
            this.CadastroRosa.TabIndex = 0;
            this.CadastroRosa.Text = "Cadastro Rosa ++";
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(0, 62);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(315, 38);
            this.cadastrar.TabIndex = 14;
            this.cadastrar.Text = "Cadastro";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // ciclo
            // 
            this.ciclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ciclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciclo.Location = new System.Drawing.Point(0, 157);
            this.ciclo.Name = "ciclo";
            this.ciclo.Size = new System.Drawing.Size(315, 38);
            this.ciclo.TabIndex = 15;
            this.ciclo.Text = "Ciclo menstrual";
            this.ciclo.UseVisualStyleBackColor = false;
            this.ciclo.Click += new System.EventHandler(this.ciclo_Click);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(0, 254);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(315, 38);
            this.consultar.TabIndex = 16;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.Location = new System.Drawing.Point(0, 350);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(315, 38);
            this.Atualizar.TabIndex = 17;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.ciclo);
            this.panel1.Controls.Add(this.Atualizar);
            this.panel1.Controls.Add(this.cadastrar);
            this.panel1.Controls.Add(this.consultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 450);
            this.panel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CadastroRosa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rosa ++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CadastroRosa;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button ciclo;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Panel panel1;
    }
}

