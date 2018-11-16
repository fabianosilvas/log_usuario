namespace log_usuario_logado.Areas.SISLOG.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logtb001_log_sessao
    {

        [Key]
        public int id_registro { get; set; }

        [StringLength(50)]
        public string co_sessao { get; set; }

        public DateTime dh_acesso { get; set; }
        
        public DateTime? dh_ultima_requisicao { get; set; }

        public DateTime? dh_saida { get; set; }

        public TimeSpan? qt_tempo_sessao { get; set; }

        [StringLength(100)]
        public string no_usuario { get; set; }

        [StringLength(100)]
        public string de_navegador { get; set; }

        [StringLength(50)]
        public string de_resolucao { get; set; }

        [StringLength(100)]
        public string de_sistema_operacional { get; set; }

        [StringLength(500)]
        public string de_user_agent { get; set; }

        [StringLength(100)]
        public string nu_ip { get; set; }

    }
}
