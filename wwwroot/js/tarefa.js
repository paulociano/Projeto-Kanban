function addTarefa() {

    var datahora = Date.now();
    var today = new Date(timeElapsed);
    var chave = today.toISOString;
    console.log(chave);

    var tarefaNome = document.getElementById("tarefaText").value;

    var backlog = document.getElementById("backlog");
    var ultimaTarefa = backlog.lastElementChild;

    backlog.innerHTML +=
        "<div class='tarefa' draggable='true' onclick='abrirModal()'>" + tarefaNome + "</div>";
    document.getElementById("tarefaText").value = "";

    ultimaTarefa.className += chave;

    $.ajax({
        method: "POST",
        url: "/Tarefas/Create",
        data: { nome: tarefaNome, codigodate:chave },
        success: (e) => {
            alert('Tarefa criada com sucesso!')
        },
        error: (e) => {
            alert('Não foi possível criar a tarefa!')
        }
    });

}