using System;

namespace HeroClub.WebAPI.Dtos
{
    public class FotoDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descricao { get; set; }
        public DateTime DateAdicionada { get; set; }
        public bool Principal { get; set; }
        public HeroiDto Heroi { get; set; }
        public int HeroiId { get; set; }
    }
}