function SalvarTreino() {
 
    var nome = $("#nomeTreino").val();

    // Gravar
    var url = "/Treino/AdicionaTreino";

    $.ajax({
        url: url
        , type: "POST"
        , datatype: "json"
        , data: { Id: 0, NomeTreino: nome }
        , success: function (data) {
            if (data.Resultado > 0) {
                ListarExercicios(data.Resultado);
            }
        }

    });
}

function ListarExercicios(idTreino) {

    // Gravar
    var url = "/Exercicio/ListarExercicios";

    $.ajax({
        url: url
        , type: "GET"
        , datatype: "html"
        , data: { Id: idTreino }
        , success: function (data) {
            var divExercicios = $("#divExercicios");
            divExercicios.empty();
            divExercicios.show();
            divExercicios.html(data);
        }

    });

}

function SalvarExercicios() {
    debugger;
    var exercicio = $("#Nome").val();
    var serie = $("#Serie").val();
    var repeticao = $("#Repeticoes").val();
    var carga = $("#Carga").val();
    var intervalo = $("#Intervalo").val();
    var idTreino = $("#idTreino").val();

    var url = "/Exercicio/AdicionaExercicio";

    $.ajax({
        url: url
        , type: "GET"
        , datatype: "json"
        , data: { ExercicioNome: exercicio, Series: serie, Repeticoes: repeticao, Carga: carga, Intervalo: intervalo, TreinoId: idTreino }
        , success: function (data) {
            if (data.Resultado > 0) {
                ListarExercicios(idTreino);
            }
            debugger;
        }
    });
}