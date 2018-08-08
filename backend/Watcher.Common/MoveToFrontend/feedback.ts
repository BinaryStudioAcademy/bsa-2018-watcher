
 
    export interface Feedback { 
        id: number;
        text: string;
        createdAt: Date;
        userId: number;
        user: UserDto;
        responseId: number;
        response: Response;
    }



