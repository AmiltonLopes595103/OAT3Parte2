


using SegundaListaPart2.cs;

class Main
{
    public static void Main(string[] args)
    {

        int opcao;

        do
        {


            Console.WriteLine("=====================================");
            Console.WriteLine("|(11) TROCA DE VALORES               |");
            Console.WriteLine("|(12) Modulo de um numero            |");
            Console.WriteLine("|(13) Numeros em decrescente         |");
            Console.WriteLine("|(15) AlunoAprovadoReprovado         |");
            Console.WriteLine("|(16) Maior menor ou igual           |");
            Console.WriteLine("|(17) DentroOuForadoLimite           |");
            Console.WriteLine("|(18) Codigo valido ou inValido      |");
            Console.WriteLine("|(19) Calculo dos lados dotriangulo  |");
            Console.WriteLine("|(20) Numero valido ou invalido      |");
            Console.WriteLine("|(21) Verificar numero               |");
            Console.WriteLine("|(22) Positivo ou negativo           |");
            Console.WriteLine("|(23) Quatro operacoes               |");
            Console.WriteLine("|(24) Calculo multiplo  par e média  |");
            Console.WriteLine("|(25) Peso ideal                     |");
            Console.WriteLine("|(26) Numeros em ordem decresc       |");
            Console.WriteLine("|(27) Fatorial do numero             |");
            Console.WriteLine("|(28) Números impares entre 100 e 200|");
            Console.WriteLine("|(29) Numeros de 1 ate 200           |");
            Console.WriteLine("|(30) Tabuada                        |");
            Console.WriteLine("|(32) Soma  dos quadrados            |");
            Console.WriteLine("|(33) Media notas                    |");
            Console.WriteLine("|(34) Maior e menor valor            |");
            Console.WriteLine("|(0) Sair!                           |");
            Console.WriteLine("=====================================");
            Console.Write("ESCOLHA UMA OPÇÃO: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 11:
                    ExerciciosP2 objexercicio11 = new ExerciciosP2();
                    objexercicio11.TrocadeValores();
                    break;

                case 12:

                    ExerciciosP2 objexercicio12 = new ExerciciosP2();
                    objexercicio12.ModuloNumero();

                    break;

                case 13:
                    ExerciciosP2 objexercicio13 = new ExerciciosP2();
                    objexercicio13.NumerosOrdemDecrescente();

                    break;
                case 14:
                    ExerciciosP2 objexercicio14 = new ExerciciosP2();
                    objexercicio14.MaioreMenorNumero();

                    break;

                case 15:
                    ExerciciosP2 objexercicio15 = new ExerciciosP2();
                    objexercicio15.AlunoAprovadoReprovado();



                    break;

                case 16:
                    ExerciciosP2 objexercicio16 = new ExerciciosP2();
                    objexercicio16.MaiorMenorouIgual();
                    break;

                case 17:

                    ExerciciosP2 objexercicio17 = new ExerciciosP2();
                    objexercicio17.DentroOuForadoLimite();

                    break;
                case 18:
                    ExerciciosP2 objexercicio18 = new ExerciciosP2();
                    objexercicio18.CodigoValidoInValido();


                    break;
                case 19:
                    ExerciciosP2 objexercicio19 = new ExerciciosP2();
                    objexercicio19.LadosDoTriangulo();



                    break;

                case 20:

                    ExerciciosP2 objexercicio20 = new ExerciciosP2();
                    objexercicio20.numeroValidoOuInvalido();


                    break;

                case 21:

                    ExerciciosP2 objexercicio21 = new ExerciciosP2();
                    objexercicio21.VerificarNumero();
                    break;

                case 22:

                    ExerciciosP2 objexercicio22 = new ExerciciosP2();
                    objexercicio22.PositivoNegativo();
                    break;

                case 23:

                    ExerciciosP2 objexercicio23 = new ExerciciosP2();
                    objexercicio23.QuatroOperacoes();
                    break;
                case 24:

                    ExerciciosP2 objexercicio24 = new ExerciciosP2();
                    objexercicio24.CalculoMultiploParMedia();
                    break;
                case 25:

                    ExerciciosP2 objexercicio25 = new ExerciciosP2();
                    objexercicio25.PesoIdeal();
                    break;
                case 26:

                    ExerciciosP2 objexercicio26 = new ExerciciosP2();
                    objexercicio26.ExibindoNumerosOrdemDecresc();
                    break;
                case 27:
                    ExerciciosP2 objexercicio27 = new ExerciciosP2();
                    objexercicio27.FatorialDoNumero();


                    break;
                case 28:

                    ExerciciosP2 objexercicio28 = new ExerciciosP2();
                    objexercicio28.ImparesEntre100e200();
                    break;

                case 29:

                    ExerciciosP2 objexercicio29 = new ExerciciosP2();
                    objexercicio29.Numeros1ate200();
                    break;
                case 30:

                    ExerciciosP2 objexercicio30 = new ExerciciosP2();
                    objexercicio30.Tabuada();
                    break;
                case 31:

                    ExerciciosP2 objexercicio31 = new ExerciciosP2();
                    objexercicio31.ParesImpares();
                    break;
                case 32:

                    ExerciciosP2 objexercicio32 = new ExerciciosP2();
                    objexercicio32.SomaDosQuadrados();
                    break;
                case 33:

                    ExerciciosP2 objexercicio33 = new ExerciciosP2();
                    objexercicio33.MediaNotas();
                    break;



                case 34:

                    ExerciciosP2 objexercicio34 = new ExerciciosP2();
                    objexercicio34.MaiorMenorValor();
                    break;
                case 0:
                    Console.WriteLine("Sair!");
                    break;

                default:
                    Console.WriteLine("Opção Invalida!");

                    break;











            }

        } while (opcao!=0);
    }
}