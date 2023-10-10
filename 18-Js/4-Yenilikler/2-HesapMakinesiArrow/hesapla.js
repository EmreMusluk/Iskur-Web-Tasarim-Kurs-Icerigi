
const Topla = () => Yaz(Cevir("s1") + Cevir("s2"))
const Cikar = () => Yaz(Cevir("s1") - Cevir("s2"))
const Carp = () => Yaz(Cevir("s1") * Cevir("s2"))
const Bol = () => Yaz(Cevir("s1") / Cevir("s2"))

const Cevir = (id) => Number(document.getElementById(id).value) 

