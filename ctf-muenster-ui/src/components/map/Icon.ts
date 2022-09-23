import L from 'leaflet';

const Icon = new L.Icon({
    iconUrl: require('./ms_flag.png'),
    iconRetinaUrl: require('./ms_flag.png'),
    iconSize: [20, 20],
});

export { Icon }; 