
namespace Rosa
{
    partial class Form2
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
            this.LDdate = new System.Windows.Forms.Label();
            this.Sab = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.qui = new System.Windows.Forms.Label();
            this.qua = new System.Windows.Forms.Label();
            this.Ter = new System.Windows.Forms.Label();
            this.seg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotaoPro = new System.Windows.Forms.Button();
            this.BotaoAn = new System.Windows.Forms.Button();
            this.RecipienteDoDia = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LDdate
            // 
            this.LDdate.AutoSize = true;
            this.LDdate.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDdate.Location = new System.Drawing.Point(632, 22);
            this.LDdate.Name = "LDdate";
            this.LDdate.Size = new System.Drawing.Size(115, 31);
            this.LDdate.TabIndex = 32;
            this.LDdate.Text = "Mês Ano";
            this.LDdate.Click += new System.EventHandler(this.LDdate_Click);
            // 
            // Sab
            // 
            this.Sab.AutoSize = true;
            this.Sab.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sab.Location = new System.Drawing.Point(548, 54);
            this.Sab.Name = "Sab";
            this.Sab.Size = new System.Drawing.Size(77, 23);
            this.Sab.TabIndex = 31;
            this.Sab.Text = "Sábado";
            this.Sab.Click += new System.EventHandler(this.Sab_Click);
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(483, 54);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(59, 23);
            this.Sex.TabIndex = 26;
            this.Sex.Text = "Sexta";
            this.Sex.Click += new System.EventHandler(this.Sex_Click);
            // 
            // qui
            // 
            this.qui.AutoSize = true;
            this.qui.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qui.Location = new System.Drawing.Point(403, 54);
            this.qui.Name = "qui";
            this.qui.Size = new System.Drawing.Size(70, 23);
            this.qui.TabIndex = 30;
            this.qui.Text = "Quinta";
            this.qui.Click += new System.EventHandler(this.qui_Click);
            // 
            // qua
            // 
            this.qua.AutoSize = true;
            this.qua.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qua.Location = new System.Drawing.Point(326, 54);
            this.qua.Name = "qua";
            this.qua.Size = new System.Drawing.Size(71, 23);
            this.qua.TabIndex = 29;
            this.qua.Text = "Quarta";
            this.qua.Click += new System.EventHandler(this.qua_Click);
            // 
            // Ter
            // 
            this.Ter.AutoSize = true;
            this.Ter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ter.Location = new System.Drawing.Point(260, 54);
            this.Ter.Name = "Ter";
            this.Ter.Size = new System.Drawing.Size(58, 23);
            this.Ter.TabIndex = 28;
            this.Ter.Text = "Terça";
            this.Ter.Click += new System.EventHandler(this.Ter_Click);
            // 
            // seg
            // 
            this.seg.AutoSize = true;
            this.seg.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seg.Location = new System.Drawing.Point(168, 54);
            this.seg.Name = "seg";
            this.seg.Size = new System.Drawing.Size(89, 23);
            this.seg.TabIndex = 27;
            this.seg.Text = "Segunda";
            this.seg.Click += new System.EventHandler(this.seg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Domingo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BotaoPro
            // 
            this.BotaoPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotaoPro.Location = new System.Drawing.Point(658, 521);
            this.BotaoPro.Name = "BotaoPro";
            this.BotaoPro.Size = new System.Drawing.Size(70, 26);
            this.BotaoPro.TabIndex = 24;
            this.BotaoPro.Text = "Proximo";
            this.BotaoPro.UseVisualStyleBackColor = true;
            this.BotaoPro.Click += new System.EventHandler(this.BotaoPro_Click);
            // 
            // BotaoAn
            // 
            this.BotaoAn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotaoAn.Location = new System.Drawing.Point(566, 520);
            this.BotaoAn.Name = "BotaoAn";
            this.BotaoAn.Size = new System.Drawing.Size(69, 27);
            this.BotaoAn.TabIndex = 23;
            this.BotaoAn.Text = "Voltar";
            this.BotaoAn.UseVisualStyleBackColor = true;
            this.BotaoAn.Click += new System.EventHandler(this.BotaoAn_Click);
            // 
            // RecipienteDoDia
            // 
            this.RecipienteDoDia.BackColor = System.Drawing.Color.White;
            this.RecipienteDoDia.Location = new System.Drawing.Point(81, 96);
            this.RecipienteDoDia.Name = "RecipienteDoDia";
            this.RecipienteDoDia.Size = new System.Drawing.Size(581, 415);
            this.RecipienteDoDia.TabIndex = 22;
            this.RecipienteDoDia.Paint += new System.Windows.Forms.PaintEventHandler(this.RecipienteDoDia_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 569);
            this.Controls.Add(this.LDdate);
            this.Controls.Add(this.Sab);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.qui);
            this.Controls.Add(this.qua);
            this.Controls.Add(this.Ter);
            this.Controls.Add(this.seg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotaoPro);
            this.Controls.Add(this.BotaoAn);
            this.Controls.Add(this.RecipienteDoDia);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDdate;
        private System.Windows.Forms.Label Sab;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label qui;
        private System.Windows.Forms.Label qua;
        private System.Windows.Forms.Label Ter;
        private System.Windows.Forms.Label seg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotaoPro;
        private System.Windows.Forms.Button BotaoAn;
        private System.Windows.Forms.FlowLayoutPanel RecipienteDoDia;
    }
}