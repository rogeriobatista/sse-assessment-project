
registerEvents();

getContent();

function getContent() {
    fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then(json => render(json));
}

function render(responseJson) {

    const mainContentElement = document.getElementById('main-content');

    let contentHTML = '';

    responseJson.forEach(item => {
        contentHTML += `<li class="list-group-item">${item.name}</li>`;
    });

    mainContentElement.innerHTML = contentHTML;
}

function registerEvents() {
    document.getElementById('refresh-button').addEventListener('click', getContent)
}