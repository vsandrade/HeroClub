namespace HeroClub.Domain
{
    public class EquipeHeroi
    {
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
        public Equipe Equipe { get; set; }
        public int EquipeId { get; set; }
        public bool Lider { get; set; }
    }
}