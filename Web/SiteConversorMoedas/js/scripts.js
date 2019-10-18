$(document).ready(function () {
    var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";

    $.getJSON(url, function (data) {

        $('input[name="botao"]').click(
            function () {

                var valorDolar = data.value[0].cotacaoVenda;
                var valor = $('input[name="valor"]').val().replace("R$", "").replace(/\./g, '').replace(/,/g, ".");
                var valorConvertido = valor / valorDolar;
                $('input[name="botao"]').click(
                    document.getElementById("valorConvertido").value = '$ ' + Number.parseFloat(valorConvertido.toFixed(3)).toLocaleString('en-US'));
            });


        $(".mascaraReal").maskMoney({
            prefix: 'R$',
            allowNegative: true,
            thousands: '.',
            decimal: ',',
        });

    });
});
