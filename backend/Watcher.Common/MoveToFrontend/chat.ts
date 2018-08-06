
 
    export interface Chat { 
        id: number;
        name: string;
        type: ChatType;
        createdById: number;
        createdBy: User;
        organizationId: number;
        organization: Organization;
        messages: Message[];
    }



