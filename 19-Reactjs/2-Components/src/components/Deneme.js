//yüklediğimiz extension sayedinde hızlıca yazarız
//rfc tab deriz kodlar gelir

import React from 'react'

const Deneme = () => {
    let baslik = "Personel Listesi";
    let pList = [
        { "Id": 1, "Ad": "Şamil", "Soyad": "Yılmaz" },
        { "Id": 2, "Ad": "Selen", "Soyad": "Yılmaz" }
    ]
    var html = pList.map(p => {
        return (<tr>
            <td>{p.Id}</td>
            <td>{p.Ad}</td>
            <td>{p.Soyad}</td>
        </tr>)
    })
    return (
        <>
            <h3>Deneme</h3>
            <p>{baslik}</p>
            <hr />
            <table className='table'>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Ad</th>
                        <th>Soyad</th>
                    </tr>
                </thead>
                <tbody>
                    {html}
                </tbody>
            </table>
        </>
    )
}

export default Deneme
