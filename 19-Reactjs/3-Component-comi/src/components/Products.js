//eskiden reactı import etmek şarttı artık oda şart değil
//import React from 'react'

//aşağıdaki 3 yöntemde aynıdır.

// export default function Products() {
//   return (
//     <div>Products</div>
//   )
// }

// export default Products() {
//     return (
//       <div>Products</div>
//     )
//   }


//props dediğimizde dışarıda gönderilen parametreleri alır.
const Products = ({baslik, pList}) => {
    let renderList = pList.map(p => {
        return (
            <tr>
                <td>{p.id}</td>
                <td>{p.name}</td>
            </tr>
        )
    })
    return (
        <>
            <h4>{baslik}</h4>
            <table className="table table-hover">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {renderList}
                </tbody>
            </table>
        </>
    )
}
export default Products
  //modern reactda div demeye de gerek yok <> </> yazsakta olur.