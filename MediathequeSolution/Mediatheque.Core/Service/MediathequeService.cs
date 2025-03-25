using Mediatheque.Core.Model;

namespace Mediatheque.Core.Service
{
    public class MediathequeService
    {
        private List<ObjetDePret> _fondDeCommerce = new List<ObjetDePret>();
        private INotationService _notationService;

        public MediathequeService(INotationService notationService)
        {
            _notationService = notationService;
        }

        public void AddObjet(ObjetDePret objet)
        {
            _fondDeCommerce.Add(objet);
        }

        public int GetNombreObjet()
        {
            return _fondDeCommerce.Count;
        }

        public string PresenterJeux()
        {
            if(this.GetNombreObjet() == 0)
            {
                return "Pas de jeux";
            }
            else
            {
                int i = 0;
                string LesJeux = "";
                foreach(ObjetDePret elt in _fondDeCommerce)
                {
                    if(elt is JeuxDeSociete)
                    {
                        i+=1;
                        LesJeux += elt.TitreDeLObjet + " " + ((JeuxDeSociete)elt).Editeur + " ";

                    }

                }
                
                if (i != 0)
                {
                    return i.ToString() +" "+ LesJeux ;
                }
                return "Pas de jeux";
            }
        }
    }
}
