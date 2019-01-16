namespace HeroClub.WebAPI.Dtos
{
    public class EquipeHeroiDto
    {
        public HeroiDto Heroi { get; set; }
        public int HeroiId { get; set; }
        public EquipeDto Equipe { get; set; }
        public int EquipeId { get; set; }
        public bool Lider { get; set; }
    }
}