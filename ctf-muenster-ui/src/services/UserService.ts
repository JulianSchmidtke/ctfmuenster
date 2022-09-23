import User from "../models/User";
import { Guid } from "guid-typescript";

export class UserSerivce {

  public getUser(id: string): User {
    return {
      id: Guid.createEmpty(),
      userName: "Testuser"
    } as User;
  }

  public createUser(name: string): User {
    return {
      id: Guid.createEmpty(),
      userName: "Testuser"
    } as User;
  }
}