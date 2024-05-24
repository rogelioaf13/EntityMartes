function ConsultarNombre() {

    let identificacion = $("#identificacion").val();

    if (identificacion.length > 0) {
        $.ajax({
            type: "GET",
            url: "https://apis.gometa.org/cedulas/" + identificacion,
            dataType: "json",
            success: function (result) {
                $("#nombre").val(result.nombre);
            }
        });
    }
    else {
        $("#nombre").val("");
    }
}