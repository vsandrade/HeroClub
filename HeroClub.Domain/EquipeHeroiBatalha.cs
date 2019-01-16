namespace HeroClub.Domain
{
    public class EquipeHeroiBatalha
    {
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
        public Equipe Equipe { get; set; }
        public int EquipeId { get; set; }
        public Batalha Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}