namespace CalculateurMasque
{
    public class CalculReseau
    {

        // Convertit un octet décimal en binaire sur 8 bits
        public string DecimalVersBinaire(int valeur)
        {
            return Convert.ToString(valeur, 2).PadLeft(8, '0');
        }

        // Convertit un masque CIDR en tableau de 4 octets
        // Ex : /24 → [255, 255, 255, 0]
        public int[] CIDRVersMasque(int cidr)
        {
            int[] masque = new int[4];
            int bits = cidr;

            for (int octet = 0; octet < 4; octet++)
            {
                if (bits >= 8)
                {
                    masque[octet] = 255;
                    bits -= 8;
                }
                else if (bits > 0)
                {
                    masque[octet] = 256 - (int)Math.Pow(2, 8 - bits);
                    bits = 0;
                }
                else
                {
                    masque[octet] = 0;
                }
            }
            return masque;
        }

        // Convertit un masque sur 4 octets en CIDR
        // Ex : [255, 255, 255, 0] → 24
        public int MasqueVersCIDR(int[] masque)
        {
            int cidr = 0;
            foreach (int octet in masque)
            {
                string binaire = Convert.ToString(octet, 2).PadLeft(8, '0');
                foreach (char bit in binaire)
                {
                    if (bit == '1') cidr++;
                    else break;
                }
            }
            return cidr;
        }

        // Détermine la classe de l'adresse IP (A, B, C, D, E)
        public string DeterminerClasse(int premierOctet)
        {
            if (premierOctet >= 1 && premierOctet <= 126) return "A";
            //if (premierOctet == 127) return "L"; // Loopback
            if (premierOctet >= 128 && premierOctet <= 191) return "B";
            if (premierOctet >= 192 && premierOctet <= 223) return "C";
            if (premierOctet >= 224 && premierOctet <= 239) return "D";
            return "E";
        }

        // Calcule l'adresse réseau (AND entre IP et masque)
        public int[] CalculerAdresseReseau(int[] ip, int[] masque)
        {
            int[] reseau = new int[4];
            for (int i = 0; i < 4; i++)
                reseau[i] = ip[i] & masque[i];
            return reseau;
        }

        // Calcule l'adresse broadcast (OR entre réseau et inverse du masque)
        public int[] CalculerBroadcast(int[] reseau, int[] masque)
        {
            int[] broadcast = new int[4];
            for (int i = 0; i < 4; i++)
                broadcast[i] = reseau[i] | (255 - masque[i]);
            return broadcast;
        }

        public int[] PremiereIP(int[] reseau)
        {
            int[] premiere = (int[])reseau.Clone();
            premiere[3] += 1;
            return premiere;
        }

        public int[] DerniereIP(int[] broadcast)
        {
            int[] derniere = (int[])broadcast.Clone();
            derniere[3] -= 1;
            return derniere;
        }

        // Calcule le nombre total d'IPs et d'hôtes
        public (long nbIPs, long nbMachines) CalculerNombre(int cidr)
        {
            long nbIPs = (long)Math.Pow(2, 32 - cidr);
            long nbMachines = nbIPs - 2;
            if (nbMachines < 0) nbMachines = 0;
            return (nbIPs, nbMachines);
        }
    }
}