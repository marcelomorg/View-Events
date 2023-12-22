import { Lot } from "./lot";
import { SocialNetwork } from "./social-network";
import { Speaker } from "./speaker";

export interface Event {
    id:number;
    local:string;
    eventDate: Date;
    theme: string;
    peopleAmount: number;
    imgUrl: string;
    eventSpeakers: Speaker[];
    socialNetworks: SocialNetwork[];
    lots: Lot[];
}
