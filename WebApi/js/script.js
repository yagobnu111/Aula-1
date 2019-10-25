
$(document).ready(
    function () {
        $('input[name="cep"]').mask("00000-000");

        $('input[type = "button"]').click(
            function () {
                var cepInformado = $('input[name="cep"]').val();
                if (cepInformado == "")
                    alert("Digite um CEP valido");
                else if (cepInformado.length < 9)
                    alert("CEP deve ter 8 numeros");

                $.get("https://viacep.com.br/ws/" + cepInformado + "/json/", function (data) {
                    if (data.erro) {
                        alert("CEP invalido");       
                        return false;
                    }
                       
                    else
                    {
                        $('input[name="uf"         ]').val(data.uf);
                        $('input[name="localidade" ]').val(data.localidade);
                        $('input[name="bairro"     ]').val(data.bairro);
                        $('input[name="logradouro" ]').val(data.logradouro);
                        $('input[name="complemento"]').val(data.complemento);
                        $('input[name="ibge"       ]').val(data.ibge);
                        $('input[name="unidade"    ]').val(data.unidade);
                        $('input[name="gia"        ]').val(data.gia); 
                    }
                   
                });                
            }
        );
    }
);
