import React, { Component, useEffect, useState } from 'react'
import { MapContainer, Marker, TileLayer } from 'react-leaflet'
import Markers from './Markers'

const API = 'https://localhost:7227/api/Locations/findmotels';

const MapView = () => {

    return (
    <MapContainer center={{ lat: '18.467', lng: '-69.950' }} zoom={13} >
        <TileLayer
            attribution='&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
            url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
            />
            <Markers/>
    </MapContainer>
    )
}

export default MapView