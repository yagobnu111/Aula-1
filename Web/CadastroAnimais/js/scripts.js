/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var animal = { nome: "dudu", idade: 2, raca: "yorkshire", coloracao: "marrom" };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nomePet"]').val(animal.nome);
        $('input[name="idadePet"]').val(animal.idade);
        $('input[name="racaPet"]').val(animal.raca);
        $('input[name="coloracaoPet"]').val(animal.coloracao);


        $('input[name="btnsalvar"]').click(function () {
            animal.nome = $('input[name="nomePet"]').val();
            animal.idade = $('input[name="idadePet"]').val();
            animal.raca = $('input[name="racaPet"]').val();
            animal.coloracao = $('input[name="coloracaoPet"]').val();
        });

        $('input[name="btnmostrar"]').click(function () {
            alert(animal.nome + "\n" + animal.idade + "\n" + animal.raca + "\n" + animal.coloracao);
            
        });

    }
);
