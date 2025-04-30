using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class ClienteInformation
    {
        private int IdCliente { get; set; }
        private DateTime DataCadastro { get; set; }
        private string Cliente { get; set; }
        private  string CPF { get; set; }
        private string RG { get; set; }
        private string EmailCliente { get; set; }
        private string EstadoCivil { get; set; }
        private DateTime DatadeNascimento { get; set; }
        private string Endereco { get; set; }
        private int Numero { get; set; }
        private string Bairro { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private string CEP { get; set; }
        private string Telefone1 { get; set; }
        private string Telefone2 { get; set; }
        private string Referencias { get; set; }
        private string Observacao { get; set; }
    }
}
