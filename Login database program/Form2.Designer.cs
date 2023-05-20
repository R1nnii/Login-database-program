
using System;

namespace Login_database_program
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
            this.textlogKode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textlogBruger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nologin = new System.Windows.Forms.Button();
            this.logK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textlogKode
            // 
            this.textlogKode.Location = new System.Drawing.Point(413, 114);
            this.textlogKode.Name = "textlogKode";
            this.textlogKode.PasswordChar = '*';
            this.textlogKode.Size = new System.Drawing.Size(145, 20);
            this.textlogKode.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Indtast Kodeord";
            // 
            // textlogBruger
            // 
            this.textlogBruger.Location = new System.Drawing.Point(413, 64);
            this.textlogBruger.Name = "textlogBruger";
            this.textlogBruger.Size = new System.Drawing.Size(145, 20);
            this.textlogBruger.TabIndex = 17;
            this.textlogBruger.TextChanged += new System.EventHandler(this.textlogBruger_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Indtast brugernavn";
            // 
            // nologin
            // 
            this.nologin.Location = new System.Drawing.Point(654, 12);
            this.nologin.Name = "nologin";
            this.nologin.Size = new System.Drawing.Size(134, 115);
            this.nologin.TabIndex = 23;
            this.nologin.Text = "Har ikke et log in, click her for at lave en bruger";
            this.nologin.UseVisualStyleBackColor = true;
            this.nologin.Click += new System.EventHandler(this.nologin_Click);
            // 
            // logK
            // 
            this.logK.Location = new System.Drawing.Point(427, 164);
            this.logK.Name = "logK";
            this.logK.Size = new System.Drawing.Size(111, 80);
            this.logK.TabIndex = 24;
            this.logK.Text = "LOG IND";
            this.logK.UseVisualStyleBackColor = true;
            this.logK.Click += new System.EventHandler(this.logK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logK);
            this.Controls.Add(this.nologin);
            this.Controls.Add(this.textlogKode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textlogBruger);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textlogKode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textlogBruger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nologin;
        private System.Windows.Forms.Button logK;
    }
}