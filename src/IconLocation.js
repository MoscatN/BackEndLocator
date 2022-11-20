import React from 'react'; 
import L from 'leaflet'; 

export const IconLocation = L.icon({
    iconUrl: require('./pin.png'),
    iconRetinaUrl: require('./pin.png'),
    iconAnchor: null,
    shadowUrl: null,
    shadowSize: null,
    shadowAnchor: null,
    iconSize: [35, 35],
    className: 'leaflet-venue-icon',
});

export default IconLocation; 