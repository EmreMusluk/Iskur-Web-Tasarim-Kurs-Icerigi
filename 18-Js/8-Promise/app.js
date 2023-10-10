function myDisplayer(some) {
    document.getElementById("demo").innerHTML = some;
}

let myPromise = new Promise(function(myResolve, myReject) {
    
    let x = 0;
  
  // some code (try to change x to 5)
  
    if (x == 0) {
      myResolve("OK");
    } else {
      myReject("Error");
    }
  });


  myPromise.then(
    function(value) {myDisplayer(value)},
    function(error) {myDisplayer(error)}
  )

  //promise await ile birlikte kullanılır callback ten yeni bir teknoloji geriye herhangi bir tipte veri gönderir.

  //Promise bir işlemin sonucunu temsil eden bir Javascript nesnesidir. 
  //Promise nesnesi Resolve ve Reject adında iki tane parametre alır ve olumlu durumlarda 
  //Resolve ile belirtilen işlemlerin, olumsuz durumlarda da Reject ile belirtilen işlemlerin yapılacağına dair güvence verir. 
  //Promise yapısı olumlu sonuçları .then(), olumsuz sonuçları da .catch() ile karşılar.
