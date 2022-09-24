$().ready(function() {

    $("#btnLogin").click(function(e){
        
        //Validar los datos
        var usuario = $("#usuario").val();
        var password = $("#password").val();

        if( usuario.trim() == ""){
            alert("Debe diligenciar el usuario");
            return;
        }
        if( password.trim() == ""){
            alert("Debe diligenciar el password");
            return;
        }

        //Envio de datos al servidor
        $.ajax({
            type: "POST",
            url: "/Login?handler=ValidateLogin",
            contentType: "application/x-www-form-urlencoded; charset=utf-8",
            dataType: "html",
            headers: {
                "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            data: { "Usuario" : usuario, "Password" : password },
        })
        .done(function (result) {
            console.log(result);
            if(result != ""){
                //Redirección
                window.location.href = result;
            }else{
                alert("El usuario o el password son incorrectos");
            }                       
        })
        .fail(function (error) {
            console.log(error);
            alert("Código: " + error.status + ", Error: " + error.responseText);
        });
        
    });

});