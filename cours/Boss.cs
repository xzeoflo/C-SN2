class Boss : Employe
{
    public Boss(string nom, double salaire) : base(nom, salaire)
    {

    }

    public new string Travail() 
        {
            return $"{Nom} ZZ $$ ZZ";
        }
    
    public void Augmente(Employe employe)
    {
        employe.Salaire += 1000;
    }
}