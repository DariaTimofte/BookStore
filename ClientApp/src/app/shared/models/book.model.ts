export interface BookModel {
    id: number;
    name: string;
    categoryId: number;
    authorId: number;
    author: string;
    category: string;
    price: number;
    poits: number;
    isDeleted: boolean;
    createTime: Date;
    updatedTime: Date;
}

export interface CategoryModel {
    id: number;
    categoryName: string;
    isDeleted: boolean;
    createTime: Date;
    updatedTime: Date;
}

export interface AuthorModel {
    id: number;
    firstName: string;
    lastName: string;
    isDeleted: boolean;
    createTime: Date;
    updatedTime: Date;
}