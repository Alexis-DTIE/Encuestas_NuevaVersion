$(document).ready(function () {
    

    var ID_ENCUESTA = $("#ID_ENCUESTA").val();

        $.ajax({
            type: "POST",
            url: "Fichatecnica?ID_ENCUESTA=" + ID_ENCUESTA,
            contentType: "html",
            success: function (result) {
                console.log(result)
                if (!result?.data) {
                    
                    $("#nombre").text("No Existe")
                   
                } else {
                  
                    $("#nombre").text(result.data.Nombre)
                   
                }

            }
        });
    
});