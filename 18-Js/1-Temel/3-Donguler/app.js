const cars = ["BMW", "Volvo", "Saab"]
setTimeout(() => {
    document.getElementById("tarih").innerHTML = new Date()
}, 5000);

let text = ""
for (let i = 0; i < cars.length; i++) {
    text += "<li>" + cars[i] + "</li>"
    console.log(cars[i])
    console.log(text)
}

//document javascriptre tüm nesnelere erişmeye yarar.
//html de ol ul body hepsi bir elementtir.
//javascripte elementlerim adı dom'dur.
function GetCars()
{
    document.getElementById("cars").innerHTML = text;
}

function Toggle()
{
    var div = document.getElementById("cars")

    if (div.style.display === 'none') {
        div.style.display = 'block'
    }
    else
    {
        div.style.display = 'none'
    }
}

//ARAŞTIR
//AJAX TECH.