async handler
```ts
import { Request, Response, NextFunction } from 'express';

export const asyncHandler = (requestHandler: (req: Request, res: Response, next: NextFunction) => Promise<any>) => {
    return (req: Request, res: Response, next: NextFunction) => {
        Promise.resolve(requestHandler(req, res, next)).catch(error => next(error));
    };
};
```

api error
```ts
export class ApiError extends Error {
    statusCode: number;
    data: any;
    success: boolean;
    errors: string[];

    constructor(
        statusCode: number,
        message = "Something bad happened",
        errors: string[] = [],
        stack = ""
    ) {
        super(message);
        this.statusCode = statusCode;
        this.data = null;
        this.message = message;
        this.success = false;
        this.errors = errors;

        if (stack) {
            this.stack = stack;
        } else {
            Error.captureStackTrace(this, this.constructor);
        }
    }
}
```

api response
```ts
export class ApiError extends Error {
    statusCode: number;
    data: any;
    success: boolean;
    errors: string[];

    constructor(
        statusCode: number,
        message = "Something bad happened",
        errors: string[] = [],
        stack = ""
    ) {
        super(message);
        this.statusCode = statusCode;
        this.data = null;
        this.message = message;
        this.success = false;
        this.errors = errors;

        if (stack) {
            this.stack = stack;
        } else {
            Error.captureStackTrace(this, this.constructor);
        }
    }
}
```
