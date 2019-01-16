using System;

namespace HeroClub.Domain
{
    public class Foto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descricao { get; set; }
        public DateTime DateAdicionada { get; set; }
        public bool Principal { get; set; }
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
    }
}