import { Guid } from "guid-typescript";

export default interface Tag {
    id: Guid;
    name: string;
    description: string;
}