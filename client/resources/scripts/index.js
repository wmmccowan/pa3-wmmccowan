let drivers = [];
const driversurl = "https://localhost:7167/api/Drivers";
const body = document.getElementById('root');
let table = document.createElement('table');
table.className = 'table';
let thead = document.createElement('thead');
table.appendChild(thead);

function handleOnLoad()
{
    createDriversTable();
}

function createDriversTable()
{
    fetch(driversurl).then(function(response) {
        console.log(response);
        return response.json();
    }).then(function(json) {
        console.log(json);
        drivers = json;
        createHeader();
        createBody();
    });
}

function createHeader() {
    let tr = document.createElement('tr');
    let array = ['Id', 'Name', 'Rating', 'DateHired', 'Deleted'];

    array.forEach((heading) => {
        let th = document.createElement('th');
        th.appendChild(document.createTextNode(heading));
        tr.appendChild(th);
    })
    thead.appendChild(tr);
    body.appendChild(table);
}

function createBody() {
    drivers.forEach((driver) => {
        let tr = document.createElement('tr');

        let idTd = document.createElement('td');
        idTd.appendChild(document.createTextNode(driver.id));
        tr.appendChild(idTd);

        let nameTd = document.createElement('td');
        nameTd.appendChild(document.createTextNode(driver.name));
        tr.appendChild(nameTd);

        let ratingTd = document.createElement('td');
        ratingTd.appendChild(document.createTextNode(driver.rating));
        tr.appendChild(ratingTd);

        let hiredateTd = document.createElement('td');
        hiredateTd.appendChild(document.createTextNode(driver.hiredate));
        tr.appendChild(hiredateTd);

        let deletedTd = document.createElement('td');
        deletedTd.appendChild(document.createTextNode(driver.deleted));
        tr.appendChild(deletedTd);

        table.appendChild(tr);
    })
}

function handleAddDriver() {
    let newDriver = document.getElementById('newDriver').value;
    console.log(newDriver)
    PostDriver({'Name': newDriver})
}

function PostDriver() {
    fetch(driversurl, {
        method: 'POST',
        headers: {
            "Accept" : 'application/json',
        },
        body: JSON.stringify(drivers)
    }).then((response) => {
        console.log(response);
    })
        
    };
