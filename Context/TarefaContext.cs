using AgendaTarefa.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaTarefa.Context
{
    public class TarefaContext : DbContext
    {

        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {}

        public DbSet<Tarefa> Tarefas {get; set;}
    }
}