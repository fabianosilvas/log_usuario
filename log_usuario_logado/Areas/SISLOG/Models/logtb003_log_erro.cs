using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace log_usuario_logado.Areas.SISLOG.Models
{
    public class logtb003_log_erro
    {
        [Key]
        public int id_registro  { get; set; }

        public DateTime dh_acesso { get; set; }

        [StringLength(50)]
        public string co_sessao { get; set; }

        [StringLength(500)]
        public string de_pagina { get; set; }

        public int co_status_requisicao { get; set; }
        
        [StringLength(500)]
        public string de_mensagem { get; set; }

        [StringLength(8000)]
        public string de_excecao { get; set; }
    }
}