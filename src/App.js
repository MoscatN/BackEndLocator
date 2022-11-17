import React, { Component } from 'react';
import { MDBTable, MDBTableHead, MDBTableBody } from 'mdb-react-ui-kit';
import { Table } from './Table'; 

function App(){

    //constructor(props)
    //{
    //    super(props);
    //    this.state = { locations: [], loading: true };
    //}

    //componentDidMount() {
    //    this.populateLocData();
    //}
    return (
        //<MDBTable hover>
        //    <MDBTableHead>
        //        <tr>
        //            <th scope='col'>ID</th>
        //            <th scope='col'>Longitude</th>
        //            <th scope='col'>Latitude</th>
        //            <th scope='col'>Motel</th>
        //            <th scope='col'>Address</th>
        //            <th scope='col'>Locality</th>
        //            <th scope='col'>Region</th>
        //        </tr>
        //    </MDBTableHead>
        //    <MDBTableBody>
        //        {locations.map(location =>
        //        <tr>
        //        <td scope='row'>{location.locationId}</td>
        //        <td>{location.longitude}</td>
        //        <td>{location.latitude}</td>
        //        <td>{location.name}</td>
        //        <td>{location.address}</td>
        //        <td>{location.locality}</td>
        //        <td>{location.region}</td>
        //            </tr>
        //        )}
        //    </MDBTableBody>
        //</MDBTable>

        <div className="App">
            <Table/>
        </div >
    );
    
     //async populateLocData(){
     //   const response = await fetch('https://localhost:7227/api/Locations');
     //   const data = await response.json();
     //    this.setState({ locations: data, loading: false });
     //    console.log(locations); 
     //}
}
export default App;