
 
    export interface Response { 
        id: number;
        text: string;
        createdAt: Date;
        userId: number;
        user: UserDto;
        feedbackId: number;
        feedback: Feedback;
    }



