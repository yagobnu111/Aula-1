$('input[name="btnBoasVindas"]').click(
    function () {
        var nome = $('input[name="nome"]').val();
        $('input[type="button"]').click(
            alert("Seja bem vindo " + nome ));
    });
