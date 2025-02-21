﻿
namespace Client
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_s = new System.Windows.Forms.Label();
            this.lbl_i = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lbl_s);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 71);
            this.panel1.TabIndex = 0;
            // 
            // lbl_s
            // 
            this.lbl_s.AutoSize = true;
            this.lbl_s.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_s.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_s.Location = new System.Drawing.Point(226, 24);
            this.lbl_s.Name = "lbl_s";
            this.lbl_s.Size = new System.Drawing.Size(164, 28);
            this.lbl_s.TabIndex = 0;
            this.lbl_s.Text = "Cerca utente";
            // 
            // lbl_i
            // 
            this.lbl_i.AutoSize = true;
            this.lbl_i.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_i.Location = new System.Drawing.Point(13, 88);
            this.lbl_i.Name = "lbl_i";
            this.lbl_i.Size = new System.Drawing.Size(152, 20);
            this.lbl_i.TabIndex = 1;
            this.lbl_i.Text = "Inserisci il nickname";
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nickname.Location = new System.Drawing.Point(171, 86);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(435, 26);
            this.txt_nickname.TabIndex = 2;
            this.txt_nickname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.Location = new System.Drawing.Point(172, 140);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 20);
            this.lbl_result.TabIndex = 3;
            // 
            // pic_profile
            // 
            this.pic_profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_profile.InitialImage")));
            this.pic_profile.Location = new System.Drawing.Point(13, 140);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(80, 80);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_profile.TabIndex = 4;
            this.pic_profile.TabStop = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 377);
            this.Controls.Add(this.pic_profile);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.lbl_i);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_s;
        private System.Windows.Forms.Label lbl_i;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.PictureBox pic_profile;
    }
}