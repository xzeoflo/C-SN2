class Employe : Personne
{
    public double Salaire {get;set;}
    public Employe(string nom, double salaire) : base(nom)
    {
        this.Salaire = salaire;
    }

    public string Travail()
    {
        return $"{this.Nom} travaille";
    }
}