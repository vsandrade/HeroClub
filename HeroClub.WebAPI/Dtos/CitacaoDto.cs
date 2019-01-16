using System;

namespace HeroClub.WebAPI.Dtos
{
    public class CitacaoDto
    {
        
        public int Id { get; set; }
        public string Descricao { 
            get {
                return Descricao;
            }
            set {
                if (Batalha.DataFim != null)
                    Descricao = value;
            } 
        }
        public DateTime Data { get; set; }        
        public HeroiDto Heroi { get; set; }
        public int HeroiId { get; set; }
        public BatalhaDto Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}