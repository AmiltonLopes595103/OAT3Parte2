using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SegundaListaPart2.cs
{
    class ExerciciosP2
    {

        //Nivel 2: Estruturas condicionais.
        public void TrocadeValores()
        {
            int valorA;
            int valorB;
            int aux;

            Console.WriteLine("INFORME O VALOR DE A: ");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("INFORM O VALOR DE B: ");
            valorB = int.Parse(Console.ReadLine());
            aux = valorA;
            valorA = valorB;
            valorB = aux;

            Console.WriteLine();
            Console.WriteLine("AGORA OS VALORES TRERÃO SUAS POSIÇÕES INVERTIDAS: ");
            Console.WriteLine("VALOR A: " + valorA);
            Console.WriteLine("VALOR B: " + valorB);


        }

        public void ModuloNumero()
        {
            int x;
            int modulo;
            Console.WriteLine("DIGITE UM NÚMERO INTEIRO: ");
            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                modulo = x * (-1);

                Console.WriteLine("O MODULO DPO NÚMERO É: " + modulo);


            }
            else
            {
                modulo = x;
                Console.WriteLine("O MODULO DPO NÚMERO É: " + modulo);
            }
        }

        public void NumerosOrdemDecrescente()
        {
            int num1;
            int num2;
            int num3;
            int aux;

            Console.WriteLine("INFORME O PRIMEIRO NUMERO INTEIR: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INFORME O SEGUNDO NUMERO INTEIR: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("INFORME O TERCEIRO NUMERO INTEIR: ");
            num3 = int.Parse(Console.ReadLine());

            if (num3 > num1)
            {
                aux = num1;//se o utimo numero for o maio então ele vem pra primeira posição.
                num1 = num3;
                num3 = aux;

            }
            else if (num2 > num1)
            {
                /*senão se o penutimo numero for o maior então ele vem pra primeira posição
                 e assim esse teste sera feito com todos os numeros ate que tenhamos todos os numeros
                 organizados em oredem decrescente do maior >  pro menor <. Essa é a lógica*/

                aux = num1;
                num1 = num2;
                num2 = aux;

            }
            Console.WriteLine("Exibindo os números em ordem decrescente:" + "\n" + num1 + "\n" +
                +num2 + "\n" + num3);
        }



        public void MaioreMenorNumero()
        {
            //14

            int num1, num2;

            Console.WriteLine("INFORME O PRIMEIRO NÚMERO: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INFORME O SEGUNDO NÚMERO: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("O MAIOR NÚMERO É: " + num1);
                Console.WriteLine("O MENOR NUMERO É: " + num2);

            }
            else
            {

                Console.WriteLine("O MAIOR NÚMERO É: " + num2);
                Console.WriteLine("O MENOR NUMERO É: " + num1);

            }
        }

        public void AlunoAprovadoReprovado()
        {
            //15
            double nota1, nota2, nota3, nota4, notaRec, soma, media, mediaFinal;

            Console.WriteLine("INFOME O VALOR DA PRIMEIRA NOTA: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("INFOME O VALOR DA SEGUNDA NOTA: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("INFOME O VALOR DA TERCEIRA NOTA: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("INFOME O VALOR DA QUARTA NOTA: ");
            nota4 = double.Parse(Console.ReadLine());


            soma = nota1 + nota2 + nota3 + nota4;
            media = soma / 4;

            if (media >= 7)
            {
                Console.WriteLine("O ALUNO FOI APROVADO COM MÉDIA: " + media);

            }
            else if (media < 7)
            {
                Console.WriteLine("O ALUNO AINDA NÃO ATINGIL A MÉDIA NECESSÁRIA");
                Console.WriteLine("INFORME A NOTA DE RECUPERAÇÃO: ");
                notaRec = double.Parse(Console.ReadLine());
                mediaFinal = (notaRec + media) / 2;
                if (mediaFinal >= 7)
                {
                    Console.WriteLine("O ALUNO FOI APROVADO NA RECUPERAÇÃO");

                }
                else
                {
                    Console.WriteLine("O ALUNO FOI REPROVADO.");
                }

            }




        }


        public void MaiorMenorouIgual()
        {
            //16
            int num1, num2;

            Console.WriteLine("INFORME O PRIMEIRO NÚMERO: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INFORME O SEGUNDO NÚMERO: ");
            num2 = int.Parse(Console.ReadLine());

            ; if (num1 > num2)
            {
                Console.WriteLine("O MAIOR NÚMERO É: " + num1);
                Console.WriteLine("O MMENOR  NÚMERO É: " + num2);


            }
            else if (num2 > num1)
            {

                Console.WriteLine("O MAIOR NÚMERO É: " + num2);
                Console.WriteLine("O MAIOR MENOR É: " + num1);


            }
            else
            {
                Console.WriteLine("OS NÚMEROS SÃO IGUAIS!");
            }
        }

        public void CodigoValidoInValido()
        {
            //18

            int codigo;

            Console.WriteLine("IFORME O CÓDIGO: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("O CODIGO ISERIDO FOI: 'UM' ");

                    break;
                case 2:
                    Console.WriteLine("O CODIGO INSERIDO FOI: 'DOIS'");
                    break;
                case 3:
                    Console.WriteLine("O CODIGO INSERIDO FOI: 'TRÊS'");
                    break;

                default:
                    Console.WriteLine("CÓDIGO INVALIDO!");
                    break;

            }

        }

        public void DentroOuForadoLimite()
        {

            //17

            int num;
            Console.Write("INFORME UM NÚMERO INTEIRO QUE" + "\n" +
                "ESTEJA DENTRO DO INTERVELO DE 0 A 9: ");
            num = int.Parse(Console.ReadLine());

            if ((num >= 0) && (num <= 9))//Neste caso utilizamos o operador && junção pois precisamos que
                                         //as duas cindções sejam atendidas.
            {
                Console.WriteLine();
                Console.WriteLine("VALOR VALIDO!");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NÚMERO IVALIDO!");

            }



            /*if ((num <0) || (num>9))
            {
                Console.WriteLine();
                Console.WriteLine("NÚMERO IVALIDO!");


            }*/

        }

        public void LadosDoTriangulo()
        {
            //19
            int ladoA, ladoB, ladoC, soma;
            int AB = 0, BC = 0, AC = 0;

            Console.WriteLine("INFOME O VALOR DO LADO A: ");
            ladoA = int.Parse(Console.ReadLine());
            Console.WriteLine("INFOME O VALOR DO LADO B: ");
            ladoB = int.Parse(Console.ReadLine());
            Console.WriteLine("INFOME O VALOR DO LADO C: ");
            ladoC = int.Parse(Console.ReadLine());
            AB = ladoA + ladoB;
            BC = ladoB + ladoC;
            AC = ladoA + ladoC;


            if ((ladoA < BC) && (ladoB < AC) && (ladoC < AB))
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("O TRIÂNGULO É EQUILATERO");

                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("O TRIÂNGULO É ISÓCELES");

                }
                else
                {
                    Console.WriteLine("O TRIÂNGULO É ESCALENO");
                }

            }
            else
            {
                Console.WriteLine("OS LADOS FORNECIDOS NÃO CARACTERIZAM UM TRIÂNGULO ");

            }
        }

            public void numeroValidoOuInvalido()
            {
                //20
                int a, b, c, aux, multiplicar, dividir;

                Console.WriteLine("INFORME O VALOR DE A, O VALOR DEVE SER MAIOR QUE 0: ");
                a = int.Parse(Console.ReadLine());
                do
                {
                    if (a == 0)
                    {
                        Console.WriteLine("VALOR INVALIDO! INFORME UM VALOR VALIDO:");
                        a = int.Parse(Console.ReadLine());
                    }


                } while (a == 0);


                Console.WriteLine("INFORME O VALOR DE B, O VALOR DEVE SER MAIOR QUE 0: ");
                b = int.Parse(Console.ReadLine());
                do
                {
                    if (b == 0)
                    {
                        Console.WriteLine("VALOR INVALIDO! INFORME UM VALOR VALIDO:");
                        b = int.Parse(Console.ReadLine());
                    }


                } while (b == 0);

                Console.WriteLine("INFORME O VALOR DE C, O VALOR DEVE SER MAIOR QUE 0: ");
                c = int.Parse(Console.ReadLine());

                do
                {
                    if (c == 0)
                    {
                        Console.WriteLine("VALOR INVALIDO! INFORME UM VALOR VALIDO:");
                        c = int.Parse(Console.ReadLine());
                    }


                } while (c == 0);


                //Encontrar o menor valor
                if (c < a)
                {
                    aux = a;
                    a = c;
                    c = aux;

                } else if (b < a)
                {
                    aux = a;
                    a = b;
                    b = aux;

                }
                //Encontrar o maior valor
                if (c > b)
                {
                    aux = b;
                    b = c;
                    c = aux;

                }

                multiplicar = a * b;
                dividir = b / a;
                Console.WriteLine("O MENOR VALOR É: " + a);
                Console.WriteLine("O MAIOR VALOR É: " + b);
                Console.WriteLine("MULTIPLICANDO " + a + " POR " + b + " O RESULTDO È: " + multiplicar);
                Console.WriteLine("DIVIDINDO " + b + " POR " + a + " O RESULTDO È: " + dividir);




            }

            public void VerificarNumero()
            {
                //21
                int num, opcao;

                Console.WriteLine("DIGITE UM NUMERO INTEIRO:");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {

                    Console.WriteLine("O NÚMERO INFORMADO É POSITIVO: " + num);
                    Console.WriteLine();
                }
                else if (num < 0)
                {

                    Console.WriteLine("O NÚMERO INFORMADO É NEGATIVO: " + num);
                    Console.WriteLine();

                }

                // else if ((opcao != 1) && (opcao != 0))//Primeiro conjunto de parenteses é do if
                //ja os parenteses de dentro do if pertecem a condicção if =((cindição 1) && (condição 2) = condição dentro do if)

                do
                {
                    Console.WriteLine("O QUE VOCE DESEJA FAZER:   ");
                    Console.WriteLine("(1) CONSULTAR OUTRO NÚMERO");
                    Console.WriteLine("(0) SAIR ");
                    Console.WriteLine("ESCOLHA UMA OPÇÃO:");
                    opcao = int.Parse(Console.ReadLine());



                    switch (opcao)
                    {

                        case 1:

                            Console.WriteLine("DIGITE UM NUMERO INTEIRO:");
                            num = int.Parse(Console.ReadLine());

                            if (num > 0)
                            {

                                Console.WriteLine("O NÚMERO INFORMADO É POSITIVO: " + num);
                                Console.WriteLine();
                            }
                            else if (num < 0)
                            {

                                Console.WriteLine("O NÚMERO INFORMADO É NEGATIVO: " + num);
                                Console.WriteLine();

                            }
                            break;


                        case 0:
                            Console.WriteLine("SAIR!");
                            break;

                        default:

                            Console.WriteLine("OPÇÃO INVALIDA!");
                            Console.WriteLine();
                            Console.WriteLine("(1) CONSULTAR OUTRO NÚMERO:");
                            Console.WriteLine("(0) SAIR ");
                            opcao = int.Parse(Console.ReadLine());




                            break;



                    }
                } while (opcao != 0);

            }

            public void PositivoNegativo()
            {
                //22
                int num, A, B;

                Console.WriteLine("DIGITE UM NUMERO INTEIRO:");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    A = num;
                    Console.WriteLine("O VALONR DE A É POSITIVO: " + A);
                }
                else if (num < 0)
                {
                    B = num;
                    Console.WriteLine("O VALONR DE B É NEGATIVO: " + B);

                }

            }

            public void QuatroOperacoes()
            {
                //23
                int num1, num2, opcao, soma, sub, mult, div, aux;

                Console.WriteLine("=================");
                Console.WriteLine("|1 - ADIÇÃO       |");
                Console.WriteLine("|2 - SUBITRAÇÃO   |");
                Console.WriteLine("|3 - MULTIPLICAÇÃO|");
                Console.WriteLine("|4 - DIVISÃO      |");
                Console.WriteLine("=================");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("INFORME O PRIMEIRO NÚMERO: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O SEGUNDO  NÚMERO: ");
                    num2 = int.Parse(Console.ReadLine());
                    soma = num1 + num2;
                    Console.WriteLine("A SOMA DOS NÚMEROS É: " + soma);

                } else if (opcao == 2)
                {

                    Console.WriteLine("INFORME O PRIMEIRO NÚMERO: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O SEGUNDO  NÚMERO: ");
                    num2 = int.Parse(Console.ReadLine());

                    if (num2 > num1)//Encontrar o maior valor.
                    {
                        aux = num1;
                        num1 = num2;
                        num2 = aux;

                    }
                    sub = num1 - num2;
                    Console.WriteLine("O RESULTADO DA SUBTRAÇÃO ENTRE OS  NÚMEROS É: " + sub);


                } else if (opcao == 3)
                {
                    Console.WriteLine("INFORME O PRIMEIRO NÚMERO: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O SEGUNDO  NÚMERO: ");
                    num2 = int.Parse(Console.ReadLine());
                    mult = num1 * num2;
                    Console.WriteLine("O RESULTADO DA MULTIPLICAÇÃO ENTRE OS NÚMEROS É: " + mult);

                } else if (opcao == 4)
                {
                    Console.WriteLine("INFORME O PRIMEIRO NÚMERO: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O SEGUNDO  NÚMERO: ");
                    num2 = int.Parse(Console.ReadLine());
                    div = num1 / num2;
                    Console.WriteLine("O RESULTADO DA MULTIPLICAÇÃO ENTRE  OS NÚMEROS É: " + div);


                }
            }

        public void CalculoMultiploParMedia()
        {
            //24
            double num1=0, num2=0, result;
            int opcao;

            Console.WriteLine("INFOME O PRIMEIRO NUMERO");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("INFOME O SEGUNDO NUMERO");
            num1 = double.Parse(Console.ReadLine());
            do
            {

                Console.WriteLine("1 - VERIFICAR SE UM DOS NÚMEROS LIDOS É OU NÃO MULTIPLO DO OUTRO");
                Console.WriteLine("2 - VERIFICAR SE OS DOIS NU MEROS LIDOS SÃO PARES               ");
                Console.WriteLine("3 - VERIFICAR SE A MEDIA DOS DOIS NÚMEROS É MAIOR OU IGUAL A 7");
                Console.WriteLine("4 - SAIR");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        if (num1 % num2 == 0  || num2 % num1 == 0)
                        {
                            Console.WriteLine("SIM, UM DOS NÚMEROS É MULTIPLO DO OUTRO");

                        }
                        else
                        {
                            Console.WriteLine("NÃO, NENHUM DOS NÚMEROS É MULTIPLO DO OUTRO");


                        }


                        break;
                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("Sim, os dois números lidos são pares.");

                            result = 70 % 35;

                            Console.WriteLine(result);


                        }

                        else
                        {
                            Console.WriteLine("Não, os dois números lidos são ímpares.");
                        }

                        break;

                    case 3:
                        if ((num1 + num2) / 2 >= 7)
                        {
                            Console.WriteLine("Sim, a média dos dois números é maior ou igual a 7.");
                        }
                        else
                        {
                            Console.WriteLine("Não, a média dos dois números não é maior ou igual a 7.");
                        }

                        break;

                    case 4:
                        Console.WriteLine("SAIR");
                        break;
                    default:
                        Console.WriteLine("OPCAO INVALIDA!");

                        break;

                }


            } while (opcao!=4);
           




        }

        public void PesoIdeal()
        {
            //25
            double h;
            string sexo;
            double pesoIdeal;
            Console.WriteLine("INFORME SEU SEXO (M) OU (F)");
            sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("INFORME SUA ALTURA:");
            h = double.Parse(Console.ReadLine());

            if (sexo=="M")
            {
                pesoIdeal =(72.7 * h) - 58;


                Console.WriteLine("Sexo:"+sexo);
                Console.WriteLine("Altura: "+h);
                Console.WriteLine("Peso Ideal: "+pesoIdeal);


            }
            else if (sexo =="F")
            {
                pesoIdeal= (62.1*h)-44.7;
                Console.WriteLine("Sexo:" + sexo);
                Console.WriteLine("Altura: " + h);
                Console.WriteLine("Peso Ideal: " + pesoIdeal);


            }

        }

        public void ExibindoNumerosOrdemDecresc()
        {
            //26

            int[] numeros = new int[100];

            for (int i=0; i < 100; i++)
            {
                numeros[i] = i;

                

            }
            Array.Reverse(numeros);

            Console.WriteLine();
            Console.WriteLine("Numeros em ordem decrescente: ");
            foreach (int n in numeros)
            {
                
                Console.WriteLine(n);

            }

        }

        public void FatorialDoNumero()
        {
            //27

           


                Console.Write("Digite a quantidade de números a serem processados: ");
                int quantidade = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Digite o {i + 1}º número: ");
                    int numero = int.Parse(Console.ReadLine());

                    long fatorial = CalcularFatorial(numero);
                    Console.WriteLine($"O fatorial de {numero} é {fatorial}");
                }
           

            static long CalcularFatorial(int numero)
            {
                long fatorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }

                return fatorial;
            }
        






    }


    public void ImparesEntre100e200()
        {
            //28
            int cont = 100;
            int num=0;
            Console.WriteLine();
            Console.WriteLine("Valores impares entre  100 e 200:");
            do
            {
                cont++;
                
                if (cont%2==1)
                {
                    num = cont;
                    Console.WriteLine(num);

                }
               

                
                

            } while (cont !=200);




        }
        public void Numeros1ate200()
        {
            //29

            int cont = 0;
            Console.WriteLine();
            Console.WriteLine("Valores de 1 ate 200:");
            do
            {
                cont = (cont + 1);
                Console.WriteLine(cont);

            } while (cont < 200);

        }

        public void Tabuada()
        {
            //30
            int opcao;

            do
            {

                Console.WriteLine("1 - Adição       ");
                Console.WriteLine("2 - Subtração    ");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão      ");
                Console.WriteLine("0 - Sair         ");
                Console.Write("EScolha uma opção:   ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:

                        Console.Write("Digite um número para obter sua tabuada: ");
                        int numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Tabuada de " + numero + ":");

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(numero + " + " + i + " = " + (numero + i));
                        }

                        Console.ReadLine();


                        break;

                    case 2:
                        Console.Write("Digite um número para obter sua tabuada: ");
                        int numero2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Tabuada de " + numero2 + ":");

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(numero2 + " + " + i + " = " + (numero2 - i));
                        }

                        Console.ReadLine();

                        break;
                    case 3:
                        Console.Write("Digite um número para obter sua tabuada: ");
                        int numero3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Tabuada de " + numero3 + ":");

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(numero3 + " + " + i + " = " + (numero3 * i));
                        }

                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Digite um número para obter sua tabuada: ");
                        int numero4 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Tabuada de " + numero4 + ":");

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(numero4 + " + " + i + " = " + (numero4 / i));
                        }

                        Console.ReadLine();
                        break;
                    case 0:
                        Console.WriteLine("Sair!");
                        break;
                    default:
                        Console.WriteLine("Opçãp Invalida!");
                        break;





                }







            } while (opcao!=0);
            
            






            
        


    }



    public void ParesImpares()
        {
            //31
            int num=0, numPar=0, numImpar=0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Digite um número (Insira um número negativo pra finalizar): ");
                num = int.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    if (num % 2 == 0)
                    {
                        numPar++;
                    }
                    else
                    {
                        numImpar++;
                    }
                }
            } while (num >= 0);

                Console.WriteLine("Quantidade de Números Pares: " + numPar + "\nQuantidade de Números Impares: " + numImpar);

        




        }

        public void SomaDosQuadrados()
        {
            //32
            
         
           
                Console.Write("Digite um número entre 1 e 10: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 1 || numero > 10)
                {
                    Console.WriteLine("O número deve estar entre 1 e 10.");
                    return;
                }

                int contador = 0;
                int somaQuadrados = 0;
                int valor = numero;

                while (contador < 20)
                {
                    if (valor % 2 == 1)
                    {
                        somaQuadrados += valor * valor;
                        contador++;
                    }

                    valor++;
                }

                Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares a partir de {numero} é: {somaQuadrados}");
            
        



        }

        public void MediaNotas()
        {
            //33
          


            
                int contAlunos = 0;
                double sNotas = 0;

                Console.WriteLine("Calculadora de média de notas");
                Console.WriteLine("Digite as notas dos alunos. Digite -1 para encerrar a entrada de notas.");

                while (true)
                {
                    Console.Write("Número de matrícula do aluno: ");
                    int Nmatricula;
                    bool sucessoMatricula = int.TryParse(Console.ReadLine(), out Nmatricula);

                    if (!sucessoMatricula || Nmatricula == -1)
                        break;

                    Console.Write("Nota do aluno: ");
                    double nota;
                    bool sucessoNota = double.TryParse(Console.ReadLine(), out nota);

                    if (!sucessoNota)
                        continue;

                    contAlunos++;
                    sNotas += nota;
                }

                if (contAlunos > 0)
                {
                    double media = sNotas / contAlunos;
                    Console.WriteLine("Média das notas: " + media.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Nenhum aluno registrado. Não é possível calcular a média.");
                }
            
        










    }

public void MaiorMenorValor()    
    {
            //34
            


            
            
                int numero;
                int menor = int.MaxValue;
                int maior = int.MinValue;

                Console.WriteLine("Digite um conjunto de números positivos (Digite um número negativo para encerrar):");

                do
                {
                    Console.Write("Digite um número: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero >= 0)
                    {
                        if (numero < menor)
                            menor = numero;

                        if (numero > maior)
                            maior = numero;
                    }
                }
                while (numero >= 0);

                Console.WriteLine($"Menor número: {menor}");
                Console.WriteLine($"Maior número: {maior}");
            
        }






    }
    









}


      
    