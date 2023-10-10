import React from 'react'
import Confirm from './Confirm'

export default function Personel({ pList }) {
    let html = pList.map(p => {
        return (
            <Confirm key={p.name}>
                <p>{p.name}{p.surname} {p.maas}</p>
            </Confirm>
        )
    })
    return (
        <div>
            <ul>
                {html}
            </ul>
        </div>
    )
}
