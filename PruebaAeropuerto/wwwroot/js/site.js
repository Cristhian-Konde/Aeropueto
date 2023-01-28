///<reference path="../lib/jquery/dist/jquery.js" />
function SaveMovimientos() {
    var _data = {
        Matricula: $("#Id_Matricula").val(),
        TipoAvion: $("#Id_TipoAvion").val(),
        Aerolinea: $("#Id_Aerolinea").val(),
        FechaAterizaje: $("#Id_FechaA").val(),
        HoraAterrizaje: $("#Id_HoraA").val(),
    };
    $.ajax({
        type: 'POST',
        url: '/Home/SaveMovimeintos',
        data: JSON.stringify(_data),
        contentType: 'application/json',
        dataType: "JSON",
        success: function (r) {
            toastr.success(r)
        },
        error: function (xhr, status, error) {
            var err = eval("(" + xhr.responseText + ")");
            alert(err.Message);
        }
    });
} 
