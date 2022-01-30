using System;

namespace ControleDeBanco.Models
{
    public class Apontamento
    {
        public int Id { get; set; }
        public DateOnly Data { get; set; }
        public TimeOnly? HorasTrabalhadas { get; set; }
        public TimeOnly? HorasTiradas { get; set; }
        public string Descricao { get; set; }
    }
}
