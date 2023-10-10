import React from 'react'

export default function test() {
    return (
        <div>test</div>
    )
}

function f1() {
    console.log("f1");
}

const f2 = () => {

}

export { f1, f2 }
//bunlara modül denir, diğer yerlerde kullanmak için yaparız.