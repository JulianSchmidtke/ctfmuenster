import { Guid } from "guid-typescript";

export default interface Flag {
    id: Guid;
    flagName: string;
    description: string;
    location: {
        latitude: number,
        longitude: number
    };
    dateTimeEndActive: Date;
    dateTimeStartActive: Date;
    tags: string[];
}