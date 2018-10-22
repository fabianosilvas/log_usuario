namespace log_usuario_logado.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class reatb001_resultado
    {
        [Key]
        public double CO_UNIDADE { get; set; }

        public double? VR_OBJETIVO { get; set; }

        public double? VR_REALIZADO { get; set; }

        public double? PC_REALIZADO { get; set; }
    }
}
