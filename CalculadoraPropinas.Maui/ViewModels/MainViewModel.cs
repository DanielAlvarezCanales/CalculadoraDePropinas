using CalculadoraPropinas.Maui.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPropinas.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        //Entrada de datos
        [ObservableProperty]
        private string _importeDelConsumo = string.Empty;
        [ObservableProperty]
        private string _numeroDePersonas = "1";
        [ObservableProperty]
        private string _porcentajeDePropina = "10";

        //Resultados
        [ObservableProperty]
        private string _importeDelConsumoPorPersona = string.Empty;
        [ObservableProperty]
        private string _importeDeLaPropina = string.Empty;
        [ObservableProperty]
        private string _importeDeLaPropinaPorPersona = string.Empty;
        [ObservableProperty]
        private string _importeDelConsumoConPropina = string.Empty;
        [ObservableProperty]
        private string _importeDelConsumoConPropinaPorPersona = string.Empty;


        public MainViewModel()
        {
            ImporteDelConsumo = string.Empty;
            NumeroDePersonas = "1";
            PorcentajeDePropina = "10";
        }
        


        [RelayCommand]
        public void Calcular()
        {
            decimal importeDelConsumo;
            int numeroDePersonas;
            decimal porcentajeDePropina;

            bool importeDelConsumoEsValido = decimal.TryParse(ImporteDelConsumo, out importeDelConsumo);

            bool numeroDePersonasEsValido = int.TryParse(NumeroDePersonas, out numeroDePersonas);

            bool porcentajeDePropinaEsValido = decimal.TryParse(PorcentajeDePropina, out porcentajeDePropina);

            if (importeDelConsumoEsValido && numeroDePersonasEsValido && porcentajeDePropinaEsValido) 
            {
                var consumo = new ConsumoCompartido(importeDelConsumo, numeroDePersonas, porcentajeDePropina);
                ImporteDelConsumoPorPersona = consumo.ImporteDelConsumoPorPersona.ToString("C2");
                ImporteDeLaPropina = consumo.ImporteDeLaPropina.ToString("C2");
                ImporteDeLaPropinaPorPersona = consumo.ImporteDeLaPropinaPorPersona.ToString("C2");
                ImporteDelConsumoConPropina = consumo.ImporteDelConsumoConPropina.ToString("C2");
                ImporteDelConsumoConPropinaPorPersona = consumo.ImporteDelConsumoConPropinaPorPersona.ToString("C2");
            }

        }
        [RelayCommand]
        public void CambiarPorcentajeDePropina(string nuevoPorcentajeDePropina)
        {
            PorcentajeDePropina = nuevoPorcentajeDePropina;
        }
        [RelayCommand]
        public void Limpiar()
        {

            ImporteDelConsumo = string.Empty;
            NumeroDePersonas = "1";
            PorcentajeDePropina = "10";

            ImporteDelConsumoPorPersona = string.Empty;
            ImporteDeLaPropina = string.Empty;
            ImporteDeLaPropinaPorPersona = string.Empty;
            ImporteDelConsumoConPropina = string.Empty;
            ImporteDelConsumoConPropinaPorPersona = string.Empty;

        }

    }
}
