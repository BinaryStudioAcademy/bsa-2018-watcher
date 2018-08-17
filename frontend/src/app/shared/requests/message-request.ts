export interface MessageRequest {
  text: string;
  createdAt: Date;
  wasRead: boolean;
  userId: string;
  chatId: number;
}
