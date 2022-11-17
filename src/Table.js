import React from 'react'
import MaterialTable from 'material-table'

export const Table = () => {

    const data = [
        { name: 'Nestor', age:20 },
        { name: 'Julio', age:30 },
        { name: 'Martin', age:23 },
        { name: 'Lionel', age:28 }
    ]
    const columns = [
        {
            title:'Name',field:'name'
        },
        {
            title:'Age', field:'age'
        }
    ]
    return (<div>
        <MaterialTable
            data={data}
            columns={columns}
        />
    </div>)
}