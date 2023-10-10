const drinkList = document.querySelector("ul.list-group")
const drinks = document.querySelectorAll("li.list-group-item")

drinks[2].remove()
drinks[3].remove()
drinks[4].remove()

drinkList.removeChild(drinkList.lastElementChild) //diğer yöntem bu da yukarıdaki siliyor bu da
drinkList.removeChild(drinks[0])

console.log(drinkList)