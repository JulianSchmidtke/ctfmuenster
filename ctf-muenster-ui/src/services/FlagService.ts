import Flag from "../models/Flag";
import { Guid } from "guid-typescript";

export class FlagService {
    public static async getFlags(): Promise<Flag[]> {
        const flagsResponse = await fetch('https://app-ctfmuenster-api2.azurewebsites.net/flag', {
            method: "GET",
            mode: "cors"
        });
        const flags = await flagsResponse.json()
        return flags
    }

    public static async getFlag(id: Guid | string): Promise<Flag> {
        const flagsResponse = await fetch(`https://app-ctfmuenster-api2.azurewebsites.net/flag/${id}`, {
            method: "GET",
            mode: "cors"
        });
        const flags = await flagsResponse.json()
        return flags
    }
}