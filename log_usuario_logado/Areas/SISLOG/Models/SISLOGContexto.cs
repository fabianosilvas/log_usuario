namespace log_usuario_logado.Areas.SISLOG.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SISLOGContexto : DbContext
    {
        public SISLOGContexto()
            : base("name=DB5599_STAGE")
        {
        }

        public virtual DbSet<logtb001_log_sessao> Logtb001_log_sessao { get; set; }
        public virtual DbSet<logtb002_log_acesso> Logtb002_log_acesso { get; set; }
        public virtual DbSet<logtb003_log_erro> logtb003_log_erro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<logtb001_log_sessao>()
                .Property(e => e.co_sessao)
                .IsUnicode(false);

            modelBuilder.Entity<logtb001_log_sessao>()
                .Property(e => e.no_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<logtb001_log_sessao>()
                .Property(e => e.de_navegador)
                .IsUnicode(false);

            modelBuilder.Entity<logtb001_log_sessao>()
                .Property(e => e.de_resolucao)
                .IsUnicode(false);

            modelBuilder.Entity<logtb001_log_sessao>()
                .Property(e => e.de_sistema_operacional)
                .IsUnicode(false);

            modelBuilder.Entity<logtb001_log_sessao>()
                .Property(e => e.de_user_agent)
                .IsUnicode(false);

            modelBuilder.Entity<logtb002_log_acesso>()
                .Property(e => e.co_sessao)
                .IsUnicode(false);

            modelBuilder.Entity<logtb002_log_acesso>()
                .Property(e => e.de_pagina)
                .IsUnicode(false);
        }
    }
}
