//Tüm örnekler aynı işe yarıyor

// const numbers = [4,9,16,25];
// //map fuction alır 
// n1 = numbers.map(function (i){
//     return i*2
// })
// console.log(n1);

// const numbers = [4,9,16,25];
// n1 = numbers.map((i) => {return i*2})
// console.log(n1);

//Normalde foreach ile yapıyorduk bu şekilde daha kısa ve kolay yaparız.
// const numbers = [4,9,16,25];
// n1 = numbers.map(i => i*2)
// console.log(n1);

let ogr = [
    {"id":1, "ad": "Şamil", "soyad": "Yılmaz"},
    {"id":2, "ad": "Selen", "soyad": "Yılmaz"},
]

html = ogr.map(o => `<li> ${o.ad} ${o.soyad} </li>`).join("")

document.getElementById("liste").innerHTML = html

