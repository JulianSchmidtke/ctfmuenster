import { Guid } from "guid-typescript";

export default interface Flag {
    id: Guid;
    flagName: string;
    description: string;
    location: Location;
    dateTimeEndActive: Date;
}

export default interface Location {
    latitude: number,
    longitude: number
}