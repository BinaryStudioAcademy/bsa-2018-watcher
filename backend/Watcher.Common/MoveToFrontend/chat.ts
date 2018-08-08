
 
    export interface Chat { 
        id: number;
        name: string;
        type: ChatType;
        createdById: number;
        createdBy: UserDto;
        organizationId: number;
        organization: Organization;
        messages: Message[];
    }



