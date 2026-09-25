using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_SaudeEBemEstar
{
    internal class Trabalho
    {
        static void Main(string[] Usuario_senha)
        {
            //variaveis para serem utilizadas
            int inicio;
            Usuario_senha = new string[2];
            //logar ou se cadastra
            do
            {
                //tela de login
                Console.WriteLine("Seja bem vindo à empresa\n" +
                    "   SAÚDE E BEM ESTAR");
                //Login ou criação de conta
                Console.WriteLine("\n\nVocê deseja:" +
                    "\n1- Fazer login" +
                    "\n2- Cadastra-se");
                inicio = int.Parse(Console.ReadLine());
                Console.Clear();
                if (inicio == 1)
                {
                    login(ref Usuario_senha);
                }
                else if (inicio == 2)
                {
                    cadastrar(ref Usuario_senha);
                    inicio++;
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número compativel: (1 e 2)");
                    inicio = 3;
                }
            }
            while (inicio == 3);
            //tela inicial
            Console.WriteLine(" Bem vido ao nosso sit, \nonde o seu bem estar é a nossa prioridade");
            Console.WriteLine("\n\nAqui você consiguirá marca suas consultas com mais facilidade," +
                "\nconferir preços de consultas e poderá até remarca suas consultas.");
            Console.ReadKey();
            Console.Clear() ;
            //variavel de menu
            int menu=0;
            double orcamento=0;
            string[] consultas_planos = new string[0];
            double[] valores = new double[0];
            int[] datas = new int[0];
            //menu.ultilizei do while para o codigo ser rodado pelo menos uma vez e o usuário poder escolher uma das opções que seram dederminantes para entrar nos if
            do
            {
                Console.WriteLine("             Menu");
                Console.WriteLine("\n\nOpições:" +
                    "\n1- Consultas esporadicas" +
                    "\n2- Pacotes de Checkap" +
                    "\n3- Orçamentos e pagamentos" +
                    "\n4- Dúvidas frequentes" +
                    "\n5- Outras opições" +
                    "\n6- Sair");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                if (menu==1)
                {
                    Consultasesporadicas(ref orcamento, ref consultas_planos, ref valores, ref datas);
                }

                else if (menu==2)
                {
                    Pacotesdecheckap(ref orcamento, ref consultas_planos, ref valores, ref datas);
                }

                else if (menu==3)
                {
                    Orcamentosepagamentos();
                }

                else if (menu==4)
                {
                    Duvidasfrequentes();
                }

                else if (menu==5)
                {
                    Outrasopicoes();
                }
            }
            while (menu!=6);
        }

        public static void Consultasesporadicas(ref double dinheiro, ref string[] consultas, ref double[] precos, ref int[] dias)
        {
            int i, opicoes, k;
            //vou utilizar variáveis alternativas para não perde o que já se tem
            string[] receber = new string[consultas.Length];
            double[] receber_2 = new double[consultas.Length];
            int[] receber_3 = new int[consultas.Length];
            for (i = 0; i < consultas.Length; i++)
            {
                receber[i] = consultas[i];
                receber_2[i] = precos[i];
                receber_3[i] = dias[i];
            }
            //deixar o usuário escolher consultas
            //ultilizar do while para o codigo ser mostrado pelomenos uma vez
            do
            {

                Console.WriteLine("Consultas disponiveis e seus preços e dias até a consulta:" +
                    "\n1- Checkap básico, R$139.00, 15 dias" +
                    "\n2- Odontologia R$109.99, 10 dias" +
                    "\n3- Pediátria R$125.50, 10 dias" +
                    "\n4- Voltar ao menur");
                opicoes = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opicoes == 1)
                {
                    //voltando os elementos já salvos para as variavei e encrementando espaço para novos elementos
                    consultas = new string[consultas.Length + 1];
                    precos = new double[precos.Length + 1];
                    dias = new int[dias.Length + 1];
                    for (i = 0; i < receber.Length; i++)
                    {
                        consultas[i] = receber[i];
                        precos[i] = receber_2[i];
                        dias[i] = receber_3[i];
                    }
                    consultas[consultas.Length - 1] = "Checkap básico";
                    precos[precos.Length - 1] = 139.00;
                    dias[dias.Length - 1] = 15;
                    dinheiro += precos[precos.Length - 1];
                }
                else if (opicoes == 2)
                {
                    //voltando os elementos já salvos para as variavei e encrementando espaço para novos elementos
                    consultas = new string[consultas.Length + 1];
                    precos = new double[precos.Length + 1];
                    dias = new int[dias.Length + 1];
                    for (i = 0; i < receber.Length; i++)
                    {
                        consultas[i] = receber[i];
                        precos[i] = receber_2[i];
                        dias[i] = receber_3[i];
                    }
                    consultas[consultas.Length - 1] = "Odontologia";
                    precos[precos.Length - 1] = 109.99;
                    dias[dias.Length - 1] = 10;
                    dinheiro += precos[precos.Length - 1];
                }
                else if (opicoes==3)
                {
                    //voltando os elementos já salvos para as variavei e encrementando espaço para novos elementos
                    consultas = new string[consultas.Length + 1];
                    precos = new double[precos.Length + 1];
                    dias = new int[dias.Length + 1];
                    for (i = 0; i < receber.Length; i++)
                    {
                        consultas[i] = receber[i];
                        precos[i] = receber_2[i];
                        dias[i] = receber_3[i];
                    }
                    consultas[consultas.Length - 1] = "Pediátria";
                    precos[precos.Length - 1] = 125.50;
                    dias[dias.Length-1] = 10;
                    dinheiro += precos[precos.Length - 1];
                }
                else if (opicoes==4)
                {
                    return;
                }

            }
            while (true);
        }

        public static void Pacotesdecheckap(ref double dinheiro, ref string[] consultas, ref double[] precos, ref int[] dias)
        {
            int i, opicoes, k;
            //vou utilizar variáveis alternativas para não perde o que já se tem
            string[] receber = new string[consultas.Length];
            double[] receber_2 = new double[consultas.Length];
            int[] receber_3 = new int[consultas.Length];
            for (i = 0; i < consultas.Length; i++)
            {
                receber[i] = consultas[i];
                receber_2[i] = precos[i];
                receber_3[i] = dias[i];
            }
            //deixar o usuário escolher os pacotes
            //ultilizar do while para o codigo ser mostrado pelomenos uma vez
            Console.WriteLine("Nossos planos dão direito de checkap a qualquer momento durante sua duração");
            do
            {
                Console.WriteLine("Planos disponiveis, Preços, tempo valido" +
                    "\n1- Plano normal, R$1040.00, 365 dias" +
                    "\n2- Plano primion, 1550.00, 548 dias" +
                    "\n3- Plano primion pro, 2450.00, 913 dias" +
                    "\n4- Voltar ao menur");
                opicoes = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opicoes==1)
                {
                    //voltando os elementos já salvos para as variavei e encrementando espaço para novos elementos
                    consultas = new string[consultas.Length + 1];
                    precos = new double[precos.Length + 1];
                    dias = new int[dias.Length + 1];
                    for (i = 0; i < receber.Length; i++)
                    {
                        consultas[i] = receber[i];
                        precos[i] = receber_2[i];
                        dias[i] = receber_3[i];
                    }
                    consultas[consultas.Length - 1] = "Plano normal";
                    precos[precos.Length - 1] = 1040;
                    dias[precos.Length - 1] = 365;
                    dinheiro += precos[precos.Length - 1];
                }
                else if (opicoes==2)
                {
                    //voltando os elementos já salvos para as variavei e encrementando espaço para novos elementos
                    consultas = new string[consultas.Length + 1];
                    precos = new double[precos.Length + 1];
                    dias = new int[dias.Length + 1];
                    for (i = 0; i < receber.Length; i++)
                    {
                        consultas[i] = receber[i];
                        precos[i] = receber_2[i];
                        dias[i] = receber_3[i];
                    }
                    consultas[consultas.Length - 1] = "Plano primion";
                    precos[precos.Length - 1] = 1550;
                    dias[dias.Length - 1] = 548;
                    dinheiro += precos[precos.Length - 1];
                }
                else if (opicoes==3)
                {
                    //voltando os elementos já salvos para as variavei e encrementando espaço para novos elementos
                    consultas = new string[consultas.Length + 1];
                    precos = new double[precos.Length + 1];
                    dias = new int[dias.Length + 1];
                    for (i = 0; i < receber.Length; i++)
                    {
                        consultas[i] = receber[i];
                        precos[i] = receber_2[i];
                        dias[i] = receber_3[i];
                    }
                    consultas[consultas.Length - 1] = "Plano primion pro";
                    precos[precos.Length - 1] = 2450;
                    dias[dias.Length - 1] = 913;
                    dinheiro += precos[precos.Length - 1];

                }
                else
                {
                    return;
                }
            }
            while (true);
        }

        public static void  Orcamentosepagamentos()
        {

        }

        public static void Duvidasfrequentes()
        {

        }

        public static void Outrasopicoes()
        {

        }

        public static void cadastrar(ref string[] cadastro)
        {
            //cadastrar
            Console.WriteLine("Digite o nome de usuário que deseja utilizar:");
            cadastro[0] = Console.ReadLine();
            Console.WriteLine("Digite sua senha:");
            cadastro[1] = Console.ReadLine();
            Console.WriteLine("\nConta salva!" +
                "\nVamos voltar para a tela de login para seu atendimento ter continuidade");
            Console.ReadKey();
            Console.Clear();

        }

        public static void login(ref string[] logar)
        {
            //login
            Console.WriteLine("Vamos começar o login:");
            Console.Clear();

            //variaveis
            string usuario, senha;
            int contar = 0;
            //não se cadastrou
            if (logar[0] == null)
            {
                //voltar ao cadastro


                Console.WriteLine("Talvez você tenha se esquecido de se cadastrar, vamos nos cadastrar");
                contar = 1;
                Console.ReadKey();
                Console.Clear();
                if (contar == 1)
                {

                    cadastrar(ref logar);
                    
                }


            }
            //usuário
            do
            {
                Console.WriteLine("Digite seu usuário");
                usuario = Console.ReadLine();
                if (usuario.ToLower() != logar[0].ToLower())
                {
                    Console.WriteLine("Usuário incorreto, escreva novamente");
                    Console.ReadKey();
                    
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
            while (true);

            //senha

            do
            {
                Console.WriteLine("Digite sua senha:");
                senha = Console.ReadLine();
                if (senha != logar[1])
                {
                    Console.WriteLine("Senha incorreta, tente novamente");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear(); break;
                }
            }
            while (true);
        }
    }
}
