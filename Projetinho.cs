 public static  string nome, endereco, telefone, fax, email, titulo, valor_da_tabela_cadastro, valor_tabela_locacao;
      public static string sair;
      public static int i, totallivros;

        public static void CADASTRO_CLIENTE()
        {

            Console.Clear(); //=======COR===============================================================
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("                         ====•CADASTRO DE CLIENTES====");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("♦ Entre com o nome do Aluno: ");
            nome = Console.ReadLine();

            Console.Write("♦ Entre com o endereço do Aluno: ");
            endereco = Console.ReadLine();

            Console.Write("♦ Entre com o telefone do Aluno: ");
            telefone = Console.ReadLine();

            Console.Write("♦ Entre com o fax do Aluno: ");
            fax = Console.ReadLine();

            Console.Write("♦ Entre com o email do Aluno: ");
            email = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("O CADASTRO DO ALUNO " + "'" + nome + "'" + " FOI REALIZADO COM SUCESSO!");
            Console.WriteLine("");
            Console.WriteLine("╔════════════════════════════╗");
            Console.WriteLine("║'S' = CADASTRAR MAIS ALUNOS ║");
            Console.WriteLine("║'X' = EXCLUIR CADASTRO      ║");
            Console.WriteLine("║'E' = EDITAR CADASTRO       ║");
            Console.WriteLine("║'M' = VOLTAR AO MENU        ║");
            Console.WriteLine("╚════════════════════════════╝");



        }
        static void Main(string[] args)
        {
            
            i = 0;
            totallivros = 0;

            while (true)
            {
            
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ PROJETINHO ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            Console.WriteLine("");

            Console.WriteLine("");

            Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗    ");

            Console.WriteLine("║ 1 CADASTRO DE CLIENTES                        ║    ");

            Console.WriteLine("║                                               ║    ");

            Console.WriteLine("║ 2 LOCAÇÃO                                     ║    ");

            Console.WriteLine("║                                               ║    ");

            Console.WriteLine("║ 3 CADASTRO DE LIVROS                          ║    ");

            Console.WriteLine("║                                               ║    ");

            Console.WriteLine("║ 4 BIBLIOTECA                                  ║    ");

            Console.WriteLine("║                                               ║    ");

            Console.WriteLine("║ 5 CONFIGURAÇÃO                                ║    ");

            Console.WriteLine("║                                               ║    ");

            Console.WriteLine("║ 6 SAIR                                        ║    ");

            Console.WriteLine("╚═══════════════════════════════════════════════╝    ");

            Console.WriteLine(" ");


            Console.Write("DIGITE UMA OPÇÃO : ");


            //============================CADASTRO DE CLIENTES==============================================
            var leitura = Console.ReadLine();


            if (leitura == "1")
            {
                CADASTRO_CLIENTE();
               
            }

            string teste = Convert.ToString(Console.ReadLine());
            if (teste == "S")
            {
                Console.Clear();
                CADASTRO_CLIENTE();
            }
            else
            {
                Console.Clear();
                Console.ReadKey();
            }


            }

        }