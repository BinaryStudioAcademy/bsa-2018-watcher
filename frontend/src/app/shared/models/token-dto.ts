import {UserDto} from './user-dto';

export interface TokenDto {
  user: UserDto;
  watcherJWT: string;
}
