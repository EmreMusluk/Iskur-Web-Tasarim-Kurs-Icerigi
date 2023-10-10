document.addEventListener("DOMContentLoaded", list)

const url = "https://localhost:7190/"

function list() {
    console.log(url);

    //fetch(url + "City/" + "GetCities")-aşağıdaki ile aynı
    fetch(`${url}City/GetCities`)
        .then(response => response.json())
        .then(cities => {
            console.log(cities)
            //map ile aslında foraech ve funciton(c=>) yapmış olduk
            //citiesi mapleyerek html formatında yazdırdık
            var html = cities.map(c =>
            (`<tr>
                            <td> ${c.id} </td> 
                            <td> ${c.name} </td> 
                            <td><a href="" class="btn btn-danger" onclick="del(${c.id})">Sil</a></td>
                            <td><a href="update.html" class="btn btn-success" onclick="updt(${c.id})">Güncelle</a></td>
                            </tr>`)
            ).join("")

            //joini verilerin arasına otomatik virgül atadığı için onun kalkması için ekledik.
            document.getElementById("cities").innerHTML = html
        })
        .catch((err) => console.log(error))
}

function add() {
    //genelde payload 
    let payload = {
        name: document.getElementById("name").value
    }
    fetch(`${url}City/Add`, {
        //Postmande ki posta karşılık
        method: "POST",
        //Postmadeki body kısmına karşılık gelir
        body: JSON.stringify(payload),
        //Postmandeki headers daki Content-type karşılık gelir
        headers: { "Content-type": "application/json;cahrset0UTF-8" }
    })
        //fetch de yazdığımız her şey responsın içine sığdı
        .then(response => response.json())
        .then(rsp => {
            console.log(rsp)
            document.getElementById("msg").innerHTML = rsp.msg
        })
        .catch((err) => console.log(error))
}

// `` back tick - ters slaş + yerine geçiyor 

function del(id) {
    getDo
    fetch(`${url}City/DeleteById/${id}`, {
        method: 'DELETE',
        // body: JSON.stringify(payload),
        // headers: { "Content-type" : "application/json; charset=UTF-8"}
    })
        .then(response => response.json())
        .then(rsp => {
            console.log(rsp);
            document.getElementById("msg").innerHTML = rsp.msg
        })
}

function updt() {
    let payload = {
        id: document.getElementById("id").value,
        name: document.getElementById("name").value
    }
    fetch(`${url}City/Update`, {
        method: 'PUT',
        body: JSON.stringify(payload),
        headers: { "Content-type": "application/json; charset=UTF-8" }
    })
        .then(response => response.json())
        .then(rsp => {
            console.log(rsp);
            document.getElementById("msg").innerHTML = rsp.msg
        })
}
