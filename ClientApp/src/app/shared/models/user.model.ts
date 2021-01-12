export interface UserModel {
    id: number;
    firstName: string;
    lastName: string;
    email: string;
    password: string;
    address: string;
    type: string;
    isDeleted: boolean;
    createTime: Date;
    updatedTime: Date;
    fidelityBonus: FidelityBonus;
}

export interface FidelityBonus {
    id: number;
    points: number;
}