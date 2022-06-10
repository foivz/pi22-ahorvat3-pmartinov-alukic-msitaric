namespace BookfrizApp.Classes
{
    public class FrizerskiSalon
    {
        public int IdFrizerski { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public Gradd Grad { get; set; }
        public float Ocjena { get; set; }
        public FrizerskiSalon()
        {

        }
    }
}
