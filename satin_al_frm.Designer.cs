﻿namespace Proje_Ödevi
{
    partial class satin_al_frm
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
        /// Required method for Designer support - do
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satin_al_frm));
            this.filtre_lbl = new System.Windows.Forms.Label();
            this.urunlersatinal = new System.Windows.Forms.DataGridView();
            this.filtre_cmbx = new System.Windows.Forms.ComboBox();
            this.urunler_lbl = new System.Windows.Forms.Label();
            this.satın_al_btn = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.birim = new System.Windows.Forms.TextBox();
            this.kacbirim_lbl = new System.Windows.Forms.Label();
            this.tl_lbl = new System.Windows.Forms.Label();
            this.lbl_para = new System.Windows.Forms.Label();
            this.cikissatinal = new System.Windows.Forms.Button();
            this.satin_al_piyasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urunlersatinal)).BeginInit();
            this.SuspendLayout();
            // 
            // filtre_lbl
            // 
            this.filtre_lbl.AutoSize = true;
            this.filtre_lbl.BackColor = System.Drawing.Color.Transparent;
            this.filtre_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.filtre_lbl.Location = new System.Drawing.Point(556, 25);
            this.filtre_lbl.Name = "filtre_lbl";
            this.filtre_lbl.Size = new System.Drawing.Size(67, 23);
            this.filtre_lbl.TabIndex = 20;
            this.filtre_lbl.Text = "Filtre:";
            // 
            // urunlersatinal
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.urunlersatinal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.urunlersatinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunlersatinal.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunlersatinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.urunlersatinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.urunlersatinal.DefaultCellStyle = dataGridViewCellStyle3;
            this.urunlersatinal.GridColor = System.Drawing.Color.Black;
            this.urunlersatinal.Location = new System.Drawing.Point(25, 67);
            this.urunlersatinal.Name = "urunlersatinal";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunlersatinal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.urunlersatinal.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.urunlersatinal.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.urunlersatinal.Size = new System.Drawing.Size(742, 325);
            this.urunlersatinal.TabIndex = 19;
            // 
            // filtre_cmbx
            // 
            this.filtre_cmbx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filtre_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtre_cmbx.FormattingEnabled = true;
            this.filtre_cmbx.Location = new System.Drawing.Point(624, 26);
            this.filtre_cmbx.Name = "filtre_cmbx";
            this.filtre_cmbx.Size = new System.Drawing.Size(142, 21);
            this.filtre_cmbx.TabIndex = 18;
            this.filtre_cmbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // urunler_lbl
            // 
            this.urunler_lbl.AutoSize = true;
            this.urunler_lbl.BackColor = System.Drawing.Color.Transparent;
            this.urunler_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.urunler_lbl.Location = new System.Drawing.Point(26, 22);
            this.urunler_lbl.Name = "urunler_lbl";
            this.urunler_lbl.Size = new System.Drawing.Size(88, 23);
            this.urunler_lbl.TabIndex = 17;
            this.urunler_lbl.Text = "Ürünler:";
            // 
            // satın_al_btn
            // 
            this.satın_al_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satın_al_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.satın_al_btn.Location = new System.Drawing.Point(231, 528);
            this.satın_al_btn.Name = "satın_al_btn";
            this.satın_al_btn.Size = new System.Drawing.Size(158, 37);
            this.satın_al_btn.TabIndex = 15;
            this.satın_al_btn.Text = "Piyasadan Al";
            this.satın_al_btn.UseVisualStyleBackColor = false;
            this.satın_al_btn.Click += new System.EventHandler(this.satın_al_btn_Click);
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.geri_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.geri_btn.Location = new System.Drawing.Point(650, 528);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(117, 37);
            this.geri_btn.TabIndex = 14;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // birim
            // 
            this.birim.ForeColor = System.Drawing.Color.Silver;
            this.birim.Location = new System.Drawing.Point(300, 479);
            this.birim.Name = "birim";
            this.birim.Size = new System.Drawing.Size(212, 20);
            this.birim.TabIndex = 21;
            this.birim.Text = "Lütfen birim giriniz";
            this.birim.Enter += new System.EventHandler(this.birim_Enter);
            this.birim.Leave += new System.EventHandler(this.birim_Leave);
            // 
            // kacbirim_lbl
            // 
            this.kacbirim_lbl.AutoSize = true;
            this.kacbirim_lbl.BackColor = System.Drawing.Color.Transparent;
            this.kacbirim_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.kacbirim_lbl.Location = new System.Drawing.Point(260, 439);
            this.kacbirim_lbl.Name = "kacbirim_lbl";
            this.kacbirim_lbl.Size = new System.Drawing.Size(297, 23);
            this.kacbirim_lbl.TabIndex = 22;
            this.kacbirim_lbl.Text = "Kaç birim almak istiyorsunuz?";
            // 
            // tl_lbl
            // 
            this.tl_lbl.AutoSize = true;
            this.tl_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tl_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tl_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tl_lbl.Location = new System.Drawing.Point(31, 534);
            this.tl_lbl.Name = "tl_lbl";
            this.tl_lbl.Size = new System.Drawing.Size(25, 25);
            this.tl_lbl.TabIndex = 24;
            this.tl_lbl.Text = "₺";
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.BackColor = System.Drawing.Color.Transparent;
            this.lbl_para.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_para.ForeColor = System.Drawing.Color.White;
            this.lbl_para.Location = new System.Drawing.Point(59, 535);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(52, 23);
            this.lbl_para.TabIndex = 23;
            this.lbl_para.Text = "Para";
            // 
            // cikissatinal
            // 
            this.cikissatinal.BackColor = System.Drawing.Color.Transparent;
            this.cikissatinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikissatinal.FlatAppearance.BorderSize = 0;
            this.cikissatinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikissatinal.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikissatinal.ForeColor = System.Drawing.Color.Brown;
            this.cikissatinal.Location = new System.Drawing.Point(772, -4);
            this.cikissatinal.Name = "cikissatinal";
            this.cikissatinal.Size = new System.Drawing.Size(32, 36);
            this.cikissatinal.TabIndex = 25;
            this.cikissatinal.Text = "X";
            this.cikissatinal.UseVisualStyleBackColor = false;
            this.cikissatinal.Click += new System.EventHandler(this.cikisanasayfa_Click);
            // 
            // satin_al_piyasa
            // 
            this.satin_al_piyasa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satin_al_piyasa.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.satin_al_piyasa.Location = new System.Drawing.Point(418, 528);
            this.satin_al_piyasa.Name = "satin_al_piyasa";
            this.satin_al_piyasa.Size = new System.Drawing.Size(158, 37);
            this.satin_al_piyasa.TabIndex = 26;
            this.satin_al_piyasa.Text = "Fiyat Belirle";
            this.satin_al_piyasa.UseVisualStyleBackColor = false;
            this.satin_al_piyasa.Click += new System.EventHandler(this.satin_al_piyasa_Click);
            // 
            // satin_al_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.satin_al_piyasa);
            this.Controls.Add(this.cikissatinal);
            this.Controls.Add(this.tl_lbl);
            this.Controls.Add(this.lbl_para);
            this.Controls.Add(this.kacbirim_lbl);
            this.Controls.Add(this.birim);
            this.Controls.Add(this.filtre_lbl);
            this.Controls.Add(this.urunlersatinal);
            this.Controls.Add(this.filtre_cmbx);
            this.Controls.Add(this.urunler_lbl);
            this.Controls.Add(this.satın_al_btn);
            this.Controls.Add(this.geri_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "satin_al_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Al";
            this.Load += new System.EventHandler(this.satin_al_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlersatinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filtre_lbl;
        private System.Windows.Forms.DataGridView urunlersatinal;
        private System.Windows.Forms.ComboBox filtre_cmbx;
        private System.Windows.Forms.Label urunler_lbl;
        private System.Windows.Forms.Button satın_al_btn;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.TextBox birim;
        private System.Windows.Forms.Label kacbirim_lbl;
        private System.Windows.Forms.Label tl_lbl;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Button cikissatinal;
        private System.Windows.Forms.Button satin_al_piyasa;
    }
}