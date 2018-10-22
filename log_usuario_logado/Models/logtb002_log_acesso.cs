namespace log_usuario_logado.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logtb002_log_acesso
    {
        [Key]
        [Column(Order = 0)]
        public DateTime dh_acesso { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string co_sessao { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string de_pagina { get; set; }
    }
}
