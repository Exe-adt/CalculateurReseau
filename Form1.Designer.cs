namespace CalculateurMasque
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label1 = new Label();
            txtOct1 = new TextBox();
            txtOct2 = new TextBox();
            txtOct3 = new TextBox();
            txtOct4 = new TextBox();
            txtBin1 = new TextBox();
            txtBin2 = new TextBox();
            txtBin3 = new TextBox();
            txtBin4 = new TextBox();
            label3 = new Label();
            txtCIDR = new TextBox();
            label4 = new Label();
            txtMask1 = new TextBox();
            txtMask2 = new TextBox();
            txtMask3 = new TextBox();
            txtMask4 = new TextBox();
            btnCalculer = new Button();
            label5 = new Label();
            txtClasse1 = new TextBox();
            label6 = new Label();
            txtNet1 = new TextBox();
            txtNet2 = new TextBox();
            txtNet3 = new TextBox();
            txtNet4 = new TextBox();
            label7 = new Label();
            txtBcast1 = new TextBox();
            txtBcast2 = new TextBox();
            txtBcast3 = new TextBox();
            txtBcast4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtPre1 = new TextBox();
            txtPre2 = new TextBox();
            txtPre3 = new TextBox();
            txtPre4 = new TextBox();
            txtDer1 = new TextBox();
            txtDer2 = new TextBox();
            txtDer3 = new TextBox();
            txtDer4 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtNbIP = new TextBox();
            label12 = new Label();
            txtNbMachines = new TextBox();
            btnVider = new Button();
            label2 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            Label1.Location = new Point(80, 83);
            Label1.Name = "Label1";
            Label1.Size = new Size(272, 25);
            Label1.TabIndex = 0;
            Label1.Text = "Adresse IP (Décimal ou Binaire)";
            // 
            // txtOct1
            // 
            txtOct1.BackColor = SystemColors.ControlLight;
            txtOct1.BorderStyle = BorderStyle.FixedSingle;
            txtOct1.Location = new Point(80, 111);
            txtOct1.MaxLength = 3;
            txtOct1.Name = "txtOct1";
            txtOct1.Size = new Size(60, 27);
            txtOct1.TabIndex = 1;
            txtOct1.TextChanged += txtOct_TextChanged;
            // 
            // txtOct2
            // 
            txtOct2.BackColor = SystemColors.ControlLight;
            txtOct2.BorderStyle = BorderStyle.FixedSingle;
            txtOct2.Location = new Point(146, 111);
            txtOct2.MaxLength = 3;
            txtOct2.Name = "txtOct2";
            txtOct2.Size = new Size(60, 27);
            txtOct2.TabIndex = 2;
            txtOct2.TextChanged += txtOct_TextChanged;
            // 
            // txtOct3
            // 
            txtOct3.BackColor = SystemColors.ControlLight;
            txtOct3.BorderStyle = BorderStyle.FixedSingle;
            txtOct3.Location = new Point(212, 111);
            txtOct3.MaxLength = 3;
            txtOct3.Name = "txtOct3";
            txtOct3.Size = new Size(60, 27);
            txtOct3.TabIndex = 3;
            txtOct3.TextChanged += txtOct_TextChanged;
            // 
            // txtOct4
            // 
            txtOct4.BackColor = SystemColors.ControlLight;
            txtOct4.BorderStyle = BorderStyle.FixedSingle;
            txtOct4.Location = new Point(278, 111);
            txtOct4.MaxLength = 3;
            txtOct4.Name = "txtOct4";
            txtOct4.Size = new Size(60, 27);
            txtOct4.TabIndex = 4;
            txtOct4.TextChanged += txtOct_TextChanged;
            // 
            // txtBin1
            // 
            txtBin1.BackColor = Color.LightSteelBlue;
            txtBin1.Location = new Point(247, 830);
            txtBin1.Name = "txtBin1";
            txtBin1.ReadOnly = true;
            txtBin1.Size = new Size(75, 27);
            txtBin1.TabIndex = 6;
            txtBin1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBin2
            // 
            txtBin2.BackColor = Color.LightSteelBlue;
            txtBin2.Location = new Point(332, 830);
            txtBin2.Name = "txtBin2";
            txtBin2.ReadOnly = true;
            txtBin2.Size = new Size(75, 27);
            txtBin2.TabIndex = 7;
            txtBin2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBin3
            // 
            txtBin3.BackColor = Color.LightSteelBlue;
            txtBin3.Location = new Point(417, 830);
            txtBin3.Name = "txtBin3";
            txtBin3.ReadOnly = true;
            txtBin3.Size = new Size(75, 27);
            txtBin3.TabIndex = 8;
            txtBin3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBin4
            // 
            txtBin4.BackColor = Color.LightSteelBlue;
            txtBin4.Location = new Point(502, 830);
            txtBin4.Name = "txtBin4";
            txtBin4.ReadOnly = true;
            txtBin4.Size = new Size(75, 27);
            txtBin4.TabIndex = 9;
            txtBin4.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(415, 83);
            label3.Name = "label3";
            label3.Size = new Size(277, 25);
            label3.TabIndex = 10;
            label3.Text = "Sous-réseau (CIDR ou Standard)";
            // 
            // txtCIDR
            // 
            txtCIDR.BackColor = SystemColors.ControlLight;
            txtCIDR.BorderStyle = BorderStyle.FixedSingle;
            txtCIDR.Location = new Point(415, 111);
            txtCIDR.MaxLength = 2;
            txtCIDR.Name = "txtCIDR";
            txtCIDR.Size = new Size(40, 27);
            txtCIDR.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(461, 113);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 14;
            label4.Text = "ou";
            // 
            // txtMask1
            // 
            txtMask1.BackColor = SystemColors.ControlLight;
            txtMask1.BorderStyle = BorderStyle.FixedSingle;
            txtMask1.Location = new Point(502, 111);
            txtMask1.MaxLength = 3;
            txtMask1.Name = "txtMask1";
            txtMask1.Size = new Size(60, 27);
            txtMask1.TabIndex = 15;
            txtMask1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMask2
            // 
            txtMask2.BackColor = SystemColors.ControlLight;
            txtMask2.BorderStyle = BorderStyle.FixedSingle;
            txtMask2.Location = new Point(568, 111);
            txtMask2.Name = "txtMask2";
            txtMask2.Size = new Size(60, 27);
            txtMask2.TabIndex = 16;
            txtMask2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMask3
            // 
            txtMask3.BackColor = SystemColors.ControlLight;
            txtMask3.BorderStyle = BorderStyle.FixedSingle;
            txtMask3.Location = new Point(634, 111);
            txtMask3.Name = "txtMask3";
            txtMask3.Size = new Size(60, 27);
            txtMask3.TabIndex = 17;
            txtMask3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMask4
            // 
            txtMask4.BackColor = SystemColors.ControlLight;
            txtMask4.BorderStyle = BorderStyle.FixedSingle;
            txtMask4.Location = new Point(700, 111);
            txtMask4.Name = "txtMask4";
            txtMask4.Size = new Size(60, 27);
            txtMask4.TabIndex = 18;
            txtMask4.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculer
            // 
            btnCalculer.BackColor = Color.Silver;
            btnCalculer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculer.Location = new Point(280, 172);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(100, 35);
            btnCalculer.TabIndex = 19;
            btnCalculer.Text = "Calcul";
            btnCalculer.UseVisualStyleBackColor = false;
            btnCalculer.Click += btnCalculer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.Location = new Point(144, 288);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 20;
            label5.Text = "Classe IP";
            // 
            // txtClasse1
            // 
            txtClasse1.BackColor = SystemColors.ControlLight;
            txtClasse1.BorderStyle = BorderStyle.FixedSingle;
            txtClasse1.Location = new Point(161, 318);
            txtClasse1.Name = "txtClasse1";
            txtClasse1.ReadOnly = true;
            txtClasse1.TextAlign = HorizontalAlignment.Center;
            txtClasse1.Size = new Size(40, 27);
            txtClasse1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.Location = new Point(89, 415);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 22;
            label6.Text = "Adresse Net";
            // 
            // txtNet1
            // 
            txtNet1.BackColor = SystemColors.ControlLight;
            txtNet1.BorderStyle = BorderStyle.FixedSingle;
            txtNet1.Location = new Point(89, 452);
            txtNet1.Name = "txtNet1";
            txtNet1.ReadOnly = true;
            txtNet1.Size = new Size(60, 27);
            txtNet1.TabIndex = 23;
            // 
            // txtNet2
            // 
            txtNet2.BackColor = SystemColors.ControlLight;
            txtNet2.BorderStyle = BorderStyle.FixedSingle;
            txtNet2.Location = new Point(155, 452);
            txtNet2.Name = "txtNet2";
            txtNet2.ReadOnly = true;
            txtNet2.Size = new Size(60, 27);
            txtNet2.TabIndex = 24;
            // 
            // txtNet3
            // 
            txtNet3.BackColor = SystemColors.ControlLight;
            txtNet3.BorderStyle = BorderStyle.FixedSingle;
            txtNet3.Location = new Point(221, 452);
            txtNet3.Name = "txtNet3";
            txtNet3.ReadOnly = true;
            txtNet3.Size = new Size(60, 27);
            txtNet3.TabIndex = 25;
            // 
            // txtNet4
            // 
            txtNet4.BackColor = SystemColors.ControlLight;
            txtNet4.BorderStyle = BorderStyle.FixedSingle;
            txtNet4.Location = new Point(288, 452);
            txtNet4.Name = "txtNet4";
            txtNet4.ReadOnly = true;
            txtNet4.Size = new Size(60, 27);
            txtNet4.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label7.Location = new Point(461, 415);
            label7.Name = "label7";
            label7.Size = new Size(164, 25);
            label7.TabIndex = 27;
            label7.Text = "Adresse Broadcast";
            // 
            // txtBcast1
            // 
            txtBcast1.BackColor = SystemColors.ControlLight;
            txtBcast1.BorderStyle = BorderStyle.FixedSingle;
            txtBcast1.Location = new Point(465, 452);
            txtBcast1.Name = "txtBcast1";
            txtBcast1.ReadOnly = true;
            txtBcast1.Size = new Size(60, 27);
            txtBcast1.TabIndex = 28;
            // 
            // txtBcast2
            // 
            txtBcast2.BackColor = SystemColors.ControlLight;
            txtBcast2.BorderStyle = BorderStyle.FixedSingle;
            txtBcast2.Location = new Point(531, 452);
            txtBcast2.Name = "txtBcast2";
            txtBcast2.ReadOnly = true;
            txtBcast2.Size = new Size(60, 27);
            txtBcast2.TabIndex = 29;
            // 
            // txtBcast3
            // 
            txtBcast3.BackColor = SystemColors.ControlLight;
            txtBcast3.BorderStyle = BorderStyle.FixedSingle;
            txtBcast3.Location = new Point(597, 452);
            txtBcast3.Name = "txtBcast3";
            txtBcast3.ReadOnly = true;
            txtBcast3.Size = new Size(60, 27);
            txtBcast3.TabIndex = 30;
            // 
            // txtBcast4
            // 
            txtBcast4.BackColor = SystemColors.ControlLight;
            txtBcast4.BorderStyle = BorderStyle.FixedSingle;
            txtBcast4.Location = new Point(663, 452);
            txtBcast4.Name = "txtBcast4";
            txtBcast4.ReadOnly = true;
            txtBcast4.Size = new Size(60, 27);
            txtBcast4.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(89, 497);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 32;
            label8.Text = "Première IP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(461, 497);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 33;
            label9.Text = "Dernière IP";
            // 
            // txtPre1
            // 
            txtPre1.BackColor = SystemColors.ControlLight;
            txtPre1.BorderStyle = BorderStyle.FixedSingle;
            txtPre1.Location = new Point(89, 536);
            txtPre1.Name = "txtPre1";
            txtPre1.ReadOnly = true;
            txtPre1.Size = new Size(60, 27);
            txtPre1.TabIndex = 34;
            // 
            // txtPre2
            // 
            txtPre2.BackColor = SystemColors.ControlLight;
            txtPre2.BorderStyle = BorderStyle.FixedSingle;
            txtPre2.Location = new Point(159, 536);
            txtPre2.Name = "txtPre2";
            txtPre2.ReadOnly = true;
            txtPre2.Size = new Size(60, 27);
            txtPre2.TabIndex = 35;
            // 
            // txtPre3
            // 
            txtPre3.BackColor = SystemColors.ControlLight;
            txtPre3.BorderStyle = BorderStyle.FixedSingle;
            txtPre3.Location = new Point(229, 536);
            txtPre3.Name = "txtPre3";
            txtPre3.ReadOnly = true;
            txtPre3.Size = new Size(60, 27);
            txtPre3.TabIndex = 36;
            // 
            // txtPre4
            // 
            txtPre4.BackColor = SystemColors.ControlLight;
            txtPre4.BorderStyle = BorderStyle.FixedSingle;
            txtPre4.Location = new Point(299, 536);
            txtPre4.Name = "txtPre4";
            txtPre4.ReadOnly = true;
            txtPre4.Size = new Size(60, 27);
            txtPre4.TabIndex = 37;
            // 
            // txtDer1
            // 
            txtDer1.BackColor = SystemColors.ControlLight;
            txtDer1.BorderStyle = BorderStyle.FixedSingle;
            txtDer1.Location = new Point(465, 536);
            txtDer1.Name = "txtDer1";
            txtDer1.ReadOnly = true;
            txtDer1.Size = new Size(60, 27);
            txtDer1.TabIndex = 38;
            // 
            // txtDer2
            // 
            txtDer2.BackColor = SystemColors.ControlLight;
            txtDer2.BorderStyle = BorderStyle.FixedSingle;
            txtDer2.Location = new Point(531, 536);
            txtDer2.Name = "txtDer2";
            txtDer2.ReadOnly = true;
            txtDer2.Size = new Size(60, 27);
            txtDer2.TabIndex = 39;
            // 
            // txtDer3
            // 
            txtDer3.BackColor = SystemColors.ControlLight;
            txtDer3.BorderStyle = BorderStyle.FixedSingle;
            txtDer3.Location = new Point(597, 536);
            txtDer3.Name = "txtDer3";
            txtDer3.ReadOnly = true;
            txtDer3.Size = new Size(60, 27);
            txtDer3.TabIndex = 40;
            // 
            // txtDer4
            // 
            txtDer4.BackColor = SystemColors.ControlLight;
            txtDer4.BorderStyle = BorderStyle.FixedSingle;
            txtDer4.Location = new Point(663, 536);
            txtDer4.Name = "txtDer4";
            txtDer4.ReadOnly = true;
            txtDer4.Size = new Size(60, 27);
            txtDer4.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label11.Location = new Point(165, 669);
            label11.Name = "label11";
            label11.Size = new Size(66, 25);
            label11.TabIndex = 43;
            label11.Text = "Nb IPs";
            // 
            // txtNbIP
            // 
            txtNbIP.BackColor = SystemColors.ControlLight;
            txtNbIP.BorderStyle = BorderStyle.FixedSingle;
            txtNbIP.Location = new Point(237, 667);
            txtNbIP.Name = "txtNbIP";
            txtNbIP.ReadOnly = true;
            txtNbIP.Size = new Size(120, 27);
            txtNbIP.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(502, 669);
            label12.Name = "label12";
            label12.Size = new Size(120, 25);
            label12.TabIndex = 45;
            label12.Text = "Nb Machines";
            // 
            // txtNbMachines
            // 
            txtNbMachines.BackColor = SystemColors.ControlLight;
            txtNbMachines.BorderStyle = BorderStyle.FixedSingle;
            txtNbMachines.Location = new Point(628, 669);
            txtNbMachines.Name = "txtNbMachines";
            txtNbMachines.ReadOnly = true;
            txtNbMachines.Size = new Size(120, 27);
            txtNbMachines.TabIndex = 46;
            // 
            // btnVider
            // 
            btnVider.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVider.Location = new Point(451, 172);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(100, 35);
            btnVider.TabIndex = 47;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = true;
            btnVider.Click += btnVider_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(280, 22);
            label2.Name = "label2";
            label2.Size = new Size(245, 31);
            label2.TabIndex = 48;
            label2.Text = "Calculteur de Masque";
            // 
            // label13
            // 
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(48, 244);
            label13.Name = "label13";
            label13.Size = new Size(700, 30);
            label13.TabIndex = 49;
            label13.Text = "Resultat";
            // 
            // label14
            // 
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(48, 368);
            label14.Name = "label14";
            label14.Size = new Size(700, 30);
            label14.TabIndex = 50;
            label14.Text = "Réseau";
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(48, 594);
            label15.Name = "label15";
            label15.Size = new Size(700, 30);
            label15.TabIndex = 51;
            label15.Text = "Réseau";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label16.Location = new Point(336, 288);
            label16.Name = "label16";
            label16.Size = new Size(135, 25);
            label16.TabIndex = 52;
            label16.Text = "Masque (CIDR)";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label17.Location = new Point(556, 288);
            label17.Name = "label17";
            label17.Size = new Size(153, 25);
            label17.TabIndex = 53;
            label17.Text = "Masque (Binaire)";
            label17.Click += label17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(795, 869);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(btnVider);
            Controls.Add(txtNbMachines);
            Controls.Add(label12);
            Controls.Add(txtNbIP);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtDer4);
            Controls.Add(txtDer3);
            Controls.Add(txtDer2);
            Controls.Add(txtDer1);
            Controls.Add(txtPre4);
            Controls.Add(txtPre3);
            Controls.Add(txtPre2);
            Controls.Add(txtPre1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtBcast4);
            Controls.Add(txtBcast3);
            Controls.Add(txtBcast2);
            Controls.Add(txtBcast1);
            Controls.Add(label7);
            Controls.Add(txtNet4);
            Controls.Add(txtNet3);
            Controls.Add(txtNet2);
            Controls.Add(txtNet1);
            Controls.Add(label6);
            Controls.Add(txtClasse1);
            Controls.Add(label5);
            Controls.Add(btnCalculer);
            Controls.Add(txtMask4);
            Controls.Add(txtMask3);
            Controls.Add(txtMask2);
            Controls.Add(txtMask1);
            Controls.Add(label4);
            Controls.Add(txtCIDR);
            Controls.Add(label3);
            Controls.Add(txtBin4);
            Controls.Add(txtBin3);
            Controls.Add(txtBin2);
            Controls.Add(txtBin1);
            Controls.Add(txtOct4);
            Controls.Add(txtOct3);
            Controls.Add(txtOct2);
            Controls.Add(txtOct1);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculateur de Masque Réseau";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private TextBox txtOct1;
        private TextBox txtOct2;
        private TextBox txtOct3;
        private TextBox txtOct4;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        private TextBox txtBin1;
        private TextBox txtBin2;
        private TextBox txtBin3;
        private TextBox txtBin4;
        private Label label3;
        private TextBox txtCIDR;
        private Label label4;
        private TextBox txtMask1;
        private TextBox txtMask2;
        private TextBox txtMask3;
        private TextBox txtMask4;
        private Button btnCalculer;
        private Label label5;
        private TextBox txtClasse1;
        private Label label6;
        private TextBox txtNet1;
        private TextBox txtNet2;
        private TextBox txtNet3;
        private TextBox txtNet4;
        private Label label7;
        private TextBox txtBcast1;
        private TextBox txtBcast2;
        private TextBox txtBcast3;
        private TextBox txtBcast4;
        private Label label8;
        private Label label9;
        private TextBox txtPre1;
        private TextBox txtPre2;
        private TextBox txtPre3;
        private TextBox txtPre4;
        private TextBox txtDer1;
        private TextBox txtDer2;
        private TextBox txtDer3;
        private TextBox txtDer4;
        private Label label10;
        private Label label11;
        private TextBox txtNbIP;
        private Label label12;
        private TextBox txtNbMachines;
        private Button btnVider;
        private Label label2;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}
