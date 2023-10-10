
function Topla(params)
{
    document.getElementById("sonuc").innerHTML = Cevir("s1") + Cevir("s2")
}

function Cikar(params)
{
    document.getElementById("sonuc").innerHTML = Cevir("s1") - Cevir("s2")
}

function Carp(params)
{
    document.getElementById("sonuc").innerHTML = Cevir("s1") * Cevir("s2")
}

function Bol(params)
{
    document.getElementById("sonuc").innerHTML = Cevir("s1") / Cevir("s2")
}

function Cevir(id)
{
  return Number(document.getElementById(id).value) 
}