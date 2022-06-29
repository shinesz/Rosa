
namespace Rosa
{
    partial class EventsForms
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
            this.save = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.txevent = new System.Windows.Forms.TextBox();
            this.txdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(356, 262);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 11;
            this.save.Text = "salvar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Event
            // 
            this.Event.AutoSize = true;
            this.Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event.Location = new System.Drawing.Point(52, 149);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(69, 24);
            this.Event.TabIndex = 10;
            this.Event.Text = "Evento";
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(52, 47);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(47, 24);
            this.date.TabIndex = 8;
            this.date.Text = "Data";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // txevent
            // 
            this.txevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txevent.Location = new System.Drawing.Point(56, 186);
            this.txevent.Name = "txevent";
            this.txevent.Size = new System.Drawing.Size(375, 29);
            this.txevent.TabIndex = 7;
            this.txevent.TextChanged += new System.EventHandler(this.txevent_TextChanged);
            // 
            // txdate
            // 
            this.txdate.Enabled = false;
            this.txdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.Location = new System.Drawing.Point(56, 83);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(375, 29);
            this.txdate.TabIndex = 6;
            this.txdate.TextChanged += new System.EventHandler(this.txdate_TextChanged);
            // 
            // EventsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(501, 324);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.txdate);
            this.Name = "EventsForms";
            this.Text = "EventsForms";
            this.Load += new System.EventHandler(this.EventsForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label Event;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox txevent;
        private System.Windows.Forms.TextBox txdate;
    }
}