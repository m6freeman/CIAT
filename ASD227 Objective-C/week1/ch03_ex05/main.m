//
//  main.m
//  Ch03_Ex05
//
//  Created by user168240 on 1/7/21.
//  Copyright © 2021 user168240. All rights reserved.
//

#import <Foundation/Foundation.h>

int main()
{
    @autoreleasepool
    {
        char user_gender;
        NSLog(@"\nPlease enter your gender [M/F]");
        scanf(" %c", &user_gender);
        if (user_gender == 'm' || user_gender == 'M')
        {
            NSLog(@"\nBOY");
        }
        else if (user_gender == 'f' || user_gender == 'F')
        {
            NSLog(@"\nGIRL");
        }
        else
        {
            main();
        }
    }
    return 0;
}
