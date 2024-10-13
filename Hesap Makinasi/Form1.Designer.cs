using System;
using System.Windows.Forms;

namespace Hesap_Makinasi
{
    partial class HesapMakinesi
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
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.lblMC = new System.Windows.Forms.Label();
            this.lblMR = new System.Windows.Forms.Label();
            this.lblM_arti = new System.Windows.Forms.Label();
            this.lblM_eksi = new System.Windows.Forms.Label();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.lbl_KompleSil = new System.Windows.Forms.Label();
            this.lbl_EkraniSil = new System.Windows.Forms.Label();
            this.lbl_GeriAl = new System.Windows.Forms.Label();
            this.lbl_Bol = new System.Windows.Forms.Label();
            this.lbl_KareKokAl = new System.Windows.Forms.Label();
            this.lbl_Karesi = new System.Windows.Forms.Label();
            this.lbl_1_bol = new System.Windows.Forms.Label();
            this.lbl_Carp = new System.Windows.Forms.Label();
            this.lbl_9 = new System.Windows.Forms.Label();
            this.lbl_8 = new System.Windows.Forms.Label();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.lbl_Cikar = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_Topla = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_Esittir = new System.Windows.Forms.Label();
            this.lbl_Nokta = new System.Windows.Forms.Label();
            this.lbl_0 = new System.Windows.Forms.Label();
            this.lbl_IsaretDegistir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScreen
            // 
            this.txtScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScreen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtScreen.Location = new System.Drawing.Point(16, 40);
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScreen.Size = new System.Drawing.Size(261, 35);
            this.txtScreen.TabIndex = 0;
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMC
            // 
            this.lblMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMC.Location = new System.Drawing.Point(16, 116);
            this.lblMC.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(37, 25);
            this.lblMC.TabIndex = 1;
            this.lblMC.Text = "MC";
            this.lblMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblMC_MouseClick);
            // 
            // lblMR
            // 
            this.lblMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMR.Location = new System.Drawing.Point(69, 116);
            this.lblMR.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(38, 25);
            this.lblMR.TabIndex = 2;
            this.lblMR.Text = "MR";
            this.lblMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblMR_MouseClick);
            // 
            // lblM_arti
            // 
            this.lblM_arti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblM_arti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblM_arti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblM_arti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblM_arti.Location = new System.Drawing.Point(123, 116);
            this.lblM_arti.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblM_arti.Name = "lblM_arti";
            this.lblM_arti.Size = new System.Drawing.Size(36, 25);
            this.lblM_arti.TabIndex = 3;
            this.lblM_arti.Text = "M+";
            this.lblM_arti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblM_arti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblM_arti_MouseClick);
            // 
            // lblM_eksi
            // 
            this.lblM_eksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblM_eksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblM_eksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblM_eksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblM_eksi.Location = new System.Drawing.Point(175, 116);
            this.lblM_eksi.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblM_eksi.Name = "lblM_eksi";
            this.lblM_eksi.Size = new System.Drawing.Size(33, 25);
            this.lblM_eksi.TabIndex = 4;
            this.lblM_eksi.Text = "M-";
            this.lblM_eksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblM_eksi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblM_eksi_MouseClick);
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.BackColor = System.Drawing.Color.Blue;
            this.lbl_Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Percent.ForeColor = System.Drawing.Color.White;
            this.lbl_Percent.Location = new System.Drawing.Point(15, 153);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(61, 32);
            this.lbl_Percent.TabIndex = 6;
            this.lbl_Percent.Text = "%";
            this.lbl_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Percent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Percent_MouseClick);
            // 
            // lbl_KompleSil
            // 
            this.lbl_KompleSil.BackColor = System.Drawing.Color.Blue;
            this.lbl_KompleSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_KompleSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_KompleSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_KompleSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KompleSil.ForeColor = System.Drawing.Color.White;
            this.lbl_KompleSil.Location = new System.Drawing.Point(82, 153);
            this.lbl_KompleSil.Name = "lbl_KompleSil";
            this.lbl_KompleSil.Size = new System.Drawing.Size(61, 32);
            this.lbl_KompleSil.TabIndex = 7;
            this.lbl_KompleSil.Text = "CE";
            this.lbl_KompleSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_KompleSil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_KompleSil_MouseClick);
            // 
            // lbl_EkraniSil
            // 
            this.lbl_EkraniSil.BackColor = System.Drawing.Color.Blue;
            this.lbl_EkraniSil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_EkraniSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_EkraniSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_EkraniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_EkraniSil.ForeColor = System.Drawing.Color.White;
            this.lbl_EkraniSil.Location = new System.Drawing.Point(149, 153);
            this.lbl_EkraniSil.Name = "lbl_EkraniSil";
            this.lbl_EkraniSil.Size = new System.Drawing.Size(61, 32);
            this.lbl_EkraniSil.TabIndex = 8;
            this.lbl_EkraniSil.Text = "C";
            this.lbl_EkraniSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_EkraniSil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_EkraniSil_MouseClick);
            // 
            // lbl_GeriAl
            // 
            this.lbl_GeriAl.BackColor = System.Drawing.Color.Blue;
            this.lbl_GeriAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_GeriAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_GeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_GeriAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GeriAl.ForeColor = System.Drawing.Color.White;
            this.lbl_GeriAl.Location = new System.Drawing.Point(216, 153);
            this.lbl_GeriAl.Name = "lbl_GeriAl";
            this.lbl_GeriAl.Size = new System.Drawing.Size(61, 32);
            this.lbl_GeriAl.TabIndex = 9;
            this.lbl_GeriAl.Text = "<=";
            this.lbl_GeriAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_GeriAl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_GeriAl_MouseClick);
            // 
            // lbl_Bol
            // 
            this.lbl_Bol.BackColor = System.Drawing.Color.Blue;
            this.lbl_Bol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Bol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Bol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Bol.ForeColor = System.Drawing.Color.White;
            this.lbl_Bol.Location = new System.Drawing.Point(217, 195);
            this.lbl_Bol.Name = "lbl_Bol";
            this.lbl_Bol.Size = new System.Drawing.Size(61, 32);
            this.lbl_Bol.TabIndex = 13;
            this.lbl_Bol.Text = "/";
            this.lbl_Bol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Bol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Bol_MouseClick);
            // 
            // lbl_KareKokAl
            // 
            this.lbl_KareKokAl.BackColor = System.Drawing.Color.Blue;
            this.lbl_KareKokAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_KareKokAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_KareKokAl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_KareKokAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KareKokAl.ForeColor = System.Drawing.Color.White;
            this.lbl_KareKokAl.Location = new System.Drawing.Point(150, 195);
            this.lbl_KareKokAl.Name = "lbl_KareKokAl";
            this.lbl_KareKokAl.Size = new System.Drawing.Size(61, 32);
            this.lbl_KareKokAl.TabIndex = 12;
            this.lbl_KareKokAl.Text = "Sqr";
            this.lbl_KareKokAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_KareKokAl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_KareKokAl_MouseClick);
            // 
            // lbl_Karesi
            // 
            this.lbl_Karesi.BackColor = System.Drawing.Color.Blue;
            this.lbl_Karesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Karesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Karesi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Karesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Karesi.ForeColor = System.Drawing.Color.White;
            this.lbl_Karesi.Location = new System.Drawing.Point(83, 195);
            this.lbl_Karesi.Name = "lbl_Karesi";
            this.lbl_Karesi.Size = new System.Drawing.Size(61, 32);
            this.lbl_Karesi.TabIndex = 11;
            this.lbl_Karesi.Text = "X2";
            this.lbl_Karesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Karesi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Karesi_MouseClick);
            // 
            // lbl_1_bol
            // 
            this.lbl_1_bol.BackColor = System.Drawing.Color.Blue;
            this.lbl_1_bol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_1_bol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_1_bol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_1_bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_1_bol.ForeColor = System.Drawing.Color.White;
            this.lbl_1_bol.Location = new System.Drawing.Point(16, 195);
            this.lbl_1_bol.Name = "lbl_1_bol";
            this.lbl_1_bol.Size = new System.Drawing.Size(61, 32);
            this.lbl_1_bol.TabIndex = 10;
            this.lbl_1_bol.Text = "1/x";
            this.lbl_1_bol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_1_bol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_1_bol_MouseClick);
            // 
            // lbl_Carp
            // 
            this.lbl_Carp.BackColor = System.Drawing.Color.Blue;
            this.lbl_Carp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Carp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Carp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Carp.ForeColor = System.Drawing.Color.White;
            this.lbl_Carp.Location = new System.Drawing.Point(217, 237);
            this.lbl_Carp.Name = "lbl_Carp";
            this.lbl_Carp.Size = new System.Drawing.Size(61, 32);
            this.lbl_Carp.TabIndex = 17;
            this.lbl_Carp.Text = "*";
            this.lbl_Carp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Carp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Carp_MouseClick);
            // 
            // lbl_9
            // 
            this.lbl_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_9.ForeColor = System.Drawing.Color.Black;
            this.lbl_9.Location = new System.Drawing.Point(150, 237);
            this.lbl_9.Name = "lbl_9";
            this.lbl_9.Size = new System.Drawing.Size(61, 32);
            this.lbl_9.TabIndex = 16;
            this.lbl_9.Text = "9";
            this.lbl_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_9_MouseClick);
            // 
            // lbl_8
            // 
            this.lbl_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_8.ForeColor = System.Drawing.Color.Black;
            this.lbl_8.Location = new System.Drawing.Point(83, 237);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(61, 32);
            this.lbl_8.TabIndex = 15;
            this.lbl_8.Text = "8";
            this.lbl_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_8_MouseClick);
            // 
            // lbl_7
            // 
            this.lbl_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_7.ForeColor = System.Drawing.Color.Black;
            this.lbl_7.Location = new System.Drawing.Point(16, 237);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(61, 32);
            this.lbl_7.TabIndex = 14;
            this.lbl_7.Text = "7";
            this.lbl_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_7_MouseClick);
            // 
            // lbl_Cikar
            // 
            this.lbl_Cikar.BackColor = System.Drawing.Color.Blue;
            this.lbl_Cikar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Cikar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Cikar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Cikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cikar.ForeColor = System.Drawing.Color.White;
            this.lbl_Cikar.Location = new System.Drawing.Point(217, 278);
            this.lbl_Cikar.Name = "lbl_Cikar";
            this.lbl_Cikar.Size = new System.Drawing.Size(61, 32);
            this.lbl_Cikar.TabIndex = 21;
            this.lbl_Cikar.Text = "-";
            this.lbl_Cikar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Cikar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Cikar_MouseClick);
            // 
            // lbl_6
            // 
            this.lbl_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_6.ForeColor = System.Drawing.Color.Black;
            this.lbl_6.Location = new System.Drawing.Point(150, 278);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(61, 32);
            this.lbl_6.TabIndex = 20;
            this.lbl_6.Text = "6";
            this.lbl_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_6_MouseClick);
            // 
            // lbl_5
            // 
            this.lbl_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_5.ForeColor = System.Drawing.Color.Black;
            this.lbl_5.Location = new System.Drawing.Point(83, 278);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(61, 32);
            this.lbl_5.TabIndex = 19;
            this.lbl_5.Text = "5";
            this.lbl_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_5_MouseClick);
            // 
            // lbl_4
            // 
            this.lbl_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_4.ForeColor = System.Drawing.Color.Black;
            this.lbl_4.Location = new System.Drawing.Point(16, 278);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(61, 32);
            this.lbl_4.TabIndex = 18;
            this.lbl_4.Text = "4";
            this.lbl_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_4_MouseClick);
            // 
            // lbl_Topla
            // 
            this.lbl_Topla.BackColor = System.Drawing.Color.Blue;
            this.lbl_Topla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Topla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Topla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Topla.ForeColor = System.Drawing.Color.White;
            this.lbl_Topla.Location = new System.Drawing.Point(217, 319);
            this.lbl_Topla.Name = "lbl_Topla";
            this.lbl_Topla.Size = new System.Drawing.Size(61, 32);
            this.lbl_Topla.TabIndex = 25;
            this.lbl_Topla.Text = "+";
            this.lbl_Topla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Topla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Topla_MouseClick);
            // 
            // lbl_3
            // 
            this.lbl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_3.ForeColor = System.Drawing.Color.Black;
            this.lbl_3.Location = new System.Drawing.Point(150, 319);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(61, 32);
            this.lbl_3.TabIndex = 24;
            this.lbl_3.Text = "3";
            this.lbl_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_3_MouseClick);
            // 
            // lbl_2
            // 
            this.lbl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_2.ForeColor = System.Drawing.Color.Black;
            this.lbl_2.Location = new System.Drawing.Point(83, 319);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(61, 32);
            this.lbl_2.TabIndex = 23;
            this.lbl_2.Text = "2";
            this.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_2_MouseClick);
            // 
            // lbl_1
            // 
            this.lbl_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_1.ForeColor = System.Drawing.Color.Black;
            this.lbl_1.Location = new System.Drawing.Point(16, 319);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(61, 32);
            this.lbl_1.TabIndex = 22;
            this.lbl_1.Text = "1";
            this.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_1_MouseClick);
            // 
            // lbl_Esittir
            // 
            this.lbl_Esittir.BackColor = System.Drawing.Color.Blue;
            this.lbl_Esittir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Esittir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Esittir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Esittir.ForeColor = System.Drawing.Color.White;
            this.lbl_Esittir.Location = new System.Drawing.Point(217, 361);
            this.lbl_Esittir.Name = "lbl_Esittir";
            this.lbl_Esittir.Size = new System.Drawing.Size(61, 32);
            this.lbl_Esittir.TabIndex = 29;
            this.lbl_Esittir.Text = "=";
            this.lbl_Esittir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Esittir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Esittir_MouseClick);
            // 
            // lbl_Nokta
            // 
            this.lbl_Nokta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_Nokta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Nokta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Nokta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Nokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Nokta.ForeColor = System.Drawing.Color.Black;
            this.lbl_Nokta.Location = new System.Drawing.Point(150, 361);
            this.lbl_Nokta.Name = "lbl_Nokta";
            this.lbl_Nokta.Size = new System.Drawing.Size(61, 32);
            this.lbl_Nokta.TabIndex = 28;
            this.lbl_Nokta.Text = ".";
            this.lbl_Nokta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Nokta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Nokta_MouseClick);
            // 
            // lbl_0
            // 
            this.lbl_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_0.ForeColor = System.Drawing.Color.Black;
            this.lbl_0.Location = new System.Drawing.Point(83, 361);
            this.lbl_0.Name = "lbl_0";
            this.lbl_0.Size = new System.Drawing.Size(61, 32);
            this.lbl_0.TabIndex = 27;
            this.lbl_0.Text = "0";
            this.lbl_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_0_MouseClick);
            // 
            // lbl_IsaretDegistir
            // 
            this.lbl_IsaretDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_IsaretDegistir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_IsaretDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_IsaretDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_IsaretDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_IsaretDegistir.ForeColor = System.Drawing.Color.Black;
            this.lbl_IsaretDegistir.Location = new System.Drawing.Point(16, 361);
            this.lbl_IsaretDegistir.Name = "lbl_IsaretDegistir";
            this.lbl_IsaretDegistir.Size = new System.Drawing.Size(61, 32);
            this.lbl_IsaretDegistir.TabIndex = 26;
            this.lbl_IsaretDegistir.Text = "+/-";
            this.lbl_IsaretDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_IsaretDegistir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_IsaretDegistir_MouseClick);
            // 
            // HesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(293, 420);
            this.Controls.Add(this.lbl_Esittir);
            this.Controls.Add(this.lbl_Nokta);
            this.Controls.Add(this.lbl_0);
            this.Controls.Add(this.lbl_IsaretDegistir);
            this.Controls.Add(this.lbl_Topla);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_Cikar);
            this.Controls.Add(this.lbl_6);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_Carp);
            this.Controls.Add(this.lbl_9);
            this.Controls.Add(this.lbl_8);
            this.Controls.Add(this.lbl_7);
            this.Controls.Add(this.lbl_Bol);
            this.Controls.Add(this.lbl_KareKokAl);
            this.Controls.Add(this.lbl_Karesi);
            this.Controls.Add(this.lbl_1_bol);
            this.Controls.Add(this.lbl_GeriAl);
            this.Controls.Add(this.lbl_EkraniSil);
            this.Controls.Add(this.lbl_KompleSil);
            this.Controls.Add(this.lbl_Percent);
            this.Controls.Add(this.lblM_eksi);
            this.Controls.Add(this.lblM_arti);
            this.Controls.Add(this.lblMR);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.txtScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HesapMakinesi";
            this.Text = "Hesap makinasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label lblMR;
        private System.Windows.Forms.Label lblM_arti;
        private System.Windows.Forms.Label lblM_eksi;
        private System.Windows.Forms.Label lbl_Percent;
        private System.Windows.Forms.Label lbl_KompleSil;
        private System.Windows.Forms.Label lbl_EkraniSil;
        private System.Windows.Forms.Label lbl_GeriAl;
        private System.Windows.Forms.Label lbl_Bol;
        private System.Windows.Forms.Label lbl_KareKokAl;
        private System.Windows.Forms.Label lbl_Karesi;
        private System.Windows.Forms.Label lbl_1_bol;
        private System.Windows.Forms.Label lbl_Carp;
        private System.Windows.Forms.Label lbl_9;
        private System.Windows.Forms.Label lbl_8;
        private System.Windows.Forms.Label lbl_7;
        private System.Windows.Forms.Label lbl_Cikar;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_Topla;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_Esittir;
        private System.Windows.Forms.Label lbl_Nokta;
        private System.Windows.Forms.Label lbl_0;
        private System.Windows.Forms.Label lbl_IsaretDegistir;
    }
}

