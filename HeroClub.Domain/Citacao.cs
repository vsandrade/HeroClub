using System;

namespace HeroClub.Domain
{
    public class Citacao
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
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
        public Batalha Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}