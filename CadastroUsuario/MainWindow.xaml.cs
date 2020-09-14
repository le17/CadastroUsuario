using CadastroUsuario.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CadastroUsuario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

      
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Cadastro arquivoTXT = new Cadastro();
            arquivoTXT.Cadastrar(Txt_Nome.Text, Txt_Sobrenome.Text, Txt_Cpf.Text, Txt_Datanascimento.Text, Txt_Cep.Text, Txt_Endereco.Text, Txt_Numero.Text, Txt_Complemento.Text,
                Txt_Cidade.Text, Txt_Estado.Text);

            List<string> list = new List<string>();


            list.Add("Nome : " + Txt_Nome.Text);
                list.Add("Sobrenome : " + Txt_Sobrenome.Text);
                list.Add("CPF : " + Txt_Cpf.Text);
                list.Add("Data Nascimento : " + Txt_Datanascimento.Text);
                list.Add("CEP : " + Txt_Cep.Text);
                list.Add("Endereço : " + Txt_Endereco.Text);
                list.Add("Numero : " + Txt_Numero.Text);
                list.Add("Complemento  : " + Txt_Complemento.Text);
                list.Add("Cidade : " + Txt_Cidade.Text);
                list.Add("Estado : " + Txt_Estado.Text);

                foreach (var item in list)
            {
                lista.Text += " \n " + item;
            }

            MessageBox.Show("Salvo com Sucesso!!");

            Txt_Nome.Clear();
            Txt_Sobrenome.Clear();
           
            Txt_Cpf.Clear();
            Txt_Cep.Clear();
            Txt_Endereco.Clear();
            Txt_Numero.Clear();
            Txt_Complemento.Clear();
            Txt_Cidade.Clear();
            Txt_Estado.Clear();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 main = new Window1();
            main.ShowDialog();


        }
    }
}
