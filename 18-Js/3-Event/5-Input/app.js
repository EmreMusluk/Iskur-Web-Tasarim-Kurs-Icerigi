//Html de bir input alanı olması lazım
//focus : üzerine tıkladığımızda 
//blur : çıktığımızda 
//paste : inputa yapıştırma yaptığımızda
//copy : inputtan kopyalama yaptığımızda
//cut : inputtan kesme yaptığımızda
//select : inputtan seçme yaptığımızda

inputDrink = document.getElementById("ad")

inputDrink.addEventListener("focus", log)
inputDrink.addEventListener("blur", log)
inputDrink.addEventListener("paste", log)
inputDrink.addEventListener("copy", log)
inputDrink.addEventListener("cut", log)
inputDrink.addEventListener("select", log)

function log(e)
{
    console.log(e.type)
    console.log(e.target)
    console.log(e.target.value)
}