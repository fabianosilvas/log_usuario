namespace log_usuario_logado.Areas.SISLOG.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logtb002_log_acesso
    {
        [Key]
        public int id_registro { get; set; }

        public DateTime dh_acesso { get; set; }

        [StringLength(50)]
        public string co_sessao { get; set; }
        
        [StringLength(500)]
        public string de_pagina { get; set; }

        [StringLength(500)]
        public string de_pagina_origem_requisicao { get; set; }
    }
}
