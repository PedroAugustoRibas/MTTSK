﻿using Microsoft.EntityFrameworkCore;
using MyTeamTasksRecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTeamTasksRecom.DAL
{
    public class FuncionarioDAO
    {
        private readonly Context _context;

        public FuncionarioDAO(Context context)
        {
            _context = context;
        }
           
        public void Cadastrar(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
    
        }
        public List<Funcionario> Listar()
        {
            return _context.Funcionarios.ToList();
        }
        public  Funcionario BuscarFuncionarioPorId(int? id)
        {
            return _context.Funcionarios.Find(id);
        }

        public void Remover(int id)
        {           
            _context.Funcionarios.Remove(BuscarFuncionarioPorId(id));
            _context.SaveChanges();
        }

        public void Alterar(Funcionario funcionario)
        {           
            _context.Entry(funcionario).State = EntityState.Modified;
            _context.SaveChanges();
        }
        
       
    }
}
