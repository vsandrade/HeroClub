using System;
using System.Collections.Generic;

namespace HeroClub.Domain
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Descricao { get; set; }
        public List<EquipeHeroi> EquipeHerois { get; set; }
        public List<EquipeHeroiBatalha> EquipeHeroiBatalhas { get; set; }
    }
}