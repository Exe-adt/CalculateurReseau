using System.Drawing;
using System.Windows.Forms;

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
            txtIP = new TextBox();
            txtBin = new TextBox();
            label3 = new Label();
            txtCIDR = new TextBox();
            label4 = new Label();
            txtMask = new TextBox();
            btnCalculer = new Button();
            label5 = new Label();
            txtClasse1 = new TextBox();
            label6 = new Label();
            txtNet = new TextBox();
            label7 = new Label();
            txtBcast = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtDernier = new TextBox();
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
            label17 = new Label();
            label18 = new Label();
            txtMaskBin = new TextBox();
            txtPremier = new TextBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            Label1.Location = new Point(80, 83);
            Label1.Name = "Label1";
            Label1.Size = new Size(182, 25);
            Label1.TabIndex = 0;
            Label1.Text = "Adresse IP (Décimal)";
            // 
            // txtIP
            // 
            txtIP.BackColor = Color.LightBlue;
            txtIP.BorderStyle = BorderStyle.FixedSingle;
            txtIP.Location = new Point(80, 111);
            txtIP.MaxLength = 15;
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(182, 27);
            txtIP.TabIndex = 1;
            txtIP.TextAlign = HorizontalAlignment.Center;
            txtIP.TextChanged += txtIP_TextChanged;
            // 
            // txtBin
            // 
            txtBin.BackColor = SystemColors.ControlLight;
            txtBin.BorderStyle = BorderStyle.FixedSingle;
            txtBin.Location = new Point(48, 327);
            txtBin.Name = "txtBin";
            txtBin.ReadOnly = true;
            txtBin.Size = new Size(286, 27);
            txtBin.TabIndex = 6;
            txtBin.TextAlign = HorizontalAlignment.Center;
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
            txtCIDR.BackColor = Color.LightBlue;
            txtCIDR.BorderStyle = BorderStyle.FixedSingle;
            txtCIDR.Location = new Point(415, 111);
            txtCIDR.MaxLength = 2;
            txtCIDR.Name = "txtCIDR";
            txtCIDR.Size = new Size(40, 27);
            txtCIDR.TabIndex = 13;
            txtCIDR.TextAlign = HorizontalAlignment.Center;
            txtCIDR.TextChanged += txtCIDR_TextChanged;
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
            // txtMask
            // 
            txtMask.BackColor = Color.LightBlue;
            txtMask.BorderStyle = BorderStyle.FixedSingle;
            txtMask.Location = new Point(497, 111);
            txtMask.Name = "txtMask";
            txtMask.Size = new Size(258, 27);
            txtMask.TabIndex = 18;
            txtMask.TextAlign = HorizontalAlignment.Center;
            txtMask.TextChanged += txtMask_TextChanged;
            // 
            // btnCalculer
            // 
            btnCalculer.BackColor = Color.LightSteelBlue;
            btnCalculer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculer.Location = new Point(280, 185);
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
            label5.Location = new Point(671, 299);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 20;
            label5.Text = "Classe IP";
            // 
            // txtClasse1
            // 
            txtClasse1.BackColor = SystemColors.ControlLight;
            txtClasse1.BorderStyle = BorderStyle.FixedSingle;
            txtClasse1.Location = new Point(689, 327);
            txtClasse1.Name = "txtClasse1";
            txtClasse1.ReadOnly = true;
            txtClasse1.Size = new Size(40, 27);
            txtClasse1.TabIndex = 21;
            txtClasse1.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.Location = new Point(80, 435);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 22;
            label6.Text = "Adresse Net";
            // 
            // txtNet
            // 
            txtNet.BackColor = SystemColors.ControlLight;
            txtNet.BorderStyle = BorderStyle.FixedSingle;
            txtNet.Location = new Point(80, 463);
            txtNet.Name = "txtNet";
            txtNet.ReadOnly = true;
            txtNet.Size = new Size(186, 27);
            txtNet.TabIndex = 23;
            txtNet.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label7.Location = new Point(461, 435);
            label7.Name = "label7";
            label7.Size = new Size(164, 25);
            label7.TabIndex = 27;
            label7.Text = "Adresse Broadcast";
            // 
            // txtBcast
            // 
            txtBcast.BackColor = SystemColors.ControlLight;
            txtBcast.BorderStyle = BorderStyle.FixedSingle;
            txtBcast.Location = new Point(461, 463);
            txtBcast.Name = "txtBcast";
            txtBcast.ReadOnly = true;
            txtBcast.Size = new Size(188, 27);
            txtBcast.TabIndex = 28;
            txtBcast.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.Location = new Point(80, 517);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 32;
            label8.Text = "Première IP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.Location = new Point(461, 517);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 33;
            label9.Text = "Dernière IP";
            // 
            // txtDernier
            // 
            txtDernier.BackColor = SystemColors.ControlLight;
            txtDernier.BorderStyle = BorderStyle.FixedSingle;
            txtDernier.Location = new Point(461, 556);
            txtDernier.Name = "txtDernier";
            txtDernier.ReadOnly = true;
            txtDernier.Size = new Size(188, 27);
            txtDernier.TabIndex = 38;
            txtDernier.TextAlign = HorizontalAlignment.Center;
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
            label11.Location = new Point(93, 689);
            label11.Name = "label11";
            label11.Size = new Size(66, 25);
            label11.TabIndex = 43;
            label11.Text = "Nb IPs";
            // 
            // txtNbIP
            // 
            txtNbIP.BackColor = SystemColors.ControlLight;
            txtNbIP.BorderStyle = BorderStyle.FixedSingle;
            txtNbIP.Location = new Point(165, 687);
            txtNbIP.Name = "txtNbIP";
            txtNbIP.ReadOnly = true;
            txtNbIP.Size = new Size(120, 27);
            txtNbIP.TabIndex = 44;
            txtNbIP.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(461, 689);
            label12.Name = "label12";
            label12.Size = new Size(120, 25);
            label12.TabIndex = 45;
            label12.Text = "Nb Machines";
            // 
            // txtNbMachines
            // 
            txtNbMachines.BackColor = SystemColors.ControlLight;
            txtNbMachines.BorderStyle = BorderStyle.FixedSingle;
            txtNbMachines.Location = new Point(587, 689);
            txtNbMachines.Name = "txtNbMachines";
            txtNbMachines.ReadOnly = true;
            txtNbMachines.Size = new Size(120, 27);
            txtNbMachines.TabIndex = 46;
            txtNbMachines.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVider
            // 
            btnVider.BackColor = SystemColors.ActiveBorder;
            btnVider.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVider.Location = new Point(451, 185);
            btnVider.Name = "btnVider";
            btnVider.Size = new Size(100, 35);
            btnVider.TabIndex = 47;
            btnVider.Text = "Vider";
            btnVider.UseVisualStyleBackColor = false;
            btnVider.Click += btnVider_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(280, 22);
            label2.Name = "label2";
            label2.Size = new Size(245, 31);
            label2.TabIndex = 48;
            label2.Text = "Calculteur de Masque";
            // 
            // label13
            // 
            label13.BackColor = Color.LightSteelBlue;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(48, 247);
            label13.Name = "label13";
            label13.Size = new Size(700, 30);
            label13.TabIndex = 49;
            label13.Text = "Resultat";
            // 
            // label14
            // 
            label14.BackColor = Color.LightSteelBlue;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(48, 388);
            label14.Name = "label14";
            label14.Size = new Size(700, 30);
            label14.TabIndex = 50;
            label14.Text = "Configutation du réseau";
            // 
            // label15
            // 
            label15.BackColor = Color.LightSteelBlue;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(48, 614);
            label15.Name = "label15";
            label15.Size = new Size(700, 30);
            label15.TabIndex = 51;
            label15.Text = "Nombre total";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label17.Location = new Point(366, 297);
            label17.Name = "label17";
            label17.Size = new Size(153, 25);
            label17.TabIndex = 53;
            label17.Text = "Masque (Binaire)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label18.Location = new Point(48, 299);
            label18.Name = "label18";
            label18.Size = new Size(188, 25);
            label18.TabIndex = 54;
            label18.Text = "Adresse IP en Binaire";
            // 
            // txtMaskBin
            // 
            txtMaskBin.BackColor = SystemColors.ControlLight;
            txtMaskBin.BorderStyle = BorderStyle.FixedSingle;
            txtMaskBin.Location = new Point(366, 327);
            txtMaskBin.Name = "txtMaskBin";
            txtMaskBin.ReadOnly = true;
            txtMaskBin.Size = new Size(286, 27);
            txtMaskBin.TabIndex = 55;
            txtMaskBin.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPremier
            // 
            txtPremier.BackColor = SystemColors.ControlLight;
            txtPremier.BorderStyle = BorderStyle.FixedSingle;
            txtPremier.Location = new Point(80, 556);
            txtPremier.Name = "txtPremier";
            txtPremier.ReadOnly = true;
            txtPremier.Size = new Size(186, 27);
            txtPremier.TabIndex = 56;
            txtPremier.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(795, 809);
            Controls.Add(txtPremier);
            Controls.Add(txtMaskBin);
            Controls.Add(label18);
            Controls.Add(label17);
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
            Controls.Add(txtDernier);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtBcast);
            Controls.Add(label7);
            Controls.Add(txtNet);
            Controls.Add(label6);
            Controls.Add(txtClasse1);
            Controls.Add(label5);
            Controls.Add(btnCalculer);
            Controls.Add(txtMask);
            Controls.Add(label4);
            Controls.Add(txtCIDR);
            Controls.Add(label3);
            Controls.Add(txtBin);
            Controls.Add(txtIP);
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
        private TextBox txtIP;
        private TextBox txtBin;
        private Label label3;
        private TextBox txtCIDR;
        private Label label4;
        private TextBox txtMask;
        private Button btnCalculer;
        private Label label5;
        private TextBox txtClasse1;
        private Label label6;
        private TextBox txtNet;
        private Label label7;
        private TextBox txtBcast;
        private Label label8;
        private Label label9;
        private TextBox txtDernier;
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
        private Label label17;
        private Label label18;
        private TextBox txtMaskBin;
        private TextBox txtPremier;
    }
}
