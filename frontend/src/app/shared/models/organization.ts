import { Theme } from './theme';
import { Chat } from './chat';
import { UserOrganization } from './userOrganization';
import { Instance } from './instance';
import { Notification } from './notification';

export class Organization {
  constructor(
    public id: number,
    public name: string,
    public themeId: number,
    public theme: Theme,
    public chat: Chat,
    public userOrganizations: UserOrganization[],
    public instances: Instance[],
    public notifications: Notification[]) {
  }
}
