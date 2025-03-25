public class Societe
{
    public string Nom {get;set;}
    private List<Employe> Employes {get;set;}
    public  Societe(string Nom)
    {
        this.Nom =Nom;
        this.Employes = new List<Employe>();
    }

        public void Embauche (Employe employer)
        {
            this.Employes.Add(employer);
        }  
    public chef? GetChef()
    {
        foreach (Employe employe in this.Employes)
        {
            if (employe is Chef) return ((chef) employe);
        }
        return null;
    }
    
    public double CalculSommeSalaire()
    {
        double somme = 0;
        foreach (Employe employe in this.Employes)
        {
            somme += employe.Salaire;
        }
        return somme;
    }



}   