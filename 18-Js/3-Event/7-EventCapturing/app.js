//classı table olan tabloda tıklanan yerin adını verir.

drinktable = document.querySelector(".table")

drinktable.addEventListener("click", log)

function log(e)
{
    console.log(e.target)
}