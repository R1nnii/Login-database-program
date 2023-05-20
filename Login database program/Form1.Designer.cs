
namespace Login_database_program
{
    partial class Form1
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
            this.loginknap = new System.Windows.Forms.Button();
            this.brugerknap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textkode2 = new System.Windows.Forms.TextBox();
            this.textkode1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbruger1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginknap
            // 
            this.loginknap.Location = new System.Drawing.Point(643, 12);
            this.loginknap.Name = "loginknap";
            this.loginknap.Size = new System.Drawing.Size(145, 67);
            this.loginknap.TabIndex = 15;
            this.loginknap.Text = "Har du allerede en bruger? LOG IN HER";
            this.loginknap.UseVisualStyleBackColor = true;
            this.loginknap.Click += new System.EventHandler(this.loginknap_Click);
            // 
            // brugerknap
            // 
            this.brugerknap.Location = new System.Drawing.Point(414, 190);
            this.brugerknap.Name = "brugerknap";
            this.brugerknap.Size = new System.Drawing.Size(143, 60);
            this.brugerknap.TabIndex = 14;
            this.brugerknap.Text = "Opret ny bruger";
            this.brugerknap.UseVisualStyleBackColor = true;
            this.brugerknap.Click += new System.EventHandler(this.brugerknap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Indtast ønsket Kodeord igen";
            // 
            // textkode2
            // 
            this.textkode2.Location = new System.Drawing.Point(414, 149);
            this.textkode2.Name = "textkode2";
            this.textkode2.Size = new System.Drawing.Size(145, 20);
            this.textkode2.TabIndex = 12;
            // 
            // textkode1
            // 
            this.textkode1.Location = new System.Drawing.Point(414, 95);
            this.textkode1.Name = "textkode1";
            this.textkode1.Size = new System.Drawing.Size(145, 20);
            this.textkode1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Indtast ønsket Kodeord";
            // 
            // textbruger1
            // 
            this.textbruger1.Location = new System.Drawing.Point(414, 45);
            this.textbruger1.Name = "textbruger1";
            this.textbruger1.Size = new System.Drawing.Size(145, 20);
            this.textbruger1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Indtast ønsket brugernavn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginknap);
            this.Controls.Add(this.brugerknap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textkode2);
            this.Controls.Add(this.textkode1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbruger1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginknap;
        private System.Windows.Forms.Button brugerknap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textkode2;
        private System.Windows.Forms.TextBox textkode1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbruger1;
        private System.Windows.Forms.Label label1;
    }
}

