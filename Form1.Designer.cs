using System.Diagnostics;

namespace CalculateurMasque
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class Form1
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
            label2 = new Label();
            txtBin1 = new TextBox();
            txtBin2 = new TextBox();
            txtBin3 = new TextBox();
            txtBin4 = new TextBox();
            label3 = new Label();
            lblCIDR = new Label();
            lblStandard = new Label();
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
            txtFirst1 = new TextBox();
            txtFirst2 = new TextBox();
            txtFirst3 = new TextBox();
            txtFirst4 = new TextBox();
            txtLast1 = new TextBox();
            txtLast2 = new TextBox();
            txtLast3 = new TextBox();
            txtLast4 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtNbIP = new TextBox();
            label12 = new Label();
            txtNbMachines = new TextBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(20, 20);
            Label1.Name = "Label1";
            Label1.Size = new Size(46, 20);
            Label1.TabIndex = 0;
            Label1.Text = "(dec.)";
            // 
            // txtOct1
            // 
            txtOct1.Location = new Point(94, 17);
            txtOct1.MaxLength = 3;
            txtOct1.Name = "txtOct1";
            txtOct1.Size = new Size(60, 27);
            txtOct1.TabIndex = 1;
            txtOct1.TextChanged += txtOct_TextChanged;
            // 
            // txtOct2
            // 
            txtOct2.Location = new Point(160, 17);
            txtOct2.MaxLength = 3;
            txtOct2.Name = "txtOct2";
            txtOct2.Size = new Size(60, 27);
            txtOct2.TabIndex = 2;
            txtOct2.TextChanged += txtOct_TextChanged;
            // 
            // txtOct3
            // 
            txtOct3.Location = new Point(226, 17);
            txtOct3.MaxLength = 3;
            txtOct3.Name = "txtOct3";
            txtOct3.Size = new Size(60, 27);
            txtOct3.TabIndex = 3;
            txtOct3.TextChanged += txtOct_TextChanged;
            // 
            // txtOct4
            // 
            txtOct4.Location = new Point(292, 19);
            txtOct4.MaxLength = 3;
            txtOct4.Name = "txtOct4";
            txtOct4.Size = new Size(60, 27);
            txtOct4.TabIndex = 4;
            txtOct4.TextChanged += txtOct_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "(binaire)";
            // 
            // txtBin1
            // 
            txtBin1.BackColor = Color.LightSteelBlue;
            txtBin1.Location = new Point(90, 52);
            txtBin1.Name = "txtBin1";
            txtBin1.ReadOnly = true;
            txtBin1.Size = new Size(75, 27);
            txtBin1.TabIndex = 6;
            txtBin1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBin2
            // 
            txtBin2.BackColor = Color.LightSteelBlue;
            txtBin2.Location = new Point(175, 52);
            txtBin2.Name = "txtBin2";
            txtBin2.ReadOnly = true;
            txtBin2.Size = new Size(75, 27);
            txtBin2.TabIndex = 7;
            txtBin2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBin3
            // 
            txtBin3.BackColor = Color.LightSteelBlue;
            txtBin3.Location = new Point(260, 52);
            txtBin3.Name = "txtBin3";
            txtBin3.ReadOnly = true;
            txtBin3.Size = new Size(75, 27);
            txtBin3.TabIndex = 8;
            txtBin3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBin4
            // 
            txtBin4.BackColor = Color.LightSteelBlue;
            txtBin4.Location = new Point(345, 52);
            txtBin4.Name = "txtBin4";
            txtBin4.ReadOnly = true;
            txtBin4.Size = new Size(75, 27);
            txtBin4.TabIndex = 9;
            txtBin4.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 10;
            label3.Text = "Masque d'adresses";
            // 
            // lblCIDR
            // 
            lblCIDR.AutoSize = true;
            lblCIDR.Location = new Point(90, 115);
            lblCIDR.Name = "lblCIDR";
            lblCIDR.Size = new Size(42, 20);
            lblCIDR.TabIndex = 11;
            lblCIDR.Text = "CIDR";
            // 
            // lblStandard
            // 
            lblStandard.AutoSize = true;
            lblStandard.Location = new Point(175, 115);
            lblStandard.Name = "lblStandard";
            lblStandard.Size = new Size(69, 20);
            lblStandard.TabIndex = 12;
            lblStandard.Text = "Standard";
            // 
            // txtCIDR
            // 
            txtCIDR.BackColor = Color.Gold;
            txtCIDR.Location = new Point(90, 133);
            txtCIDR.MaxLength = 2;
            txtCIDR.Name = "txtCIDR";
            txtCIDR.Size = new Size(40, 27);
            txtCIDR.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 136);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 14;
            label4.Text = "soit";
            // 
            // txtMask1
            // 
            txtMask1.BackColor = Color.Gold;
            txtMask1.Location = new Point(177, 133);
            txtMask1.MaxLength = 3;
            txtMask1.Name = "txtMask1";
            txtMask1.Size = new Size(60, 27);
            txtMask1.TabIndex = 15;
            txtMask1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMask2
            // 
            txtMask2.BackColor = Color.Gold;
            txtMask2.Location = new Point(243, 133);
            txtMask2.Name = "txtMask2";
            txtMask2.Size = new Size(60, 27);
            txtMask2.TabIndex = 16;
            txtMask2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMask3
            // 
            txtMask3.BackColor = Color.Gold;
            txtMask3.Location = new Point(309, 133);
            txtMask3.Name = "txtMask3";
            txtMask3.Size = new Size(60, 27);
            txtMask3.TabIndex = 17;
            txtMask3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMask4
            // 
            txtMask4.BackColor = Color.Gold;
            txtMask4.Location = new Point(375, 133);
            txtMask4.Name = "txtMask4";
            txtMask4.Size = new Size(60, 27);
            txtMask4.TabIndex = 18;
            txtMask4.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculer
            // 
            btnCalculer.BackColor = Color.Silver;
            btnCalculer.Location = new Point(200, 170);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(100, 30);
            btnCalculer.TabIndex = 19;
            btnCalculer.Text = "Calcul";
            btnCalculer.UseVisualStyleBackColor = false;
            btnCalculer.Click += btnCalculer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 220);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 20;
            label5.Text = "@ de classes";
            // 
            // txtClasse1
            // 
            txtClasse1.BackColor = Color.DodgerBlue;
            txtClasse1.Location = new Point(117, 217);
            txtClasse1.Name = "txtClasse1";
            txtClasse1.ReadOnly = true;
            txtClasse1.Size = new Size(40, 27);
            txtClasse1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 255);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 22;
            label6.Text = "@net";
            // 
            // txtNet1
            // 
            txtNet1.Location = new Point(81, 255);
            txtNet1.Name = "txtNet1";
            txtNet1.ReadOnly = true;
            txtNet1.Size = new Size(60, 27);
            txtNet1.TabIndex = 23;
            // 
            // txtNet2
            // 
            txtNet2.Location = new Point(160, 252);
            txtNet2.Name = "txtNet2";
            txtNet2.ReadOnly = true;
            txtNet2.Size = new Size(60, 27);
            txtNet2.TabIndex = 24;
            // 
            // txtNet3
            // 
            txtNet3.Location = new Point(230, 252);
            txtNet3.Name = "txtNet3";
            txtNet3.ReadOnly = true;
            txtNet3.Size = new Size(60, 27);
            txtNet3.TabIndex = 25;
            // 
            // txtNet4
            // 
            txtNet4.Location = new Point(300, 252);
            txtNet4.Name = "txtNet4";
            txtNet4.ReadOnly = true;
            txtNet4.Size = new Size(60, 27);
            txtNet4.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 288);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 27;
            label7.Text = "@Broadcast";
            // 
            // txtBcast1
            // 
            txtBcast1.Location = new Point(117, 285);
            txtBcast1.Name = "txtBcast1";
            txtBcast1.ReadOnly = true;
            txtBcast1.Size = new Size(60, 27);
            txtBcast1.TabIndex = 28;
            // 
            // txtBcast2
            // 
            txtBcast2.Location = new Point(183, 285);
            txtBcast2.Name = "txtBcast2";
            txtBcast2.ReadOnly = true;
            txtBcast2.Size = new Size(60, 27);
            txtBcast2.TabIndex = 29;
            // 
            // txtBcast3
            // 
            txtBcast3.Location = new Point(249, 285);
            txtBcast3.Name = "txtBcast3";
            txtBcast3.ReadOnly = true;
            txtBcast3.Size = new Size(60, 27);
            txtBcast3.TabIndex = 30;
            // 
            // txtBcast4
            // 
            txtBcast4.Location = new Point(315, 285);
            txtBcast4.Name = "txtBcast4";
            txtBcast4.ReadOnly = true;
            txtBcast4.Size = new Size(60, 27);
            txtBcast4.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 321);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 32;
            label8.Text = "1er IP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 354);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 33;
            label9.Text = "Dernière IP";
            // 
            // txtFirst1
            // 
            txtFirst1.Location = new Point(90, 318);
            txtFirst1.Name = "txtFirst1";
            txtFirst1.ReadOnly = true;
            txtFirst1.Size = new Size(60, 27);
            txtFirst1.TabIndex = 34;
            // 
            // txtFirst2
            // 
            txtFirst2.Location = new Point(160, 318);
            txtFirst2.Name = "txtFirst2";
            txtFirst2.ReadOnly = true;
            txtFirst2.Size = new Size(60, 27);
            txtFirst2.TabIndex = 35;
            // 
            // txtFirst3
            // 
            txtFirst3.Location = new Point(230, 318);
            txtFirst3.Name = "txtFirst3";
            txtFirst3.ReadOnly = true;
            txtFirst3.Size = new Size(60, 27);
            txtFirst3.TabIndex = 36;
            // 
            // txtFirst4
            // 
            txtFirst4.Location = new Point(300, 318);
            txtFirst4.Name = "txtFirst4";
            txtFirst4.ReadOnly = true;
            txtFirst4.Size = new Size(60, 27);
            txtFirst4.TabIndex = 37;
            // 
            // txtLast1
            // 
            txtLast1.Location = new Point(105, 351);
            txtLast1.Name = "txtLast1";
            txtLast1.ReadOnly = true;
            txtLast1.Size = new Size(60, 27);
            txtLast1.TabIndex = 38;
            // 
            // txtLast2
            // 
            txtLast2.Location = new Point(171, 351);
            txtLast2.Name = "txtLast2";
            txtLast2.ReadOnly = true;
            txtLast2.Size = new Size(60, 27);
            txtLast2.TabIndex = 39;
            // 
            // txtLast3
            // 
            txtLast3.Location = new Point(237, 351);
            txtLast3.Name = "txtLast3";
            txtLast3.ReadOnly = true;
            txtLast3.Size = new Size(60, 27);
            txtLast3.TabIndex = 40;
            // 
            // txtLast4
            // 
            txtLast4.Location = new Point(303, 351);
            txtLast4.Name = "txtLast4";
            txtLast4.ReadOnly = true;
            txtLast4.Size = new Size(60, 27);
            txtLast4.TabIndex = 41;
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
            label11.Location = new Point(20, 390);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 43;
            label11.Text = "Nb IPs";
            // 
            // txtNbIP
            // 
            txtNbIP.Location = new Point(97, 390);
            txtNbIP.Name = "txtNbIP";
            txtNbIP.ReadOnly = true;
            txtNbIP.Size = new Size(60, 27);
            txtNbIP.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(230, 390);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 45;
            label12.Text = "Nb Machines";
            // 
            // txtNbMachines
            // 
            txtNbMachines.Location = new Point(345, 390);
            txtNbMachines.Name = "txtNbMachines";
            txtNbMachines.ReadOnly = true;
            txtNbMachines.Size = new Size(60, 27);
            txtNbMachines.TabIndex = 46;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(txtNbMachines);
            Controls.Add(label12);
            Controls.Add(txtNbIP);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtLast4);
            Controls.Add(txtLast3);
            Controls.Add(txtLast2);
            Controls.Add(txtLast1);
            Controls.Add(txtFirst4);
            Controls.Add(txtFirst3);
            Controls.Add(txtFirst2);
            Controls.Add(txtFirst1);
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
            Controls.Add(lblStandard);
            Controls.Add(lblCIDR);
            Controls.Add(label3);
            Controls.Add(txtBin4);
            Controls.Add(txtBin3);
            Controls.Add(txtBin2);
            Controls.Add(txtBin1);
            Controls.Add(label2);
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

        private Label label2;
        private TextBox txtBin1;
        private TextBox txtBin2;
        private TextBox txtBin3;
        private TextBox txtBin4;
        private Label label3;
        private Label lblCIDR;
        private Label lblStandard;
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
        private TextBox txtFirst1;
        private TextBox txtFirst2;
        private TextBox txtFirst3;
        private TextBox txtFirst4;
        private TextBox txtLast1;
        private TextBox txtLast2;
        private TextBox txtLast3;
        private TextBox txtLast4;
        private Label label10;
        private Label label11;
        private TextBox txtNbIP;
        private Label label12;
        private TextBox txtNbMachines;
    }
}
