import { ChatType } from '../enums/chatType';
import { User } from './user';
import { Organization } from './organization';
import { Message } from './message';

export class Chat {
  constructor(
    public id: number,
    public name: string,
    public type: ChatType,
    public createdById: number,
    public createdBy: User,
    public organizationId: number,
    public organization: Organization,
    public messages: Message[]) {
  }
}






















