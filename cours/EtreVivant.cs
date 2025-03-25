class EtreVivant
{
    public DateTime DateNaissance { get; set; }
    public EtreVivant ()
    {
        this.DateNaissance = DateTime.Now;
    }

    public EtreVivant (DateTime dateNaissance)
    {
        this.DateNaissance = dateNaissance;
    }

    public int GetAge ()
    {
        var dateNaissance = this.DateNaissance.Year;
        DateTime now = DateTime.Now;
        var age = now.Year - dateNaissance;
        return age;
    }


}

static class Helper
{
    public static void Test(int valeur)
    {
        valeur++;
    }

    public static void TestEtreVivant(EtreVivant etreVivant)
    {
        etreVivant.DateNaissance = etreVivant.DateNaissance.AddYears(1);
    }
}