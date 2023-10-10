import React from 'react'

export default function Confirm(props) {
    return (
        <div className="border border-danger rounded ">
            <div>
                {props.children}
            </div>
            <input type="submit" className="btn btn-success" value="Ok" />
            <input type="submit" className="btn btn-danger" value="İptal" />
            <hr></hr>
        </div>
    )
}
