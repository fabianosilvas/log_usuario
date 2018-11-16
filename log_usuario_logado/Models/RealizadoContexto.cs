namespace log_usuario_logado.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RealizadoContexto : DbContext
    {
        public RealizadoContexto()
            : base("name=admbd")
        {
        }

        public virtual DbSet<Reatb001_resultado> Reatb001_resultado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
