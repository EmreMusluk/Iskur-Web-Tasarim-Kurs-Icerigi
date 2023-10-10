var drinks = document.getElementById("myList")

var newDrink = document.createElement("li")
//var textNode = document.createTextNode("Water")

newDrink.appendChild(document.createTextNode("Water"))
//newDrink.appendChild(textNode)

drinks.appendChild(newDrink)