

$(document).ready(function () {
    $("#btnbuscar").click(function () {

        var Cedula = $("#cedula").val();
       
        $.ajax({
            type: "get",
            url: "Home/GetCedula?cedula=" + Cedula,
            contentType: "html",
            success: function (result) {
                console.log(result)
                if (!result?.data) {
                    $("#img_campo").attr("src", "~/Content/Img/portrait_placeholder.png");
                    $("#nombre").text("No Existe")
                    $("#apellido").text("")
                    $("#provincia").text("")
                    $("#telefono").text("")
                    $("#encuesta").text("")
                    $("#cargo").text("")
                } else {
                    //var foto = JSON.stringify(result.data.Foto);
                    //console.log(foto)
                    $("#img_campo").attr("src", result.data.Foto);
                    $("#nombre").text(result.data.Nombre)
                    $("#apellido").text(result.data.Apellido)
                    $("#provincia").text(result.data.Provincia)
                    $("#telefono").text(result.data.Teléfono1)
                    $("#encuesta").text(result.data.Encuesta)
                    $("#cargo").text(result.data.Cargo)
                }
              
            }
        });
    });
});