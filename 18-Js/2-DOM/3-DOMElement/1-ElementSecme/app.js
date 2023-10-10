let element
 
element = document.getElementById("ok")
element = document.getElementById("ipt")
element = document.getElementsByClassName("list-group-item") // HTMLCollection
element = document.getElementsByClassName("list-group-item")[0]
element = document.getElementsByTagName("li")


// // // queryselector il bulduğu DOM
 element = document.querySelector("#drinks") // id baıznda element = document.querySelector("#ok")
 element = document.querySelector(".list-group-item") // ilk list group item bunla bir üsteki aynı burdaki hepsini getiriyor.
  element = document.querySelector(".list-group") 
element = document.querySelector("li") // tag name aynı yukarıdaki ile

// // // queryselectorAll   DOM/hepsini getirir.
  element = document.querySelectorAll(".list-group-item") // Tüm list-group-item NodeList tipi  For each ile içinde dönülür
   element.forEach(function (item){
      console.log(item)
   })

   
  console.log(element)