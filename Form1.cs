using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculateurMasque
{
    public partial class Form1 : Form
    {
        // On crée une instance de notre classe de calcul
        private CalculReseau calc = new CalculReseau();

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertirEnBinaire()
        {
            // Tableau des cases décimales et binaires
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

        private void txtOct_TextChanged(object sender, EventArgs e)
        {
            ConvertirEnBinaire();
        }


        
        private void btnCalculer_Click(object sender, EventArgs e)
        {
            // 1. Validation de l'adresse IP
            int[] ip = new int[4];
            TextBox[] octDec = { txtOct1, txtOct2, txtOct3, txtOct4 };

            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(octDec[i].Text, out ip[i]) || ip[i] < 0 || ip[i] > 255)
                {
                    MessageBox.Show("L'adresse IP est invalide !\nChaque octet doit être entre 0 et 255.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 2. Validation et récupération du masque
            int[] masque = new int[4];

            if (txtCIDR.Text != "")
            {
                // L'utilisateur a saisi un CIDR
                if (!int.TryParse(txtCIDR.Text, out int cidr) || cidr < 0 || cidr > 32)
                {
                    MessageBox.Show("Le masque CIDR est invalide !\nIl doit être entre 0 et 32.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                masque = calc.CIDRVersMasque(cidr);

                // On remplit automatiquement les cases masque standard
                txtMask1.Text = masque[0].ToString();
                txtMask2.Text = masque[1].ToString();
                txtMask3.Text = masque[2].ToString();
                txtMask4.Text = masque[3].ToString();
            }
            else
            {
                // L'utilisateur a saisi un masque standard
                TextBox[] Mask = { txtMask1, txtMask2, txtMask3, txtMask4 };
                for (int i = 0; i < 4; i++)
                {
                    if (!int.TryParse(Mask[i].Text, out masque[i]) || masque[i] < 0 || masque[i] > 255)
                    {
                        MessageBox.Show("Le masque standard est invalide !",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                // On remplit automatiquement le CIDR
                txtCIDR.Text = calc.MasqueVersCIDR(masque).ToString();
            }

            // 3. Calculs réseau
            int cidrFinal = calc.MasqueVersCIDR(masque);
            string classe = calc.DeterminerClasse(ip[0]);
            int[] reseau = calc.CalculerAdresseReseau(ip, masque);
            int[] broadcast = calc.CalculerBroadcast(reseau, masque);
            int[] premiereIP = calc.PremiereIP(reseau);
            int[] derniereIP = calc.DerniereIP(broadcast);
            var (nbIPs, nbMachines) = calc.CalculerNombre(cidrFinal);

            // 4. Affichage des résultats
            txtClasse1.Text = classe;

            txtNet1.Text = reseau[0].ToString();
            txtNet2.Text = reseau[1].ToString();
            txtNet3.Text = reseau[2].ToString();
            txtNet4.Text = reseau[3].ToString();

            txtBcast1.Text = broadcast[0].ToString();
            txtBcast2.Text = broadcast[1].ToString();
            txtBcast3.Text = broadcast[2].ToString();
            txtBcast4.Text = broadcast[3].ToString();

            txtFirst1.Text = premiereIP[0].ToString();
            txtFirst2.Text = premiereIP[1].ToString();
            txtFirst3.Text = premiereIP[2].ToString();
            txtFirst4.Text = premiereIP[3].ToString();

            txtLast1.Text = derniereIP[0].ToString();
            txtLast2.Text = derniereIP[1].ToString();
            txtLast3.Text = derniereIP[2].ToString();
            txtLast4.Text = derniereIP[3].ToString();

            txtNbIP.Text = nbIPs.ToString();
            txtNbMachines.Text = nbMachines.ToString();

            // Couleur de la classe
            txtClasse1.BackColor = classe switch
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
