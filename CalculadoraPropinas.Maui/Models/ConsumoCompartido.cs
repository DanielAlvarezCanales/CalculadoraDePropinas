namespace CalculadoraPropinas.Maui.Models
{
    public class ConsumoCompartido
    {
        public decimal ImporteDelConsumo { get; set; } = decimal.Zero;
        public int NumeroDePersonas { get; set; } = 1;

        public decimal PorcentajeDePropina { get; set; } = 10m;


        public ConsumoCompartido( decimal importedelconsumo, int numeroDePersonas =1, decimal porcentajeDePropina = 10.0m)
        { 
            ImporteDelConsumo = importedelconsumo;
            NumeroDePersonas = numeroDePersonas;
            PorcentajeDePropina= porcentajeDePropina;
        
        }

        public decimal ImporteDelConsumoPorPersona => ImporteDelConsumo / NumeroDePersonas;

        public decimal ImporteDeLaPropina => ImporteDelConsumo * PorcentajeDePropina / 100.0m;

        public decimal ImporteDeLaPropinaPorPersona => ImporteDelConsumo / NumeroDePersonas;

        public decimal ImporteDelConsumoConPropina => ImporteDelConsumo + ImporteDeLaPropina;

        public decimal ImporteDelConsumoConPropinaPorPersona => ImporteDelConsumoConPropina / NumeroDePersonas;
    }
}
