using ClubeDaLeitura.ConsoleApp.Compartilhado;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa;

class Caixa : EntidadeBase
{
    public string Etiqueta { get; set; }
    public string Cor { get; set; }
    public int DiasEmprestimo { get; set; }

    public Caixa(string etiqueta, string cor)
    {
        Etiqueta = etiqueta;
        Cor = cor;
        DiasEmprestimo = 7;
    }

    public Caixa(string etiqueta, string cor, int diasEmprestimo)
    {
        Etiqueta = etiqueta;
        Cor = cor;
        DiasEmprestimo = diasEmprestimo;
    }


    public override void AtualizarRegistro(EntidadeBase registroAtualizado)
    {
        Caixa caixaAtualizado = (Caixa)registroAtualizado;

        this.Etiqueta = caixaAtualizado.Etiqueta;
        this.Cor = caixaAtualizado.Cor;
        this.DiasEmprestimo = caixaAtualizado.DiasEmprestimo;
    }

    public override string Validar()
    {
        string erros = string.Empty;

        if (string.IsNullOrWhiteSpace(Etiqueta) || Etiqueta.Length > 50)
            erros += "O campo \"Etiqueta\" é obrigatório e recebe no maximo 50 caracteres.";

        if (string.IsNullOrWhiteSpace(Cor))
            erros += "O campo \"Cor\" é obrigatório.";

        if (DiasEmprestimo < 1)
            erros += "O campo \"DiasEmprestimo\" deve conter um valor maior que 0.";

        return erros;
    }
}
