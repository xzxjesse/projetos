document.addEventListener('DOMContentLoaded', function () {
    const calendarBody = document.querySelector('tbody');

    // Adicione eventos ou lógica dinâmica aqui, se necessário

    // Exemplo: Destaque a célula atual
    const today = new Date().getDate();
    if (today > 0) {
        const todayCell = document.querySelector(`td:contains("${today}")`);
        if (todayCell) {
            todayCell.classList.add('today');
        }
    }

    // Adicione um event listener para capturar cliques nas células
    calendarBody.addEventListener('click', function (event) {
        const clickedCell = event.target.closest('td');
        if (clickedCell) {
            toggleEvent(clickedCell);
        }
    });

    // Função para adicionar ou retirar eventos em uma célula
    function toggleEvent(cell) {
        if (cell.classList.contains('event')) {
            cell.classList.remove('event');
        } else {
            cell.classList.add('event');
        }
    }
});

// Função para encontrar célula por texto
jQuery.expr[':'].contains = function (a, i, m) {
    return jQuery(a).text().toUpperCase()
        .indexOf(m[3].toUpperCase()) >= 0;
};
