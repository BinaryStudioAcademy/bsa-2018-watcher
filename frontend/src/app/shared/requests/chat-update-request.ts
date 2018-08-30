import { NotificationSetting } from '../models/notification-setting.model';

export interface ChatUpdateRequest {
  name: string;
  usersSettings: NotificationSetting[];
}
