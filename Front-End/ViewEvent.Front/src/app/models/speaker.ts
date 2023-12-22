import { SocialNetwork } from "./social-network";
import { Event } from "./event";

export interface Speaker {
    id: number;
    name: string;
    summary: string;
    imgUrl: string;
    phoneNumber: string;
    email: string;
    socialNetworks: SocialNetwork[];
    eventSpeakers: Event[];
}
