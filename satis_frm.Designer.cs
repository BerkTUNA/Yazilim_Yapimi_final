﻿namespace Proje_Ödevi
{
    partial class satis_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satis_frm));
            this.birimdeger_lbl = new System.Windows.Forms.Label();
            this.birimdeger = new System.Windows.Forms.TextBox();
            this.onay_btn = new System.Windows.Forms.Button();
            this.birimfiyat = new System.Windows.Forms.TextBox();
            this.birimfiyat_lbl = new System.Windows.Forms.Label();
            this.cikissatisekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birimdeger_lbl
            // 
            this.birimdeger_lbl.AutoSize = true;
            this.birimdeger_lbl.BackColor = System.Drawing.Color.Transparent;
            this.birimdeger_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimdeger_lbl.Location = new System.Drawing.Point(165, 95);
            this.birimdeger_lbl.Name = "birimdeger_lbl";
            this.birimdeger_lbl.Size = new System.Drawing.Size(206, 16);
            this.birimdeger_lbl.TabIndex = 0;
            this.birimdeger_lbl.Text = "Ne kadar satmak istiyorsunuz?";
            // 
            // birimdeger
            // 
            this.birimdeger.ForeColor = System.Drawing.Color.Silver;
            this.birimdeger.Location = new System.Drawing.Point(168, 127);
            this.birimdeger.Name = "birimdeger";
            this.birimdeger.Size = new System.Drawing.Size(175, 20);
            this.birimdeger.TabIndex = 1;
            this.birimdeger.Text = "Satmak istediğiniz miktarı giriniz";
            
            this.birimdeger.Enter += new System.EventHandler(this.birimdeger_Enter);
            this.birimdeger.Leave += new System.EventHandler(this.birimdeger_Leave);
            // 
            // onay_btn
            // 
            this.onay_btn.BackColor = System.Drawing.SystemColors.Control;
            this.onay_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.onay_btn.ForeColor = System.Drawing.Color.Black;
            this.onay_btn.Location = new System.Drawing.Point(168, 263);
            this.onay_btn.Name = "onay_btn";
            this.onay_btn.Size = new System.Drawing.Size(175, 37);
            this.onay_btn.TabIndex = 2;
            this.onay_btn.Text = "Onayla";
            this.onay_btn.UseVisualStyleBackColor = false;
            this.onay_btn.Click += new System.EventHandler(this.onay_btn_Click);
            // 
            // birimfiyat
            // 
            this.birimfiyat.ForeColor = System.Drawing.Color.Silver;
            this.birimfiyat.Location = new System.Drawing.Point(168, 204);
            this.birimfiyat.Name = "birimfiyat";
            this.birimfiyat.Size = new System.Drawing.Size(175, 20);
            this.birimfiyat.TabIndex = 4;
            this.birimfiyat.Text = "Satmak istediğiniz birim fiyatı giriniz";
            this.birimfiyat.Enter += new System.EventHandler(this.birimfiyat_Enter);
            this.birimfiyat.Leave += new System.EventHandler(this.birimfiyat_Leave);
            // 
            // birimfiyat_lbl
            // 
            this.birimfiyat_lbl.AutoSize = true;
            this.birimfiyat_lbl.BackColor = System.Drawing.Color.Transparent;
            this.birimfiyat_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimfiyat_lbl.Location = new System.Drawing.Point(165, 173);
            this.birimfiyat_lbl.Name = "birimfiyat_lbl";
            this.birimfiyat_lbl.Size = new System.Drawing.Size(146, 16);
            this.birimfiyat_lbl.TabIndex = 3;
            this.birimfiyat_lbl.Text = "Birim Fiyat Belirleyiniz";
            // 
            // cikissatisekle
            // 
            this.cikissatisekle.BackColor = System.Drawing.Color.Transparent;
            this.cikissatisekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikissatisekle.FlatAppearance.BorderSize = 0;
            this.cikissatisekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikissatisekle.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikissatisekle.ForeColor = System.Drawing.Color.Brown;
            this.cikissatisekle.Location = new System.Drawing.Point(370, -2);
            this.cikissatisekle.Name = "cikissatisekle";
            this.cikissatisekle.Size = new System.Drawing.Size(32, 36);
            this.cikissatisekle.TabIndex = 8;
            this.cikissatisekle.Text = "X";
            this.cikissatisekle.UseVisualStyleBackColor = false;
            this.cikissatisekle.Click += new System.EventHandler(this.cikisparaekle_Click);
            // 
            // satis_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.cikissatisekle);
            this.Controls.Add(this.birimfiyat);
            this.Controls.Add(this.birimfiyat_lbl);
            this.Controls.Add(this.onay_btn);
            this.Controls.Add(this.birimdeger);
            this.Controls.Add(this.birimdeger_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "satis_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şatış Yap";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label birimdeger_lbl;
        private System.Windows.Forms.TextBox birimdeger;
        private System.Windows.Forms.Button onay_btn;
        private System.Windows.Forms.TextBox birimfiyat;
        private System.Windows.Forms.Label birimfiyat_lbl;
        private System.Windows.Forms.Button cikissatisekle;
    }
}