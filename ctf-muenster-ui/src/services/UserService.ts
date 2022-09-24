import User from "../models/User";
import { Guid } from "guid-typescript";
import UserFlag from "../models/UserFlag";
import UserDetail from "../models/User";


export class UserSerivce {

  public static getStdUserId(): Guid {
    return Guid.parse("e59871b2-5970-4f04-b1cd-42a0796a5279")
  }

  public static async getUserDetails(id: Guid): Promise<UserDetail> {
    const userResponse = await fetch(`https://app-ctfmuenster-api2.azurewebsites.net/Score/${id}/`)
    return await userResponse.json() as UserDetail;
  }

  public static async getUser(id: Guid): Promise<User> {
    const userResponse = await fetch(`https://app-ctfmuenster-api2.azurewebsites.net/User/${id}/`)
    return await userResponse.json() as User;
  }

  public static async getUserFlags(id:Guid): Promise<UserFlag[]> {
    const userFlagResponse = await fetch("https://app-ctfmuenster-api2.azurewebsites.net/User/" + id + "/flags")
    return await userFlagResponse.json() as UserFlag[];
  }

  public static async getUsers(): Promise<User[]> {
    const usersResponse = await fetch("https://app-ctfmuenster-api2.azurewebsites.net/User");
    return await usersResponse.json() as User[];
  }

  public static async getScores(period: number): Promise<{user: User, scoreCount: number, flagCount: number}[]> {
    const today: Date = new Date();
    let dt: Date = new Date(today);
    

    let scoreReponse: Response;
    if(period === 0){
      scoreReponse = await fetch("https://app-ctfmuenster-api2.azurewebsites.net/Score");
    } else {
      dt.setDate(dt.getDate() - (period));
      console.log(dt);
      scoreReponse = await fetch("https://app-ctfmuenster-api2.azurewebsites.net/Score?since=" + dt.toISOString().substring(0, 10));
    }
      
      return await scoreReponse.json() as {user: User, scoreCount: number, flagCount: number}[];
    }

  //public getAve
}

export const userService = new UserSerivce();