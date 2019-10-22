﻿using Microsoft.EntityFrameworkCore;
using MyTeamTasksRecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTeamTasksRecom.DAL
{
    public class ProjetoDAO
    {
        private readonly Context _context;

        public ProjetoDAO(Context context)
        {
            _context = context;
        }
        public void CadastrarProjeto(Projeto p)
        {
            _context.Projetos.Add(p);
            _context.SaveChanges();
        }

        public List<Projeto> ListarProjetos() => _context.Projetos.ToList();

        public Projeto BuscarProjetoPorNome(string nome)
        {
            return _context.Projetos.FirstOrDefault(x => x.Nome.Equals(nome));
        }

        public  List<Projeto> BuscarProjetoPorstatus(Projeto p)
        {
            return _context.Projetos.Where(x => x.Status == p.Status).ToList();
        }
        public Projeto BuscarProjetoPorId(int? id)
        {
            return _context.Projetos.Find(id);
        }

        public bool RemoverProjeto(int id)
        {
            try
            {   
                _context.Projetos.Remove(BuscarProjetoPorId(id));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AlterarProjeto(Projeto p)
        {
            try
            {
                _context.Entry(p).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}