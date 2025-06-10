using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.Compartilhado;

public abstract class EntidadeBase
{
    internal Amigo Amigo;
    internal Revista Revista;

    public int Id { get; set; }
    internal Caixa Caixa { get; set; }

    public abstract void AtualizarRegistro(EntidadeBase registroAtualizado);
    public abstract string Validar();
}