using System;
using System.Collections.Generic;
using System.Linq;

namespace SA_Samuel.Campos
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Cliente> C = new List<Cliente>();
            List<Venda> V = new List<Venda>();
            List<Produto> P = new List<Produto>();
            Venda venda = new Venda();
            double R;
        inicio:
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("-     Controle de Estoque Padaria Pão do Céu    -");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("");

            Console.WriteLine("__________________________________________________");
            Console.WriteLine("-                1: Clientes                     -");
            Console.WriteLine("-                2: Venda                        -");
            Console.WriteLine("-                3: Produtos                     -");
            Console.WriteLine("-                4: Média Vendas                 -");
            Console.WriteLine("-                5: Maior Venda                  -");
            Console.WriteLine("-                6: Menor Venda                  -");
            Console.WriteLine("-                7: Produto mais vendido         -");
            Console.WriteLine("-                8: Produto menos vendido        -");
            Console.WriteLine("-                9: Venda por cliente            -");
            Console.WriteLine("-                10: Venda por produto           -");
            Console.WriteLine("-                11: Saldo final                 -");
            Console.WriteLine("-                12: Sair do Sistema             -");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Insira uma opção");
            int opc = int.Parse(Console.ReadLine());
            Console.Clear();
            int acao;
            switch (opc)
            {
                case 1:
                    Console.Write("Insira o nome do cliente: ");
                    String nome = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Insira o CPF do cliente: ");
                    String CPF = Console.ReadLine();
                    Cliente cliente = new Cliente(nome, CPF);
                    C.Add(cliente);
                    Console.Clear();
                    Console.Write("Adicionar mais clientes? Insira 1 para Sim e 2 para Não): ");
                    acao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (acao == 1)
                    {
                        goto case 1;
                    }
                    goto inicio;
                
                case 2:
                    Console.Write("Insira o nome do vendedor: ");
                    String n_vendedor = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Insira o cpf do cliente: ");
                    String cpf = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Insira o codigo do produto: ");
                    String cod_produto = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Insira o valor da venda: ");
                    Double v_venda = Double.Parse(Console.ReadLine());
                    Venda Venda = new Venda(n_vendedor, cpf, cod_produto, v_venda);
                    V.Add(Venda);
                    Console.Clear();
                    Console.Write("Adicionar mais Vendas? Insira 1 para Sim e 2 para Não): ");
                    acao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (acao == 1)
                    {
                        goto case 2;
                    }
                    goto inicio;

                case 3:
                    Console.Write("Insira o nome do produto: ");
                    String n_produto = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Insira o cod do produto: ");
                    cod_produto = Console.ReadLine();
                    Produto Produto = new Produto(n_produto, cod_produto);
                    P.Add(Produto);
                    Console.Clear();
                    Console.Write("Adicionar mais produtos? Insira 1 para Sim e 2 para Não): ");
                    acao = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (acao == 1)
                    {
                        goto case 3;
                    }
                    goto inicio;

                case 4:
                    double cont = 0;
                    foreach(var esp in V)
                    {
                        cont += esp.v_venda;
                    }
                    R = cont / V.Count;
                    Console.WriteLine($"A média de venda de seus produtos é {R}.");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;
                
                case 5:
                    R = 0;
                    foreach (var esp in V)
                    {
                        if (esp.v_venda > venda.v_venda)
                        {
                            R = esp.v_venda;
                        }
                    }
                    Console.WriteLine($"A maior venda de seus produtos é {R}.");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;

                case 6:
                    R = 0;
                    Venda rec = V.Last();
                    R = rec.v_venda;
                    foreach (var esp in V)
                    {
                        if (esp.v_venda < R)
                        {
                            R = esp.v_venda;
                        }
                    }
                    Console.WriteLine($"A menor venda de seus produtos é {R}.");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;

                case 7:
                    double lasanha = 0;
                    R = 0;
                    int countcod = 0;
                    for (var i = 0; i < V.Count; i++)
                    {
                        foreach (var esp in V)
                        {
                            if (esp.cod_produto == i)
                            {
                                lasanha += esp.v_venda;
                            }
                            if (lasanha > R)
                            {
                                R = lasanha;
                                countcod = i;
                            }
                        }
                    }
                    Console.WriteLine($"Código do produto: {countcod} | Saldo total de vendas: {R}");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;

                case 8:
                    lasanha = 0;
                    R = 20000;
                    countcod = 0;
                    for (var i = 0; i < V.Count; i++)
                    {
                        foreach (var esp in V)
                        {
                            if (esp.cod_produto == i)
                            {
                                lasanha += esp.v_venda;
                            }
                            if (lasanha < R)
                            {
                                R = lasanha;
                                countcod = i;
                            }
                        }
                    }
                    Console.WriteLine($"Código do produto: {countcod} | Saldo total de vendas: {R}");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;

                case 9:
                    Console.WriteLine("Insira o cpf do cliente: ");
                    string cpfv = Console.ReadLine();
                    foreach(var esp in V)
                    {
                        if(esp.cpf == cpfv)
                        {
                            Console.WriteLine($"CPF do Cliente {esp.cpf}");
                            Console.WriteLine($"Nome do Vendedor {esp.n_vendedor}");
                            Console.WriteLine($"Valor da Venda {esp.v_venda}");
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;

                case 10:
                    Console.WriteLine("Insira o cod do produto: ");
                    string codv = Console.ReadLine();
                    foreach (var esp in P)
                    {
                        if (esp.cod_produto == codv)
                        {
                            Console.WriteLine($"Nome do produto {esp.n_produto}");
                            Console.WriteLine($"Código do produto {esp.cod_produto}");
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;

                case 11:
                    R = 0;
                    foreach (var esp in V)
                    {
                        R += esp.v_venda;
                    }
                    Console.WriteLine($"O total de venda de seus produtos é {R}.");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;

                case 12:
                    Environment.Exit(0);
                        goto inicio;
            }
        }
    }
}
