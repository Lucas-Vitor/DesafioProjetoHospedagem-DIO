using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
      // Código implementado aqui**
      if (hospedes.Count <= Suite.Capacidade) //(true)
      {
        Hospedes = hospedes;
      }
      else
      {
        // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
        // Código implementado aqui**
        throw new Exception("Não será possível realizar o cadastro, pois o número de hóspedes está ultrapassando a capacidade permitida.");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
      // *Código implementado aqui**
      return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
      // TODO: Retorna o valor da diária
      // Cálculo: DiasReservados X Suite.ValorDiaria
      // Código implementado aqui**
      decimal valor = 0;
      valor = DiasReservados * Suite.ValorDiaria;


      // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
      // Código implementado aqui**
      if (DiasReservados >= 10)
      {
        valor = valor - (valor * 10) / 100;
      }

      return valor;
    }
  }
}