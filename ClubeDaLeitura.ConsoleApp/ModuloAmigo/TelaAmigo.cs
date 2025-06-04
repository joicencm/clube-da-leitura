﻿
using ClubeDaLeitura.ConsoleApp.Compartilhado;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo;

public class TelaAmigo : TelaBase
{
    public TelaAmigo(RepositorioBase repositorio) : base("Amigo", repositorio)
    {
    }

    public override void VisualizarRegistros(bool exibirCabecalho)
    {
        if (exibirCabecalho == true)
            ExibirCabecalho();

        Console.WriteLine("Visualização de Amigos");

        Console.WriteLine();

        Console.WriteLine(
           "{0, -10} | {1, -30} | {2, -30} | {3, -20}",
            "Id", "Nome", "Responsável", "Telefone"
            );

        EntidadeBase[] amigos = repositorio.SelecionarRegistros();

        for (int i = 0; i < amigos.Length; i++)
        {
            Amigo a = (Amigo)amigos[i];

            if (a == null)
                continue;

            Console.WriteLine(
               "{0, -10} | {1, -30} | {2, -30} | {3, -20}",
                a.Id, a.Nome, a.NomeResponsavel, a.Telefone
            );
        }

        Console.ReadLine();
    }

    protected override EntidadeBase ObterDados()
    {
        Console.Write("Digite o nome do amigo: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o nome do responável pelo amigo: ");
        string nomeReposavel = Console.ReadLine();

        Console.Write("Digite o telefone do amigo ou responsável: ");
        string telefone= Console.ReadLine();

        Amigo amigo = new Amigo(nome, nomeReposavel, telefone);

        return amigo;
    }
}
