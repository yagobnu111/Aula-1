    $('input[name="botao"]').click(
        function () {
            var valor = $('input[name="valor"]').val().replace("R$", "").replace(/\./g, '').replace(/,/g, ".");
            var valorConvertido = valor / 4.17;
            $('input[name="botao"]').click(
                document.getElementById("valorConvertido").value = '$ ' + Number.parseFloat(valorConvertido.toFixed(3)).toLocaleString('en-US'));
    });

$(document).ready(function () {
    $(".mascaraReal").maskMoney({
        prefix: 'R$',
        allowNegative: true,
        thousands: '.',
        decimal: ',',
    });
});
