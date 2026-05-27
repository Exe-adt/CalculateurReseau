using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace CalculateurMasque
{
    public partial class Form1 : Form
    {
        private CalculReseau calc = new CalculReseau();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtOct_TextChanged(object sender, EventArgs e)
        {
            ConvertirEnBinaire();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            if (!EssayerLireIP(out int[] ip))
                return;

            if (!EssayerLireMasque(out int[] masque))
                return;

            AfficherResultats(ip, masque);
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls) //Control c'est la classe mère de tous les éléments WinForms
                if (c is TextBox t) t.Text = "";

        }

        private void ConvertirEnBinaire()
        {
            TextBox[] octDec = { txtOct1, txtOct2, txtOct3, txtOct4 };
            TextBox[] octBin = { txtBin1, txtBin2, txtBin3, txtBin4 };

            for (int i = 0; i < 4; i++)
            {
                if (int.TryParse(octDec[i].Text, out int valeur) && valeur >= 0 && valeur <= 255)
                {
                    octBin[i].Text = calc.DecimalVersBinaire(valeur);
                    octDec[i].BackColor = Color.White;
                }
                else if (octDec[i].Text == "")
                {
                    octBin[i].Text = "";
                    octDec[i].BackColor = Color.White;
                }
                else
                {
                    octBin[i].Text = "????????";
                    octDec[i].BackColor = Color.LightCoral;
                }
            }
        }

        private bool EssayerLireIP(out int[] ip)
        {
            ip = new int[4];
            TextBox[] octets = { txtOct1, txtOct2, txtOct3, txtOct4 };

            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(octets[i].Text, out ip[i]) || ip[i] < 0 || ip[i] > 255)
                {
                    MessageBox.Show(
                        "L'adresse IP est invalide !\nChaque octet doit être entre 0 et 255.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private bool EssayerLireMasque(out int[] masque)
        {
            masque = new int[4];

            if (txtCIDR.Text != "" && txtCIDR.Text != " ")
                return EssayerLireCIDR(out masque);

            return EssayerLireMasqueStandard(out masque);
        }

        private bool EssayerLireCIDR(out int[] masque)
        {
            masque = new int[4];

            if (!int.TryParse(txtCIDR.Text, out int cidr) || cidr < 0 || cidr > 32)
            {
                MessageBox.Show(
                    "Le masque CIDR est invalide !\nIl doit être entre 0 et 32.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            masque = calc.CIDRVersMasque(cidr);
            RemplirChampsMasque(masque);
            return true;
        }

        private bool EssayerLireMasqueStandard(out int[] masque)
        {
            masque = new int[4];
            TextBox[] champsMasque = { txtMask1, txtMask2, txtMask3, txtMask4 };

            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(champsMasque[i].Text, out masque[i]) || masque[i] < 0 || masque[i] > 255)
                {
                    MessageBox.Show("Le masque standard est invalide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            txtCIDR.Text = calc.MasqueVersCIDR(masque).ToString();
            return true;
        }

        private void AfficherResultats(int[] ip, int[] masque)
        {
            int cidrFinal = calc.MasqueVersCIDR(masque);
            string classe = calc.DeterminerClasse(ip[0]);
            int[] reseau = calc.CalculerAdresseReseau(ip, masque);
            int[] broadcast = calc.CalculerBroadcast(reseau, masque);
            int[] premiereIP = calc.PremiereIP(reseau);
            int[] derniereIP = calc.DerniereIP(broadcast);
            var (nbIPs, nbMachines) = calc.CalculerNombre(cidrFinal);

            txtClasse1.Text = classe;
            txtClasse1.BackColor = CouleurClasse(classe);

            RemplirChampsAdresse(new TextBox[] { txtNet1, txtNet2, txtNet3, txtNet4 }, reseau);
            RemplirChampsAdresse(new TextBox[] { txtBcast1, txtBcast2, txtBcast3, txtBcast4 }, broadcast);
            RemplirChampsAdresse(new TextBox[] { txtPre1, txtPre2, txtPre3, txtPre4 }, premiereIP);
            RemplirChampsAdresse(new TextBox[] { txtDer1, txtDer2, txtDer3, txtDer4 }, derniereIP);

            txtNbIP.Text = nbIPs.ToString();
            txtNbMachines.Text = nbMachines.ToString();
        }

        private void RemplirChampsMasque(int[] masque)
        {
            txtMask1.Text = masque[0].ToString();
            txtMask2.Text = masque[1].ToString();
            txtMask3.Text = masque[2].ToString();
            txtMask4.Text = masque[3].ToString();
        }

        private void RemplirChampsAdresse(TextBox[] champs, int[] valeurs)
        {
            for (int i = 0; i < 4; i++)
                champs[i].Text = valeurs[i].ToString();
        }

        private Color CouleurClasse(string classe)
        {
            return classe switch
            {
                "A" => Color.LightGreen,
                "B" => Color.LightBlue,
                "C" => Color.LightYellow,
                "D" => Color.Orange,
                _ => Color.LightCoral
            };
        }
    }
}