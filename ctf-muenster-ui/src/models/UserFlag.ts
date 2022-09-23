import { Guid } from "guid-typescript";

export default interface UserFlag {
    id: Guid;
    // User: User;
    // Flag: Flag;
    active: boolean;
    score: number;
}