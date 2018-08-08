
 
    export interface Message { 
        id: number;
        text: string;
        createdAt: Date;
        wasRead: boolean;
        userId: number;
        user: UserDto;
        chatId: number;
        chat: Chat;
    }



