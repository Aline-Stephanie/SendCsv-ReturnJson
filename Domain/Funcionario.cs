﻿namespace Domain
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public int Codigo { get; set; }
        public decimal TotalReceber { get; set; }
        public TimeSpan HorasExtras { get; set; }
        public TimeSpan HorasDebito { get; set; }
        public int DiasFalta { get; set; }
        public int DiasExtras { get; set; }
        public int DiasTrabalhados { get; set; }
    }
}
