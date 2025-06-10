using ClubeDaLeitura.ConsoleApp.Compartilhado;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista;

public class RepositorioRevista : RepositorioBase

{
    public EntidadeBase[] SelecionarRevistasDisponiveis()
    {
        int contadorRevistasDisponiveis = 0;

        for(int i = 0; i < registros.Length; i++)
        {
            Revista revistaAtual = (Revista)registros[i];

            if (revistaAtual == null)
                continue;

            if (revistaAtual.Status == "Disponivel")
                contadorRevistasDisponiveis++;
        }

        EntidadeBase[] revistasDisponiveis = new EntidadeBase[contadorRevistasDisponiveis];

        int contadorAuxiliar = 0;

        for (int i = 0; i < registros.Length; i++)
        {
            Revista revistaAtual = (Revista)registros[i];

            if (revistaAtual == null)
                continue;

            if (revistaAtual.Status == "Disponivel")
                revistasDisponiveis[contadorAuxiliar++] = registros[i];
        }

        return revistasDisponiveis;
    }
}