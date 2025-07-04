﻿using ClubeDaLeitura.ConsoleApp.ModuloCaixa;

namespace ClubeDaLeitura.ConsoleApp.Compartilhado;

public abstract class EntidadeBase
{
       public int Id { get; set; }
    public Caixa Caixa { get; internal set; }

    public abstract void AtualizarRegistro(EntidadeBase registroAtualizado);
    public abstract string Validar();
}