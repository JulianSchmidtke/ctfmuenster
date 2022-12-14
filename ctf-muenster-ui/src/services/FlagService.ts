import Flag from "../models/Flag";
import { Guid } from "guid-typescript";

export class FlagService {

    public static cleanFlag(flag: Flag) {
        flag.dateTimeEndActive = new Date(flag.dateTimeEndActive);
        flag.dateTimeStartActive = new Date(flag.dateTimeStartActive);
        return flag
    }

    public static async getFlags(): Promise<Flag[]> {
        const flagsResponse = await fetch('https://app-ctfmuenster-api2.azurewebsites.net/flag?active=true', {
            method: "GET",
            mode: "cors"
        });
        const flags = await flagsResponse.json()
        return flags.map(FlagService.cleanFlag) as Flag[]
    }

    public static async getFlag(id: Guid | string): Promise<Flag> {
        const flagsResponse = await fetch(`https://app-ctfmuenster-api2.azurewebsites.net/flag/${id}`, {
            method: "GET",
            mode: "cors"
        });
        const flag = await flagsResponse.json()
        return FlagService.cleanFlag(flag) as Flag
    }


    public static async captureFlag(flag: Flag) {
        let userId = "e59871b2-5970-4f04-b1cd-42a0796a5279"
        let body = { "id": flag.id }

        await fetch(`https://app-ctfmuenster-api2.azurewebsites.net/user/${userId}/addflag`, {
            method: "POST",
            body: JSON.stringify(body),
            headers: {
                'Content-Type': 'application/json'
            },
        })
    }
}