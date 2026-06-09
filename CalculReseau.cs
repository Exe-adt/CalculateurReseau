using System;

namespace CalculateurMasque
{
    public class CalculReseau
    {
        public string DecimalVersBinaire(int valeur)
        {
            return Convert.ToString(valeur, 2).PadLeft(8, '0');
        }

        public int[] CIDRVersMasque(int cidr)
        {
            int[] masque = new int[4];
            if (cidr < 0 || cidr > 32)
                throw new ArgumentException("CIDR non valide");

            for (int i = 0; i < 4; i++)
            {
                if (cidr >= 8)
                {
                    masque[i] = 255;
                    cidr -= 8;
                }
                else if (cidr > 0)
                {
                    masque[i] = (255 << (8 - cidr)) & 255;
                    cidr = 0;
                }
                else
                    masque[i] = 0;
                }

            return masque;
        }

        public int MasqueVersCIDR(int[] masque)
        {
            int cidr = 0;
            bool zeroTrouve = false;

            foreach (int octet in masque)
            {
                string binaire = Convert.ToString(octet, 2).PadLeft(8, '0');

                foreach (char bit in binaire)
                {
                    if (bit == '1')
                    {
                        if (zeroTrouve)
                            return -1;

                        cidr++;
                }
                    else
                        zeroTrouve = true;
            }
            }

            return cidr;
        }

        public string DeterminerClasse(int premierOctet)
        {
            if (premierOctet >= 0 && premierOctet <= 127)
                return "A";

            if (premierOctet >= 128 && premierOctet <= 191)
                return "B";

            if (premierOctet >= 192 && premierOctet <= 223)
                return "C";

            if (premierOctet >= 224 && premierOctet <= 239)
                return "D";

            return "E";
        }

        public int MasqueParDefaut(string classe)
        {
            if (classe == "A") return 8;
            if (classe == "B") return 16;
            if (classe == "C") return 24;
            return 24; // Les deux dernières classes tombent sur 24 volontairement

        }

        public int[] CalculerAdresseReseau(int[] ip, int[] masque)
        {
            int[] reseau = new int[4];

            for (int i = 0; i < 4; i++)
                reseau[i] = ip[i] & masque[i];

            return reseau;
        }

        public int[] CalculerBroadcast(int[] reseau, int[] masque)
        {
            int[] broadcast = new int[4];

            for (int i = 0; i < 4; i++)
                broadcast[i] = reseau[i] | (~masque[i] & 255);

            return broadcast;
        }

        public int[] PremiereAdresse(int[] reseau)
        {
            return IncrementerIP(reseau);
        }

        public int[] DerniereAdresse(int[] broadcast)
        {
            return DecrementerIP(broadcast);
        }

        private int[] IncrementerIP(int[] ip)
        {
            int[] resultat = (int[])ip.Clone();

            for (int i = 3; i >= 0; i--)
        {
                resultat[i]++;

                if (resultat[i] <= 255)
                    break;

                resultat[i] = 0;
        }

            return resultat;
        }

        private int[] DecrementerIP(int[] ip)
        {
            int[] resultat = (int[])ip.Clone();

            for (int i = 3; i >= 0; i--)
            {
                resultat[i]--;

                if (resultat[i] >= 0)
                    break;

                resultat[i] = 255;
            }

            return resultat;
        }

        public (long nbIP, long nbMachines) CalculerNombre(int cidr)
        {
            long nbIP = (long)Math.Pow(2, 32 - cidr);

            long nbMachines = nbIP - 2;

            if (cidr >= 31)
                nbMachines = 0;

            return (nbIP, nbMachines);
        }

        public string TypeAdresse(int o1, int o2)
        {
            if (o1 == 0)
                return "Spéciale (non routable)";

            if (o1 == 10)
                return "Privée (non routable)";

            if (o1 == 172 && o2 >= 16 && o2 <= 31)
                return "Privée (non routable)";

            if (o1 == 192 && o2 == 168)
                return "Privée (non routable)";

            if (o1 == 127)
                return "Loopback";

            if (o1 == 169 && o2 == 254)
                return "APIPA";

            if (o1 >= 224 && o1 <= 239)
                return "Multicast";

            if (o1 >= 240)
                return "Expérimental";

            return "Publique (routable)";
        }
    }
}