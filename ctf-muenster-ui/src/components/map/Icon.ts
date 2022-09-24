import L from 'leaflet';

const MsFlagIcon = new L.Icon({
    iconUrl: require('./ms_flag.png'),
    iconRetinaUrl: require('./ms_flag.png'),
    iconSize: [20, 20],
});

const CircleIcon = new L.Icon({
    iconUrl: require('./circle.png'),
    iconRetinaUrl: require('./circle.png'),
    iconSize: [20, 20],
});

export { MsFlagIcon, CircleIcon }; 