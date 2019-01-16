namespace HeroClub.WebAPI.Dtos
{
    public class EquipeHeroiBatalhaDto
    {
        public HeroiDto Heroi { get; set; }
        public int HeroiId { get; set; }
        public EquipeDto Equipe { get; set; }
        public int EquipeId { get; set; }
        public BatalhaDto Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}