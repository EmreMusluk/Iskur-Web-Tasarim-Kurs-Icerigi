import Products from "./components/Products"

let baslik = "ProductList"
let pList = [ 
  {"id": 1, "name": "Kola"},
  {"id": 2, "name": "Peynir"}
]

function App() {
  return (
    <div>
      <Products baslik = {baslik} pList = {pList}/>
    </div>
  );
}

export default App;

//  <Products baslik = {baslik} pList = {}/>
//bu şekilde bu componentte olan değişkenleri diğer componente gönderdik