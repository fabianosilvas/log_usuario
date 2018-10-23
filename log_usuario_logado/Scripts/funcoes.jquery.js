function GravarLogRequisicao() {

    var noSistemaOperacional = "Desconhecido";
    if (window.navigator.userAgent.indexOf("Windows NT 10.0") != -1) noSistemaOperacional = "Windows 10";
    if (window.navigator.userAgent.indexOf("Windows NT 6.2") != -1) noSistemaOperacional = "Windows 8";
    if (window.navigator.userAgent.indexOf("Windows NT 6.1") != -1) noSistemaOperacional = "Windows 7";
    if (window.navigator.userAgent.indexOf("Windows NT 6.0") != -1) noSistemaOperacional = "Windows Vista";
    if (window.navigator.userAgent.indexOf("Windows NT 5.1") != -1) noSistemaOperacional = "Windows XP";
    if (window.navigator.userAgent.indexOf("Windows NT 5.0") != -1) noSistemaOperacional = "Windows 2000";
    if (window.navigator.userAgent.indexOf("Mac") != -1) noSistemaOperacional = "Mac/iOS";
    if (window.navigator.userAgent.indexOf("X11") != -1) noSistemaOperacional = "UNIX";
    if (window.navigator.userAgent.indexOf("Linux") != -1) noSistemaOperacional = "Linux";
    if (window.navigator.userAgent.indexOf("Android") != -1) noSistemaOperacional = "Android";
    if (window.navigator.userAgent.indexOf("iPhone OS") != -1) noSistemaOperacional = "iPhone";

    //alert(noSistemaOperacional);

    var deResolucaoTela = $(window).width() + 'x' + $(window).height();
    //alert(deResolucaoTela);

    var de_pagina = window.location;
    //alert(de_pagina);

    var de_pagina_origem_requisicao = document.referrer;
    //alert(de_pagina_origem_requisicao);

    
    $.ajax({
        type: "POST",
        url: "/SISLOG/Acesso/LogRequisicao?de_pagina=" + de_pagina + "&deResolucaoTela=" + deResolucaoTela + "&noSistemaOperacional=" + noSistemaOperacional + "&de_pagina_origem_requisicao=" + de_pagina_origem_requisicao,
        dataType: "html",
        success: function () {
            //alert("Requisição Ajax processada com sucesso.");
        },
        error: function () {
            alert("Ocorreu um erro na Requisição Ajax.");
        }
    });
};


//function CorPercentualRealize(ValorPercentual) {
//    var Cor = null;

//    switch (true) {
//        case (ValorPercentual >= 100):
//            Cor = "rgb(51,122,183)" //AZUL
//            break;
//        case (ValorPercentual >= 90 &&  ValorPercentual < 100):
//            Cor = "rgb(60,118,61)" //VERDE
//            break;
//        case (ValorPercentual >= 80 &&  ValorPercentual < 90):
//            Cor = "rgb(255,153,0)" //AMARELO
//            break;
//        default:
//            Cor = "rgb(206,60,49)" //VERMELHO
//    }
//    alert(Cor);
//}

//CorPercentualRealize(80);

/*
function CorPercentualRealize(ValorPercentual)
SELECT CASE TRUE
CASE  ValorPercentual >= 100 Cor = "rgb(51,122,183)" 'AZUL
CASE  ValorPercentual >= 90 AND  ValorPercentual < 100  Cor = "rgb(60,118,61)" 'VERDE
CASE  ValorPercentual >= 80 AND  ValorPercentual < 90  Cor = "rgb(255,153,0)" 'AMARELO
CASE ELSE  Cor = "rgb(206,60,49)" 'VERMELHO
END SELECT
response.write(Cor)
end function 

    function CorPercentualRealizeTransparencia(ValorPercentual)
SELECT CASE TRUE
CASE  ValorPercentual >= 100 Cor = "rgba(12,120,196,0.70)" 'AZUL
CASE  ValorPercentual >= 90 AND  ValorPercentual < 100  Cor = "rgba(136,204,0,0.70)" 'VERDE
CASE  ValorPercentual >= 80 AND  ValorPercentual < 90  Cor = "rgba(255,204,51,0.70)" 'AMARELO
CASE ELSE  Cor = "rgba(255,102,102,0.70)" 'VERMELHO
END SELECT
response.write(Cor)
end function 

    function CorNomeRealize(nomeCor)
SELECT CASE TRUE
CASE  nomeCor = "AZUL" Cor = "rgb(51,122,183)" 'AZUL
CASE  nomeCor = "VERDE"  Cor = "rgb(60,118,61)" 'VERDE
CASE  nomeCor = "AMARELO"  Cor = "rgb(255,153,0)" 'AMARELO
CASE  nomeCor = "VERMELHO" Cor = "rgb(206,60,49)" 'VERMELHO
END SELECT
response.write(Cor)
end function


	function CorNegativoPotisivo(Numero)
SELECT CASE TRUE
CASE  Numero < 0 Cor = "rgb(206,60,49)"  'VERMELHO
CASE ELSE  Cor = "black" 'PRETO 
END SELECT
response.write(Cor)
end function

	function CorNegativoPotisivo_Inverso(Numero)
SELECT CASE TRUE
CASE  Numero <= 0 Cor = "rgb(51,122,183)" 'AZUL
CASE ELSE  Cor = "rgb(206,60,49)"  'VERMELHO
END SELECT
response.write(Cor)
end function

    function CorNumeroZero(Numero)
SELECT CASE TRUE
CASE  Numero = 0 Cor = "#cccccc"  'CINZA
CASE ELSE  Cor = "black" 'PRETO 
END SELECT
response.write(Cor)
end function
*/


//alert("OK");