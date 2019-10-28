$(document).ready(function () {

    $('input[name="btnconsulta"]').click(function () {
        // resultado do serialize = nome=&peso=&altura=
        var informacoes = $('form[name="formimc"]').serialize();

        var url = "http://localhost:62981/api/Imc";

        $.post(url, informacoes, function (data) {

            $('input[name="imc"]').val(data.ImcValue);
            $('input[name="situacao"]').val(data.Situacao);

        });
    });
});     















/*$(document).ready(function () {

    $('input[name="altura"]').mask('0.00');


   $('input[name="btnconsulta"]').click(function () {
       var nomeUsuario = $('input[name="nomeUsuario"]').val();
       var peso = $('input[name="peso"]').val();
       var altura = $('input[name="altura"]').val();

       $.get("http://localhost:62981/api/Imc?peso=" + peso + "&altura=" + altura, function (imc) {
                
           $('input[name="imc"]').val(imc);

               $.get("http://localhost:62981/api/Imc?imc=" + imc, function (situacao) {

                   $('input[name="situacao"]').val(situacao);

                   $.get("http://localhost:62981/api/Imc?nome=" + nomeUsuario + "&peso=" + peso + "&altura=" + altura, function (data) {

                       alert(data);
               });
           });
       });
   });
});*/
