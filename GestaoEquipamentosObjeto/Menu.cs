using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    class Menu
    {
        public void mensagemErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ResetColor(); ;
        }
        public void CabecalhoChamado()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,-10} | {1,-30} | {2,-55} | {3,-25}", "Id", "Equipamento", "Título", "Dias em Aberto");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }
        public string ObterOpcaoCadastroEquipamentos()
        {
            Console.WriteLine("=================Equipamento==================");
            Console.WriteLine("=                                            =");
            Console.WriteLine("=                  Digite:                   =");
            Console.WriteLine("=                                            =");
            Console.WriteLine("=       1 para inserir novo equipamento      =");
            Console.WriteLine("=       2 para visualizar equipamentos       =");
            Console.WriteLine("=       3 para editar um equipamento         =");
            Console.WriteLine("=       4 para excluir um equipamento        =");
            Console.WriteLine("=                S para sair                 =");
            Console.WriteLine("=                                            =");
            Console.WriteLine("==============================================");

            string opcao = Console.ReadLine();

            return opcao;
        }
        public string ObterMenuPrincipal()
        {
            Console.WriteLine("=================Menu Inicial==================");
            Console.WriteLine("=                                             =");
            Console.WriteLine("=                   Digite:                   =");
            Console.WriteLine("=                                             =");
            Console.WriteLine("=      1 para o Cadastro de Equipamentos      =");
            Console.WriteLine("=      2 para o Controle de Chamados          =");
            Console.WriteLine("=               S para Sair                   =");
            Console.WriteLine("=                                             =");
            Console.WriteLine("===============================================");

            string opcao = Console.ReadLine();
            return opcao;
        }
        public string ObterOpcaoControleChamados()
        {
            Console.WriteLine("=================Chamados==================");
            Console.WriteLine("=                                         =");
            Console.WriteLine("=                Digite:                  =");
            Console.WriteLine("=                                         =");
            Console.WriteLine("=       1 para inserir novo chamado       =");
            Console.WriteLine("=       2 para visualizar chamados        =");
            Console.WriteLine("=       3 para editar um chamado          =");
            Console.WriteLine("=       4 para excluir um chamado         =");
            Console.WriteLine("=            S para sair                  =");
            Console.WriteLine("=                                         =");
            Console.WriteLine("===========================================");


            string opcao = Console.ReadLine();

            return opcao;
        }
        public bool EhOpcaoSair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }
        public bool EhOpcaoInvalidaMenuPrincipal(string opcao)
        {
            return opcao != "1" && opcao != "2";
        }
        public bool EhOpcaoInvalidaSubMenu(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4";
        }
    }
}
