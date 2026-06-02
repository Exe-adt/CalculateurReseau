using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculateurMasque
{
    public partial class Form1 : Form
    {
        private readonly CalculReseau calc = new CalculReseau();

        public Form1()
        {
            InitializeComponent();
        }

        private bool ModifManuellement = false; //flag pour déterminer si une saisie du masque est effectué manuellement
        private bool miseAJourAutomatique = false; //permet d'empécher les TextChanged de s'éxecuter si c'est le programme qui modifie les champs

        private void txtOct_TextChanged(object sender, EventArgs e)
        {
            ConvertirEnBinaire();
            if (int.TryParse(txtOct1.Text, out int premierOctet) && premierOctet >= 0 && premierOctet <= 255)
            {

                if (!ModifManuellement)
                {
                    string classe = calc.DeterminerClasse(premierOctet);
                    miseAJourAutomatique = true;
                    txtCIDR.Text = calc.MasqueParDefaut(classe).ToString();
                    miseAJourAutomatique = false;
                }
            }
        }

        private void txtMask_TextChanged(object sender, EventArgs e)
        {
            if (!miseAJourAutomatique)
                ModifManuellement = true;
        }
        private void txtCIDR_TextChanged(object sender, EventArgs e)
        {
            if (!miseAJourAutomatique)
                ModifManuellement = true;
        }


        private void btnCalculer_Click(object sender, EventArgs e)
        {
            if (!VerifIP(out int[] ip))
                return;

            if (!VerifMasque(out int[] masque))
                return;

            AfficherResultats(ip, masque);
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            ViderTextBox(this);
            txtClasse1.BackColor = Color.White;
            ModifManuellement = false;
        }

        private void ViderTextBox(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txt)
                    txt.Text = "";

                if (c.HasChildren)
                    ViderTextBox(c);
            }
        }

        private void ConvertirEnBinaire()
        {
            TextBox[] octetsDec = { txtOct1, txtOct2, txtOct3, txtOct4 };

            TextBox[] octetsBin = { txtBin1, txtBin2, txtBin3, txtBin4 };

            for (int i = 0; i < 4; i++)
            {
                if (int.TryParse(octetsDec[i].Text, out int valeur) && valeur >= 0 && valeur <= 255)
                {
                    octetsBin[i].Text = calc.DecimalVersBinaire(valeur);

                    octetsDec[i].BackColor = Color.White;
                }
                else if (string.IsNullOrWhiteSpace(octetsDec[i].Text))
                {
                    octetsBin[i].Text = "";
                    octetsDec[i].BackColor = Color.White;
                }
                else
                {
                    octetsBin[i].Text = "????????";
                    octetsDec[i].BackColor = Color.LightCoral;
                }
            }
        }

        private bool VerifIP(out int[] ip)
        {
            ip = new int[4];

            TextBox[] champs = { txtOct1, txtOct2, txtOct3, txtOct4 };

            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(champs[i].Text, out ip[i]) || ip[i] < 0 || ip[i] > 255)
                {
                    MessageBox.Show("Adresse IP invalide.\nChaque octet doit être compris entre 0 et 255.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    champs[i].BackColor = Color.LightCoral;

                    return false;
                }
            }

            return true;
        }

        private bool VerifMasque(out int[] masque)
        {
            masque = new int[4];

            if (txtCIDR.Text != "" && txtCIDR.Text != " ")
                return VerifCIDR(out masque);

            if (txtMask.Text != "")
                return VerifMasqueStandard(out masque);

            if (!VerifIP(out int[] ip))
                return false;

            string classe = calc.DeterminerClasse(ip[0]);
            int cidrDefaut = calc.MasqueParDefaut(classe);

            miseAJourAutomatique = true;
            txtCIDR.Text = cidrDefaut.ToString();
            miseAJourAutomatique = false;

            return VerifCIDR(out masque);
        }

        private bool VerifCIDR(out int[] masque)
        {
            masque = new int[4];

            if (!int.TryParse(txtCIDR.Text, out int cidr) || cidr < 0 || cidr > 32)
            {
                MessageBox.Show("CIDR invalide.\nValeur attendue entre 0 et 32.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            miseAJourAutomatique = true;
            masque = calc.CIDRVersMasque(cidr);
            RemplirChampsMasque(masque);
            miseAJourAutomatique = false;

            return true;
        }

        private bool VerifMasqueStandard(out int[] masque)
        {
            masque = new int[4];

            string[] bouts = txtMask.Text.Split('.');

            if (bouts.Length != 4)
            {
                MessageBox.Show("Masque invalide.\nFormat attendu : 255.255.255.0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(bouts[i], out masque[i]) || masque[i] < 0 || masque[i] > 255)
                {
                    MessageBox.Show("Masque invalide.\nChaque octet doit être entre 0 et 255.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            int cidr = calc.MasqueVersCIDR(masque);

            if (cidr == -1)
            {
                MessageBox.Show("Masque non valide.\nLes bits à 1 doivent être continus.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            miseAJourAutomatique = true;
            txtCIDR.Text = cidr.ToString();
            miseAJourAutomatique = false;
            return true;



        }




        private void AfficherResultats(int[] ip, int[] masque)
        {
            miseAJourAutomatique = true;

            int cidr = calc.MasqueVersCIDR(masque);

            string classe = calc.DeterminerClasse(ip[0]);

            int[] reseau = calc.CalculerAdresseReseau(ip, masque);

            int[] broadcast = calc.CalculerBroadcast(reseau, masque);

            var (nbIP, nbMachines) = calc.CalculerNombre(cidr);

            txtClasse1.Text = classe;
            txtClasse1.BackColor = CouleurClasse(classe);

            RemplirAdresse(new[] { txtNet1, txtNet2, txtNet3, txtNet4 }, reseau);

            RemplirAdresse(new[] { txtBcast1, txtBcast2, txtBcast3, txtBcast4 }, broadcast);

            if (cidr < 31)
            {
                int[] premiere = calc.PremiereAdresse(reseau);

                int[] derniere = calc.DerniereAdresse(broadcast);

                RemplirAdresse(new[] { txtPre1, txtPre2, txtPre3, txtPre4 }, premiere);

                RemplirAdresse(new[] { txtDer1, txtDer2, txtDer3, txtDer4 }, derniere);
            }
            else
            {
                ViderAdresse(txtPre1, txtPre2, txtPre3, txtPre4);

                ViderAdresse(txtDer1, txtDer2, txtDer3, txtDer4);
            }

            textMaskBin.Text = calc.DecimalVersBinaire(masque[0]) + "." +
                       calc.DecimalVersBinaire(masque[1]) + "." +
                       calc.DecimalVersBinaire(masque[2]) + "." +
                       calc.DecimalVersBinaire(masque[3]);

            txtNbIP.Text = nbIP.ToString();
            txtNbMachines.Text = nbMachines.ToString();

            miseAJourAutomatique = false;
        }

        private void RemplirChampsMasque(int[] masque)
        {
            txtMask.Text = masque[0] + "." + masque[1] + "." + masque[2] + "." + masque[3];
        }

        private void RemplirAdresse(TextBox[] champs, int[] valeurs)
        {
            for (int i = 0; i < 4; i++)
                champs[i].Text = valeurs[i].ToString();
        }

        private void ViderAdresse(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtBin4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


    }
}
