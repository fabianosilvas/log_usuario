﻿function GravarAcesso() {

    var noSistemaOperacional = "Unknown";
    if (window.navigator.userAgent.indexOf("Windows NT 10.0") != -1) noSistemaOperacional = "Windows 10";
    if (window.navigator.userAgent.indexOf("Windows NT 6.2") != -1) noSistemaOperacional = "Windows 8";
    if (window.navigator.userAgent.indexOf("Windows NT 6.1") != -1) noSistemaOperacional = "Windows 7";
    if (window.navigator.userAgent.indexOf("Windows NT 6.0") != -1) noSistemaOperacional = "Windows Vista";
    if (window.navigator.userAgent.indexOf("Windows NT 5.1") != -1) noSistemaOperacional = "Windows XP";
    if (window.navigator.userAgent.indexOf("Windows NT 5.0") != -1) noSistemaOperacional = "Windows 2000";
    if (window.navigator.userAgent.indexOf("Mac") != -1) noSistemaOperacional = "Mac/iOS";
    if (window.navigator.userAgent.indexOf("X11") != -1) noSistemaOperacional = "UNIX";
    if (window.navigator.userAgent.indexOf("Linux") != -1) noSistemaOperacional = "Linux";
    //alert(noSistemaOperacional);

    var deResolucaoTela = $(window).width() + 'x' + $(window).height();
    //alert(deResolucaoTela);

    var de_pagina = window.location;
    //alert(de_pagina);


    $.ajax({
        type: "GET",
        url: "/SISLOG/Registra/Acesso?de_pagina=" + de_pagina + "&deResolucaoTela=" + deResolucaoTela + "&noSistemaOperacional=" + noSistemaOperacional,
        dataType: "html",
        success: function () {
            //alert("Requisição Ajax processada com sucesso.");
        },
        error: function () {
            alert("Ocorreu um erro na Requisição Ajax.");
        }
    });

	//alert("OK");
};