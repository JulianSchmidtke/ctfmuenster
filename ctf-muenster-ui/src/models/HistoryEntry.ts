import { Guid } from "guid-typescript";

export default interface HistoryEntry {
    userId: number, //Guid
    flagId: number, //Guid
    dateTime: Date
}