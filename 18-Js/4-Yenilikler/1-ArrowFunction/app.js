//ESKİ
// function Topla(a, b)
// {
//     return a+b
// }
// console.log(Topla(4,3));

//YENİ
// const Topla = (a,b) => {
//     return a+b
// }
// console.log(Topla(4,3));

//DAHA KISA
// const Topla = (a,b) => a+b;
// console.log(Topla(4,3));

//Tek parametre ise isimde olan parantezi kaldırsakta olur
//const selamver = (isim) => alert("Merhaba" + isim);
const selamver = isim => alert("Merhaba" + isim);
selamver("Şamil")
