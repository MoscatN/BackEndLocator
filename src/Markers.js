import React, { useEffect, useState } from 'react';
import { Marker, Popup } from 'react-leaflet';
import { IconLocation } from './IconLocation'

export default function MarkerLoc() {
    const API = 'https://localhost:7227/api/Locations/findmotels';

    const [data, setData] = useState([])

    let pos = []
    let name = []

    const fetchLoc = () => {
        fetch(API)
            .then((res) => res.json())
            .then(res => {
                setData(res.results)
            });
    }

    useEffect(() => {
        fetchLoc()
    }, []);

    const markers = data.map((location) => (
        pos = [location.geocodes.main],
        name = [location.name],
        pos.map((loc, n) => (
            <Marker key={n} position={{ lat: loc.latitude, lng: loc.longitude }} icon={IconLocation}>
                <Popup>{ name }</Popup>
            </Marker>

            ))
    ));
    return markers;
}