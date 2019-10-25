$(document).ready(function () {
   $('input[name="btnconsulta"]').click(function () {
       var nomeUsuario = $('input[name="nomeUsuario"]').val();
       var peso = $('input[name="peso"]').val();
       var altura = $('input[name="altura"]').val();



       $.get("http://localhost:58632/Api/CalculoImc?nomeUsuario=" + nomeUsuario + "&peso=" + peso + "&altura=" + altura, function (data) {

       alert(data);


     });
   });
});
