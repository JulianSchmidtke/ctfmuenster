import L from 'leaflet';

const Icon = new L.Icon({
    iconUrl: require('https://upload.wikimedia.org/wikipedia/de/e/eb/M%C3%BCnster_Flagge.svg'),
    iconRetinaUrl: require('https://upload.wikimedia.org/wikipedia/de/e/eb/M%C3%BCnster_Flagge.svg'),
    popupAnchor:  [-0, -0],
    iconSize: [32,45],  
});

export { Icon }; 