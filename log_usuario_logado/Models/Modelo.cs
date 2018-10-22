namespace log_usuario_logado.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelo : DbContext
    {
        public Modelo()
            : base("name=Modelo")
        {
        }

        public virtual DbSet<logtb001_log_sessao> logtb001_log_sessao { get; set; }
        public virtual DbSet<logtb002_log_acesso> logtb002_log_acesso { get; set; }

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
