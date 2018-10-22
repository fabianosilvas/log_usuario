namespace log_usuario_logado.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RealizadoContexto : DbContext
    {
        public RealizadoContexto()
            : base("name=DB5599_STAGE")
        {
        }

        public virtual DbSet<reatb001_resultado> reatb001_resultado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
