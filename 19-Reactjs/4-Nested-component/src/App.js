import Confirm from "./components/Confirm";
import Personel from "./components/Personel";

const pList = [
  { "name": "Şamil", "surname": "Yılmaz", "maas": 3000 },
  { "name": "Mehmet", "surname": "Yılmaz", "maas": 3200 },
]

function App() {
  return (
    <>
      <Personel pList={pList} />
    </>
  );
}

export default App;
