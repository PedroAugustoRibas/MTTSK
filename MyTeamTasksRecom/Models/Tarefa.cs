﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeamTasksRecom.Models
{
    [Table("Tarefa")]
    public class Tarefa
    {
        public Tarefa()
        {
            CriadoEm = DateTime.Now;
        }
        [Key]
        public int TarefaId { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public string Resolucao { get; set; }
        public string Descricao { get; set; }
        public Funcionario Assinatura { get; set; }
        public Funcionario Requisitante { get; set; }
        public Projeto Projeto { get; set; }
        //public Cliente Cliente { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return "ID: " + TarefaId +
                "\nTitulo: " + Titulo +
                "\nDescricao: " + Descricao +
                "\nTipo: " + Tipo +
                "\nStatus: " + Status +
                "\nPrioridade: " + Prioridade +
                "\nResolução: " + Resolucao +
                "\nAssinatura: " + Assinatura.Nome +
                "\nRequisitante: " + Requisitante.Nome +
                "\nProjeto: " + Projeto.Nome;

        }
    }
}