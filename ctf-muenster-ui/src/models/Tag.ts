import { Guid } from "guid-typescript";

export default interface Flag {
    id: Guid;
    name: string;
    description: string;
}