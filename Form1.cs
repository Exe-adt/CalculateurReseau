using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CalculateurMasque
{
    public partial class Form1 : Form
    {
        private CalculReseau calc = new CalculReseau();

        public Form1()
        {
            InitializeComponent();
        }

        private bool ModifManuellement = false; //flag pour déterminer si une saisie du masque est effectué manuellement
        private bool miseAJourAutomatique = false; //permet d'empécher les TextChanged de s'éxecuter si c'est le programme qui modifie les champs

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            ConvertirEnBinaire();

            string[] bouts = txtIP.Text.Split('.');
            if (bouts.Length == 4 && int.TryParse(bouts[0], out int premierOctet) && premierOctet >= 0 && premierOctet <= 255)
            {

                if (!ModifManuellement)
                {
                    string classe = calc.DeterminerClasse(premierOctet);

                    miseAJourAutomatique = true;
                    int cidrDefaut = calc.MasqueParDefaut(classe);
                    txtCIDR.Text = cidrDefaut.ToString();
                    int[] masqueDefaut = calc.CIDRVersMasque(cidrDefaut);
                    RemplirChampsMasque(masqueDefaut);
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
            string[] bouts = txtIP.Text.Split('.');

            if (bouts.Length != 4)
            {
                txtBin.Text = "";
                return;
            }

            int[] ip = new int[4];

            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(bouts[i], out ip[i]) || ip[i] < 0 || ip[i] > 255)
                {
                    txtBin.Text = "";
                    return;
                }
            }

            txtBin.Text =
                $"{calc.DecimalVersBinaire(ip[0])}." +
                $"{calc.DecimalVersBinaire(ip[1])}." +
                $"{calc.DecimalVersBinaire(ip[2])}." +
                $"{calc.DecimalVersBinaire(ip[3])}";
        }



        private bool VerifIP(out int[] ip)
        {
            ip = new int[4];
            string[] bouts = txtIP.Text.Split('.');

            if (bouts.Length != 4)
            {
                MessageBox.Show("Adresse IP invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(bouts[i], out ip[i]) || ip[i] < 0 || ip[i] > 255)
                {
                    MessageBox.Show("Adresse IP invalide.\nChaque octet doit être entre 0 et 255.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private bool VerifMasque(out int[] masque)
        {
            masque = new int[4];

            if (!string.IsNullOrWhiteSpace(txtCIDR.Text))
                return VerifCIDR(out masque);

            if (!string.IsNullOrEmpty(txtMask.Text))
                return VerifMasqueStandard(out masque);

            //masque par défaut selon classe
            if (!VerifIP(out int[] ip)) return false;

            string classe = calc.DeterminerClasse(ip[0]);
            int cidrDefaut = calc.MasqueParDefaut(classe);

            miseAJourAutomatique = true;
            txtCIDR.Text = cidrDefaut.ToString();
            txtType.Text = calc.TypeAdresse(ip[0], ip[1]);
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
            string type = calc.TypeAdresse(ip[0], ip[1]);

            int[] reseau = calc.CalculerAdresseReseau(ip, masque);
            int[] broadcast = calc.CalculerBroadcast(reseau, masque);

            var (nbIP, nbMachines) = calc.CalculerNombre(cidr);

            txtClasse1.Text = classe;
            txtType.Text = type;
            txtClasse1.BackColor = CouleurClasse(classe);

            AfficherAdresse(txtNet, reseau);
            AfficherAdresse(txtBcast, broadcast);


            if (cidr < 31)
            {
                int[] premiere = calc.PremiereAdresse(reseau);
                int[] derniere = calc.DerniereAdresse(broadcast);

                AfficherAdresse(txtPremier, premiere);
                AfficherAdresse(txtDernier, derniere);
            }
            else
            {
                ViderAdresse(txtPremier);

                ViderAdresse(txtDernier);
            }

            txtMaskBin.Text = $"{calc.DecimalVersBinaire(masque[0])}." +
                $"{calc.DecimalVersBinaire(masque[1])}." +
                $"{calc.DecimalVersBinaire(masque[2])}." +
                $"{calc.DecimalVersBinaire(masque[3])}";

            txtNbIP.Text = nbIP.ToString();
            txtNbMachines.Text = nbMachines.ToString();

            miseAJourAutomatique = false;
        }

        private void RemplirChampsMasque(int[] masque)
        {
            txtMask.Text = masque[0] + "." + masque[1] + "." + masque[2] + "." + masque[3];
        }

        private void AfficherAdresse(TextBox txt, int[] adr)
        {
            txt.Text = $"{adr[0]}.{adr[1]}.{adr[2]}.{adr[3]}";
        }

        private void ViderAdresse(TextBox t)
        {
            t.Text = "";

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
