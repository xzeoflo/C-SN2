using System;

namespace Mediatheque.Core.Model
{
    public class ObjetDePret
    {
        public string TitreDeLObjet { get; set; }
        public string? Emprunteur { get; set; }

        public ObjetDePret(string titreDeLObjet)
        {
            this.TitreDeLObjet = titreDeLObjet;
            Emprunteur = null;
        }

        public bool Emprunte(string emprunteur)
        {
            if (Emprunteur == null)
            {
                this.Emprunteur = emprunteur;
                return true;
            }
            return false;
        }
    }
}
