
using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models;

public class CalculoImc
{
    [Display(Name = "Peso")]
    [Required(ErrorMessage = "Informe um peso")]
    [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Informe um peso válido!")]
    public double Peso { get; set; }

    [Display(Name = "Altura")]
    [Required(ErrorMessage = "Informe uma altura ")]
    [RegularExpression(@"^\d+.?\d{1,2}$", ErrorMessage = "Informe uma altura válido!")]
    public double Altura { get; set; }

    [Display(Name = "IMC")]
    [DisplayFormat(DataFormatString = "{0:#.##}")]
    public double Imc { get => Calcular(); }

    private double Calcular()
    {
        return Peso / (Altura * Altura);
    }

}