import { Guid } from "guid-typescript";
import Flag from "./Flag";

export default interface UserFlag {
    id: Guid;
    active: boolean;
    score: number;
    dateTimeCollected: Date
}