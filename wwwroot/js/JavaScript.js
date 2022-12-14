
function limparConclusao() {
    document.getElementById("conclusao").innerHTML =
        "<button class='button del-button' onclick='limparConclusao()''><i class='bi bi-trash-fill'></i></button>";
}

/*Arrastar e Soltar Tarefas no Kanban*/
const colunas2 = document.querySelectorAll(".coluna");

document.addEventListener("dragstart", (e) => {
    e.target.classList.add("dragging");
});

document.addEventListener("dragend", (e) => {
    e.target.classList.remove("dragging");
});

colunas2.forEach((tarefa) => {
    tarefa.addEventListener("dragover", (e) => {
        const dragging = document.querySelector(".dragging");
        const applyAfter = getNewPosition(tarefa, e.clientY);

        if (applyAfter) {
            applyAfter.insertAdjacentElement("afterend", dragging);
        } else {
            tarefa.prepend(dragging);
        }
    });
});

function getNewPosition(coluna, posY) {
    const cards = coluna.querySelectorAll(".tarefa:not(.dragging)");
    let result;
    for (let refer_card of cards) {
        const box = refer_card.getBoundingClientRect();
        const boxCenterY = box.y + box.height / 2;
        if (posY >= boxCenterY) result = refer_card;
    }
    return result;
}

/*Funções para abrir e fechar o modal Conteudo da Tarefa*/
const handleClickOutside = (event) => {
    let overlay = document.getElementById("overlay");
    let modal = document.getElementById("modal");

    if (!modal.contains(event.target)) {
        modal.style.display = 'none';
        overlay.style.display = 'none';
        document.removeEventListener('click', handleClickOutside, false);
    }
}


const abrirModal = (codigo) => {

    let overlay = document.getElementById("overlay");
    let modal = document.getElementById("modal");
    overlay.style.display = 'flex';
    modal.style.display = 'flex';
    setTimeout(() => { document.addEventListener('click', handleClickOutside, false) }, 200);

    $.ajax({
        method: "GET",
        url: "/Tarefas/Details",
        data: { codigoTarefa: codigo },
        success: (e) => {
            console.log('Tarefa Encontrada')
        },
        error: (e) => {
            console.log('Tarefa Não Encontrada')
        }
    });

}
