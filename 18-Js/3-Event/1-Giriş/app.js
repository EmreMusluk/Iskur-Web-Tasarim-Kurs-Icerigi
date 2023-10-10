
const drinkform=document.getElementById("drinkform")

drinkform.addEventListener("submit",submitForm)
// onsubmit="submitForm(event) bunla aynı 




function submitForm(e) {
    console.log(e.target)
    console.log('form submitted')

    e.preventDefault();
    //bunu kaldırısan kaldırır ekleyi tıkladğın anda ve refresh eder javascript
 }
 //indexte submitFormu çalıştırıyor arka planda hepsini f12 yaparak ekle yaparal ekliyor
 