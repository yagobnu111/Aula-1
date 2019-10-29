$(document).ready(function () {

    $('input[name="btncadastro"]').click(function () {
        // resultado do serialize = nome=&peso=&altura=
        var informacoes = $('form[name="formcadastro"]').serialize();

        var url = "http://localhost:58110/api/Pessoas";

        $.post(url, informacoes, function (data) {

            $('input[name="resultado"]').val("Sucesso!");
            $('input[name="resultado"]').css('background-color', '#9dffb4')

        });
    });
});     