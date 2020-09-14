using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.Model
{
   public class Cadastro
    {


        public void Cadastrar(string Nome, string Sobrenome, string Cpf, string DataNascimento, string Cep, string Endereco,
          string Numero, string Complemento, string Cidade, string Estado)
        {
            StreamWriter Arquivo;
            Arquivo = new StreamWriter(@"C:\Users\Frango\Desktop\testewpf\teste.txt");
            Arquivo.WriteLine("Nome: " + Nome.Trim());
            Arquivo.WriteLine("Sobrenome: " + Sobrenome.Trim());
            Arquivo.WriteLine("Cpf: " + Cpf.Trim());
            Arquivo.WriteLine("DataNascimento: " + DataNascimento.Trim());
            Arquivo.WriteLine( Endereco.Trim() + "," + Numero.Trim() + "/" + Complemento.Trim() + "-" + Cidade.Trim() + "/" + Estado.Trim() + "-" + Cep.Trim() );       
            Arquivo.Close();
        }


    }
}
