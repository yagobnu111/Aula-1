/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var bike = { marca: "Caloi", valor: 1800, peso: 2 };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="marcaBike"]').val(bike.marca);
        $('input[name="valorBike"]').val(bike.valor);
        $('input[name="pesoBike"]').val(bike.peso);


        $('input[name="btnsalvar"]').click(function () {
            bike.marca = $('input[name="marcaBike"]').val();
            bike.valor = $('input[name="valorBike"]').val();
            bike.peso = $('input[name="pesoBike"]').val();

            LimparTela();
        });

        $('input[name="btnmostrar"]').click(function () {
            alert(bike.marca + "\n" + bike.valor + "\n" + bike.peso );      
        });

    }
);
function LimparTela() {
    var meusInputs = $('input[type="text"]');

        meusInputs.val("");
}
