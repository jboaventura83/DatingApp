export interface INgxGalleryAction {
    icon: string;
    disabled?: boolean;
    titleText?: string;
    onClick: (event: Event) => void;
}
export declare class NgxGalleryAction implements INgxGalleryAction {
    icon: string;
    disabled?: boolean;
    titleText?: string;
    onClick: (event: Event) => void;
    constructor(action: INgxGalleryAction);
}
