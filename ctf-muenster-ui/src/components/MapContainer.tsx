import './MapContainer.css';
import React, { useEffect, useRef } from 'react';
import L from 'leaflet';
// import { MapContainer, TileLayer, Marker, Popup, useMap } from "react-leaflet";

interface MapProps {
}

const Map: React.FC<MapProps> = ({ }) => {
  const coords = {
    lng: 51.9364501,
    lat: 7.6529127,
    zoom: 20,
  };

  var map = L.map('map').setView([coords.lng, coords.lat], coords.zoom);

  // <MapContainer center={[coords.lng, coords.lat]} zoom={coords.zoom} scrollWheelZoom={false}>
  //   <TileLayer
  //     attribution='&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
  //     url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
  //   />
  //   <Marker position={[coords.lng, coords.lat]}>
  //     <Popup>
  //       A pretty CSS3 popup. <br /> Easily customizable.
  //     </Popup>
  //   </Marker>
  // </MapContainer>

  // const MapView: any() {
  //   let map = useMap();
  //   map.setView([latitude, longitude], map.getZoom());
  //    //Sets geographical center and zoom for the view of the map
  //   return null;
  // }

  // const leafletMap = map(mapContainer.current).setView(
  //   [initialState.lat, initialState.lng],
  //   initialState.zoom
  // );

  return <div id="map"></div>
};

export default Map;
