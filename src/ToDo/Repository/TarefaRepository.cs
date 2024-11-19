﻿using Microsoft.EntityFrameworkCore;
using ToDo.Context;
using ToDo.Contracts;
using ToDo.GenericRepository;
using ToDo.Models;

namespace ToDo.Repository
{
    public class TarefaRepository : Repository<Tarefa>
    {
        private readonly Context.Context _context;
        public TarefaRepository(Context.Context ctx) : base(ctx)
        {
            _context = ctx;
        }
    }
}
