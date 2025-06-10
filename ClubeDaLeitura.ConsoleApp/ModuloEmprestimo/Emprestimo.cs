﻿using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloEmprestimo
{
    class Emprestimo : EntidadeBase
    {
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Status { get; set; }

        public Emprestimo(Amigo amigo, Revista revista)
        {
            Amigo = amigo;
            Revista = revista;
            DataEmprestimo = DateTime.Now;
            DataDevolucao = DataEmprestimo.AddDays(Revista.Caixa.DiasEmprestimo);
            Status = "Aberto";
        }

        public override void AtualizarRegistro(EntidadeBase registroAtualizado)
        {
            Emprestimo emprestimoAtualizado = (Emprestimo)registroAtualizado;

            Status = "Aberto";
        }

        public override string Validar()
        {
            string erros = string.Empty;

            if (Amigo == null)
                erros += "O campo \"Amigo\" é obrigatório.";

  if (Revista == null)
                erros += "O campo \"Revista\" é obrigatório.";

            return erros;
        }
    }
}
