using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace log_usuario_logado.Uteis
{
    public class Realize
    {
        public static string CorPercentualRealize(double pcAtingido)
        {
            string noClasseCss = null;

            if (pcAtingido >= 100)
            {
                noClasseCss = "realize-faixa-azul";
            }
            else if (pcAtingido >= 90 && pcAtingido < 100)
            {
                noClasseCss = "realize-faixa-verde"; 
            }
            else if (pcAtingido >= 80 && pcAtingido < 90)
            {
                noClasseCss = "realize-faixa-amarela"; 
            }
            else
            {
                noClasseCss = "realize-faixa-vermelha";
            }

            return noClasseCss;
        }




        public static string CorPercentualRealize(double pcAtingido, bool backGround)
        {
            string noClasseCss = null;

            if (pcAtingido >= 100)
            {
                noClasseCss = "realize-faixa-azul-bg";
            }
            else if (pcAtingido >= 90 && pcAtingido < 100)
            {
                noClasseCss = "realize-faixa-verde-bg";
            }
            else if (pcAtingido >= 80 && pcAtingido < 90)
            {
                noClasseCss = "realize-faixa-amarela-bg";
            }
            else
            {
                noClasseCss = "realize-faixa-vermelha-bg";
            }

            return noClasseCss;
        }



        public static string CorPercentualRealize(string noCor)
        {
            string Cor = null;

            switch (noCor)
            {
                case "AZUL":
                    Cor = "rgb(51,122,183)"; //AZUL
                    break;
                case "VERDE":
                    Cor = "rgb(60,118,61)"; //VERDE
                    break;
                case "AMARELO":
                    Cor = "rgb(255,153,0)"; //AMARELO
                    break;
                case "VERMELHO":
                    Cor = "rgb(206,60,49)"; //VERMELHO
                    break;
            }

            return Cor;
        }


        public static string CorNumeroZero(double numero) {
            string Cor = null;

            if (numero == 0)
            {
                Cor = "#cccccc"; // CINZA
            }
            else
            {
                Cor = "black"; // PRETO 
            }

            return Cor;
        }


        public static string CorNegativoPotisivo (double numero)
        {
            string Cor = null;

            if (numero < 0 )
            {
                Cor = "rgb(206,60,49)"; //VERMELHO
            } else
            {
                Cor = "black"; // PRETO 
            }

            return Cor;
        }


        public static string CorNegativoPotisivo_Inverso (double numero)
        {
            string Cor = null;

            if(numero <=0)
            {
                Cor = "rgb(51,122,183)"; //AZUL
            } else
            {
                Cor = "rgb(206,60,49)"; //VERMELHO
            }

            return Cor;
        }
       
    }
}