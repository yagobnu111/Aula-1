
$(document).ready(
    function () {
        /*set interval executa a cada 100ms*/
        atualizaData();

    }); 
/*criamos nossa primeira função */
function atualizaData() {
    /*Agora adicionamos afunção dentro de nosso context do setInterval*/
    setInterval(function () {
        $('span[name = "data_atual"]').text(Date());
    }, 100);
}