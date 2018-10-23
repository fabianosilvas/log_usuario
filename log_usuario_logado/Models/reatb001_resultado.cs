namespace log_usuario_logado.Models
{
    using log_usuario_logado.Uteis;
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

        //Recupera nome da Classe CSS para o percentual atingido do realize.Caixa
        public string CorPercentualRealize(double pcAtingido)
        {
            return Realize.CorPercentualRealize(pcAtingido);
        }

        //Recupera nome da Classe CSS (com background) para o percentual atingido do realize.Caixa
        public string CorPercentualRealize(double pcAtingido, bool backGround)
        {
            return Realize.CorPercentualRealize(pcAtingido, backGround);
        }


        public string CorNumeroZero(double numero)
        {
            return Realize.CorNumeroZero(numero);
        }
        
        public string CorNegativoPotisivo(double numero)
        {
            return Realize.CorNegativoPotisivo(numero);
        }

        public string CorNegativoPotisivo_Inverso(double numero)
        {
            return Realize.CorNegativoPotisivo_Inverso(numero);
        }

    }
}
