using System;
using System.Collections.Generic;

namespace HeroClub.WebAPI.Dtos
{
    public class BatalhaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public List<EquipeHeroiBatalhaDto> EquipeHeroiBatalhas { get; set; }
    }
}