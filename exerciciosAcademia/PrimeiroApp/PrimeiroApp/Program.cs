namespace PrimeiroApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // EXERCICIO 1
            //Console.WriteLine("Informe um valor:");
            //float num1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe outro valor:");
            //float num2 = float.Parse(Console.ReadLine());

            //float media = (num1 + num2)/2;
            //Console.WriteLine("A média dos numeros é: "+media);


            // EXERCICIO 2
            //Console.WriteLine("Informe um valor:");
            //float num1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe outro valor:");
            //float num2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe outro valor:");
            //float num3 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe outro valor:");
            //float num4 = float.Parse(Console.ReadLine());

            //float media = (num1 + num2 + num3 + num4)/4;
            //Console.WriteLine("A média dos numeros é: "+media);

            // EXERCICIO 3
            //int a = 1;
            //int b = 2;
            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine("A->"+a);
            //Console.WriteLine("B->" + b);

            // EXERCICIO 4
            //string dia = DateTime.Now.ToString("dd");
            //string mes = DateTime.Now.ToString("MM");
            //string ano = DateTime.Now.ToString("yy");
            //string anoFull = DateTime.Now.ToString("yyyy");
            //string data = ano + "/" + mes + "/" + dia;
            //string dataFull = anoFull + "/" + mes + "/" + dia;
            //Console.WriteLine(data);
            //Console.WriteLine(dataFull);

            // EXERCICIO 5 
            //Console.WriteLine("Informe a distância percorrida em KM");
            //float distancia = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o consumo de combustível em L");
            //float consumo = float.Parse(Console.ReadLine());

            //float media = distancia / consumo;
            //Console.WriteLine("O consumo médio é de: "+ media + " KM/L");

            // EXERCICIO 6
            //string[] parafusoA = new string[4];
            //Console.WriteLine("Informe o código do Parafuso A");
            //parafusoA[0] = Console.ReadLine();
            //Console.WriteLine("Informe a quantidade");
            //parafusoA[1] = Console.ReadLine();
            //Console.WriteLine("Informe o valor unitário");
            //parafusoA[2] = Console.ReadLine();
            //Console.WriteLine("Informe a porcentagem de IPI");
            //parafusoA[3] = Console.ReadLine();

            //for (int i = 0; i < parafusoA.Length; i++)
            //{
            //    Console.Write(parafusoA[i]+", ");

            //}

            //string[] parafusoB = new string[4];
            //Console.WriteLine("");
            //Console.WriteLine("Informe o código do Parafuso B");
            //parafusoB[0] = Console.ReadLine();
            //Console.WriteLine("Informe a quantidade");
            //parafusoB[1] = Console.ReadLine();
            //Console.WriteLine("Informe o valor unitário");
            //parafusoB[2] = Console.ReadLine();
            //Console.WriteLine("Informe a porcentagem de IPI");
            //parafusoB[3] = Console.ReadLine();

            //for (int i = 0; i < parafusoB.Length; i++)
            //{
            //    Console.Write(parafusoB[i] + ", ");

            //}

            // EXERCICIO 7
            //Console.WriteLine("Informe o numero do vendedor");
            //int numeroVendedor = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o salario do vendedor");
            //float salarioFixo = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o numero de vendas");
            //int vendas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o percentual que ganha sobre o total de vendas");
            //float percentual = float.Parse(Console.ReadLine());

            //float salarioTotal = salarioFixo + (vendas * percentual/100);
            //Console.WriteLine("Numero do vendedor: "+numeroVendedor);
            //Console.WriteLine("Salário total do vendedor: " + salarioTotal);

            // EXERCICIO 8 
            //Console.WriteLine("Informe a temperatura em Celsius (C°)");
            //float celsius = float.Parse(Console.ReadLine());
            //float fahrenheit = (9 * celsius + 160) / 5;
            //Console.WriteLine("A temperatura em Fahrenheit (F°) é: "+fahrenheit);

            // EXERCICIO 9 
            //Console.WriteLine("Informe o valor da mercadoria");
            //float valorTotal = float.Parse(Console.ReadLine());
            //float prestacao1 = (int)Math.Floor(valorTotal / 3) + valorTotal % 3;
            //float prestacao2 = (int)Math.Floor(valorTotal / 3);
            //float prestacao3 = (int)Math.Floor(valorTotal / 3);

            //Console.WriteLine("Primeira prestação: "+prestacao1);
            //Console.WriteLine("Segunda prestação: " + prestacao2);
            //Console.WriteLine("Terceira prestação: " + prestacao3);


            // EXERCICIO 10 *
            //int valor = 87;
            //for (int nota50 = 0; 50 > valor; nota50++)
            //{
            //    int valorDecrementado = valor - 50;
            //    Console.WriteLine(nota50 + " notas de 50");

            //    for (int nota20 = 0; 20 > valorDecrementado; nota20++)
            //    {
            //        valorDecrementado -= 20;
            //        Console.WriteLine(nota20 + " notas de 20");

            //            for (int nota10 = 0; 10 > valorDecrementado; nota10++)
            //            {
            //            valorDecrementado -= 10;
            //                Console.WriteLine(nota10 + " notas de 10");

            //                for (int nota5 = 0; 5 > valorDecrementado; nota5++)
            //                {
            //                valorDecrementado -= 5;
            //                    Console.WriteLine(nota5 + " notas de 5");

            //                    for (int nota1 = 0; 1 > valorDecrementado; nota1++)
            //                    {
            //                    valorDecrementado -= 1;
            //                        Console.WriteLine(nota1 + " notas de 1");
            //                    }
            //            }
            //        }
            //    }
            //}

            // EXERCICIO 11
            //float brancos, nulos, validos;
            //Console.WriteLine("Insira a quantidade de votos em branco");
            //brancos = float.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a quantidade de votos em nulo");
            //nulos = float.Parse(Console.ReadLine());
            //Console.WriteLine("Insira a quantidade de votos validos");
            //validos = float.Parse(Console.ReadLine());
            //float total = brancos + nulos + validos;

            //Console.WriteLine("Porcentagem de votos em branco >> "+(brancos/total * 100) + "%");
            //Console.WriteLine("Porcentagem de votos nulos >> " + (nulos / total * 100)  + "%");
            //Console.WriteLine("Porcentagem de votos validos >> " + (validos / total * 100)  + "%");

            // EXERCICIO 12
            //double combustivel = 6.90;
            //Console.WriteLine("Informe a quilometragem do inicio do dia");
            //float odometro1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a quilometragem do fim do dia");
            //float odometro2 = float.Parse(Console.ReadLine());
            //float quilometragem = odometro2 - odometro1;
            //Console.WriteLine("Infome a quantidade de combustivel gasta em Litros");
            //float gastoCombustivel = float.Parse(Console.ReadLine());
            //float mediaConsumo = quilometragem / gastoCombustivel;
            //Console.WriteLine("Informe o valor total recebido");
            //float recebido = float.Parse(Console.ReadLine());
            //double lucro = recebido - gastoCombustivel * combustivel;
            //Console.WriteLine("Quilometragem total >> "+ quilometragem);
            //Console.WriteLine("Media de consumo >> " + mediaConsumo);
            //Console.WriteLine("Lucro total >> " + lucro);

            // EXERCICIO 13
            //Console.WriteLine("Informe o valor do salario minimo");
            //float salarioMin = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o preço de custo das bicicletas");
            //float bicicletaPreco = float.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a quantidade de bicicletas vendidas pelo vendedor");
            //int qtdBicicletas = int.Parse(Console.ReadLine());
            //double comissao = (bicicletaPreco*0.15)*qtdBicicletas;
            //double salarioFinal = salarioMin * 2 + comissao;
            //Console.WriteLine("O salário do vendedor é de >> "+salarioFinal);

            // EXERCICIOS DA AULA \/

            //double num1, num2, resultado;
            //int op;
            //Console.WriteLine("Informe uma operação: \n1.Adição\n2.Subtração\n3.Multiplicação\n4.Divisão\n5.Potencia\n0.Fechar\nEscolha: ");
            //op = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Informe dois numeros");
            //    num1 = double.Parse(Console.ReadLine());
            //    num2 = double.Parse(Console.ReadLine());

            //    switch (op)
            //    {
            //        case 1:
            //            resultado = num1 + num2;
            //            Console.WriteLine(resultado);
            //            return;
            //        case 2:
            //            resultado = num1 - num2;
            //            Console.WriteLine(resultado);
            //            return;
            //        case 3:
            //            resultado = num1 * num2;
            //            Console.WriteLine(resultado);
            //            return;

            //        case 4:
            //            resultado = num1 / num2;
            //            Console.WriteLine(resultado);
            //            return;

            //        case 5:
            //            resultado = Math.Pow(num1, num2);
            //            Console.WriteLine(resultado);
            //            return;
            //        default:
            //            break;
            //    }

            //int lado1, lado2, lado3;

            //Console.WriteLine("Informe um lado");
            //lado1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe um lado");
            //lado2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe um lado");
            //lado3 = int.Parse(Console.ReadLine());

            //if(lado1 < lado2+lado3 && lado2 < lado1 + lado2 && lado3 < lado1 + lado2)
            //{
            //    if(lado1 == lado2 && lado1 == lado3)
            //    {
            //        Console.WriteLine("Triangulo equilatero");
            //    } else if(lado1 == lado2 || lado2 == lado3 || lado1 == lado3) 
            //    {
            //        Console.WriteLine("Triangulo isosceles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Triangulo escaleno");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Não é um triangulo");
            //}

        }
    }
}