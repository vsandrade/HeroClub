using System;

namespace HeroClub.WebAPI.Dtos
{
    public class FotoForDatailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAdicionada { get; set; }
        public bool Principal { get; set; }
    }
}