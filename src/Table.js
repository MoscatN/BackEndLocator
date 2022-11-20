//import React, { Component } from 'react';
//import MaterialTable from 'material-table'

//const columns = [
//    {
//        title: 'Longitude', field: 'long'
//    },
//    {
//        title: 'Latitude', field: 'lat'
//    },
//    {
//        title: 'Motel', field: 'motel'
//    },
//    {
//        title: 'Address', field: 'address'
//    },
//    {
//        title: 'Locality', field: 'locality'
//    },
//    {
//        title: 'Region', field: 'region'
//    },
//]

// //        {locations.map(location =>
//        //        <tr>
//        //        <td scope='row'>{location.locationId}</td>
//        //        <td>{location.longitude}</td>
//        //        <td>{location.latitude}</td>
//        //        <td>{location.name}</td>
//        //        <td>{location.address}</td>
//        //        <td>{location.locality}</td>
//        //        <td>{location.region}</td>

//export default class Table extends Component {

//    constructor(props)
//    {
//        super(props);
//        this.state = { locations: [], loading: true };
//    }

//    componentDidMount() {
//        this.populateLocData();
//    }

//    //render() {
//    //    return (<div>
//    //        <MaterialTable
//    //            data={locations.map(location =>
//    //            { location.locationId },
//    //            { location.longitude },
//    //            { location.latitude },
//    //            { location.name },
//    //            { location.address },
//    //            { location.locality },
//    //            { location.region }
//    //            )}
//    //            columns={columns}
//    //        />
//    //    </div>)
//    //}

//    async populateLocData() {
//        const response = await fetch('https://localhost:7227/api/locations');
//        const data = await response.json();
//        this.setstate({ locations: data, loading: false });
//    }

//}