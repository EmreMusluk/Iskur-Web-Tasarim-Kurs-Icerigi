// let x = [10,20,30]
// console.log(x)
// //Diziye ekleme yaptık
// x.push(40)
// console.log(x)


// let x = [10,20,30]
// console.log(x);
// //...x x dizisini mevcut halini koru birde 50 ekle
// x = [...x, 50]
// console.log(x);


// let a = [10,20,30,40]
// //Arrow Fuction
// //A dizisinin mevcut halini koruyarak şartı sağlayan bir dizi daha ekledik
// a = [...a , a.filter(i=> i<20)]
// //Burada a dizisinden koşulu sağlayan elemanları getirdik ve b ye atadık artık b de bir dizi oldu
// b = a.filter(x=> x<20)
// console.log(a)
// //10,20,30,10, [10]
// console.log(b)
// //10,[10]



//personel dizisine bir ekleme yaptık
personel = []
p1 = {"id":1, "ad":"Şamil"}
personel = [...personel, p1]
console.log(personel)


ogrenciler = [
    {"id":1, "ad":"Şamil"},
    {"id":2, "ad":"Kamil"}
]

yogrenci = {"id":3, "ad":"Ahmet"}
ogrenciler = [...ogrenciler,yogrenci]
console.log(ogrenciler);