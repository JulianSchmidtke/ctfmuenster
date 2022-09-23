import { Guid } from "guid-typescript";

export default interface User{
    id: Guid;
    userName: string;
}

export default interface UserDetail {
    user: User;
    scoreCount: number;
    flagCount: number;
}