using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 66666),
                null,
                new ContaCorrente(340, 99999),
                new ContaCorrente(340, 1),
                null,
                null,
                new ContaCorrente(290, 71685),
            };

            //contas.Sort(); ~~> Chamar a implementação dada em IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();

        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaObject()
        {
            ListaDeObject listaDeIdade = new ListaDeObject();

            listaDeIdade.Adicionar(10);
            listaDeIdade.Adicionar(5);
            listaDeIdade.Adicionar(4);
            listaDeIdade.Adicionar("um texto qualquer");
            listaDeIdade.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdade.Tamanho; i++)
            {
                int idade = (int)listaDeIdade[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");

            }
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Wellington",
                "Matheus",
                "Beatriz",
                "Lucas",
                "Pabline"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }





            //var resultado = SomarVarios(1, 5, 9);


            //var conta = new ContaCorrente(4859, 16151);
            ////ContaCorrente conta = new ContaCorrente(4859, 16151);
            //var gerenciador = new GerenciadorBonificacao();
            ////GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            //var genrecidaores = new List<GerenciadorBonificacao>();
            ////List<GerenciadorBonificacao> genrecidaores = new List<GerenciadorBonificacao>();



            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.AdicionarVarios(45, 89, 12);
            // ListExtensores.AdicionarVarios(idades, 45, 89, 12);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

        static void TestaListaDeContaCorrete()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente ContaDoMath = new ContaCorrente(666, 666666);

            lista.Adicionar(ContaDoMath);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                ContaDoMath,
                new ContaCorrente(874, 4654894),
                new ContaCorrente(874, 3546848)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(ContaDoMath, new ContaCorrente(874, 4654894), new ContaCorrente(874, 3546848));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5468445),
                new ContaCorrente(874, 4451616),
                new ContaCorrente(874, 3348498)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de interios, com 5 posições

            int[] idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array no indice {indice}");
                Console.WriteLine($"Valor de idade [{indice}] = {idade}");
                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
