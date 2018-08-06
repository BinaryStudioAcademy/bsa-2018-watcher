
 
    export interface Message { 
        id: number;
        text: string;
        createdAt: Date;
        wasRead: boolean;
        userId: number;
        user: User;
        chatId: number;
        chat: Chat;
    }



