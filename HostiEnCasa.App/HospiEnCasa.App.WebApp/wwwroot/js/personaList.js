$().ready(function(){
    
    $("#crearPersona").click(function(){
        $("#modalRegistrar").modal('show');
    });

    $(document).on('click', '#tablePersonas tbody tr td a.btn.bg-info', function(){
        
        var IdPaciente = 0;

        $(this).parent().parent().find('td').each(function(index){
            switch(index){
                case 0:
                    IdPaciente = $(this).text();
                    break;
            }
        });

        //Cargar los datos
        $.ajax({
            type: "POST",
            url: "/GestionPersonas/List?handler=ObtenerSignosVitales",
            contentType: "application/x-www-form-urlencoded; charset=utf-8",
            dataType: "json",
            headers: {
                "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            data: { "IdPaciente" : IdPaciente },
        })
        .done(function (result) {            
            console.log(result);                
        })
        .fail(function (error) {
            console.log("Código: " + error.status + ", Error: " + error.responseText);
        });
        
        $('#modalDetalle').modal('show');
    });

    $(document).on('click', '#tablePersonas tbody tr td a.btn.bg-warning', function(){
        
        $(this).parent().parent().find('td').each(function(index){
            switch(index){
                case 0:
                    $('#IdPaciente').val($(this).text());
                    break;  
                case 1:
                    $('#nombrePaciente').val($(this).text());
                    break;                
            }
        });
        
        $('#modalMedico').modal('show');
    });

    $(document).on('click', '#tablePersonas tbody tr td a.btn.bg-danger', function(){
        
        $(this).parent().parent().find('td').each(function(index){
            switch(index){
                case 0:
                    $('#idPersonaEliminar').val($(this).text());
                    break;  
                case 5:
                    $('#idTipoPersonaEliminar').val($(this).text());
                    break;                
            }
        });
        
        $('#modalEliminar').modal('show');
    });

    $(document).on('click', '#tablePersonas tbody tr td a.btn.btn-primary', function(){
        $(this).parent().parent().find('td').each(function(index){
            switch(index){
                case 0:
                    $('#Id').val($(this).text());
                    break;
                case 1:
                    $('#nombre').val($(this).text());
                    break;
                case 2:
                    $('#apellido').val($(this).text());
                    break;
                case 3:
                    $('#telefono').val($(this).text());
                    break;
                case 4:
                    $('#genero').val($(this).text());
                    break;
            }
        });

        $('#modalEditar').modal('show');

    });

    $("#btnActualizar").click(function(){
        //Validar datos

        var genero = ($("#genero").val() == "Femenino" ? 0 : 1);

        /* Enviar petición AJAX datos JSON */
        var persona = { 
            "Id": $("#Id").val(), 
            "Nombre": $("#nombre").val(), 
            "Apellidos": $("#apellido").val(), 
            "NumeroTelefono": $("#telefono").val(), 
            "Genero": genero 
        };

        $.ajax({
            type: "POST",
            url: "/GestionPersonas/List?handler=UpdateJson",
            contentType: "application/json; charset=utf-8",
            dataType: "html",
            headers: {
                "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            data: JSON.stringify(persona),
        })
        .done(function (result) {
            alert(result);
            console.log(result);
            location.reload();
        })
        .fail(function (error) {
            console.log(result);
            alert(error);
        });

    });

    $("#discriminadorR").change( function() {
        
        $("#panelPaciente").hide();
        $("#panelMedico").hide();
        $("#panelEnfermera").hide();
        $("#panelFamiliar").hide();

        switch( $("#discriminadorR").val() ){
            case "Paciente" : 
                $("#panelPaciente").show();
                break;
            case "Medico" : 
                $("#panelMedico").show();
                break;
            case "Enfermera" : 
                $("#panelEnfermera").show();
                break;
            case "FamiliarDesignado" : 
                $("#panelFamiliar").show();
                break;
        }
        
    });

    $("#btnRegistrar").click(function(){

        //Validar los datos antes de enviarlos
        var genero = ($("#generoR").val() == "Femenino" ? 0 : 1);

        switch( $("#discriminadorR").val() ){
            case "Persona" : 
                
                var persona = {
                    "NoDocumento": $("#noDocumentoR").val(), 
                    "Nombre": $("#nombreR").val(), 
                    "Apellidos": $("#apellidoR").val(), 
                    "NumeroTelefono": $("#telefonoR").val(), 
                    "Discriminator": $("#discriminadorR").val(), 
                    "Genero": genero 
                }
        
                $.ajax({
                    type: "POST",
                    url: "/GestionPersonas/List?handler=Create",
                    contentType: "application/json; charset=utf-8",
                    dataType: "html",
                    headers: {
                        "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
                    },
                    data: JSON.stringify(persona),
                })
                .done(function (result) {
                    console.log(result);
                    alert(result);                    
                    location.reload();
                })
                .fail(function (error) {
                    console.log(result);
                    alert(error);
                });

                break;

            case "Paciente" : 

                var paciente = {
                    "NoDocumento": $("#noDocumentoR").val(), 
                    "Nombre": $("#nombreR").val(), 
                    "Apellidos": $("#apellidoR").val(), 
                    "NumeroTelefono": $("#telefonoR").val(), 
                    "Discriminator": $("#discriminadorR").val(), 
                    "Genero": genero,
                    "Direccion": $("#direccion").val(), 
                    "Latitud": $("#latitud").val(), 
                    "Longitud": $("#longitud").val(),
                    "Ciudad": $("#ciudad").val()
                }
        
                $.ajax({
                    type: "POST",
                    url: "/GestionPersonas/List?handler=CreatePaciente",
                    contentType: "application/json; charset=utf-8",
                    dataType: "html",
                    headers: {
                        "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
                    },
                    data: JSON.stringify(paciente),
                })
                .done(function (result) {
                    console.log(result);
                    alert(result);                    
                    location.reload();
                })
                .fail(function (error) {
                    console.log(result);
                    alert(error);
                });

                break;
                
            case "Medico" : 

                var medico = {
                    "NoDocumento": $("#noDocumentoR").val(), 
                    "Nombre": $("#nombreR").val(), 
                    "Apellidos": $("#apellidoR").val(), 
                    "NumeroTelefono": $("#telefonoR").val(), 
                    "Discriminator": $("#discriminadorR").val(), 
                    "Genero": genero,
                    "Especialidad": $("#especialidad").val(), 
                    "Codigo": $("#codigo").val(), 
                    "RegistroRethus": $("#rethus").val()
                }
        
                $.ajax({
                    type: "POST",
                    url: "/GestionPersonas/List?handler=CreateMedico",
                    contentType: "application/json; charset=utf-8",
                    dataType: "html",
                    headers: {
                        "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
                    },
                    data: JSON.stringify(medico),
                })
                .done(function (result) {
                    console.log(result);
                    alert(result);                    
                    location.reload();
                    //$('#modalMedico').modal('hide');
                    //Agregar los datos al dom, o crear un ws que recargue el listado de la página
                })
                .fail(function (error) {
                    console.log(result);
                    alert(error);
                });

                break;
                
            case "Enfermera" : 
                break;
            case "FamiliarDesignado" : 
                break;
                
        }

    });

    $("#btnEliminar").click(function(){
       
        $.ajax({
            type: "POST",
            url: "/GestionPersonas/List?handler=Delete",
            contentType: "application/x-www-form-urlencoded; charset=utf-8",
            dataType: "html",
            headers: {
                "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            data: { "Id" : $("#idPersonaEliminar").val(), "TipoPersona" : $("#idTipoPersonaEliminar").val()},
        })
        .done(function (result) {
            console.log(result);
            alert(result);                    
            location.reload();
        })
        .fail(function (error) {
            console.log(error);
            alert("Código: " + error.status + ", Error: " + error.responseText);
        });

    });

    $("#btnAsignarMedico").click(function(){
       
        $.ajax({
            type: "POST",
            url: "/GestionPersonas/List?handler=AsignarMedico",
            contentType: "application/x-www-form-urlencoded; charset=utf-8",
            dataType: "html",
            headers: {
                "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            data: { "IdPaciente" : $("#IdPaciente").val(), "IdMedico" : $("#IdMedico").val()},
        })
        .done(function (result) {
            console.log(result);
            alert(result);                    
            location.reload();
        })
        .fail(function (error) {
            console.log(error);
            alert("Código: " + error.status + ", Error: " + error.responseText);
        });

    });

});