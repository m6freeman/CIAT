//
//  main.m
//  Ch04_ProgEx03
//
//  Created by user168240 on 1/11/21.
//  Copyright © 2021 user168240. All rights reserved.
//

#import <Foundation/Foundation.h>

void even_or_odd(int number)
{
    NSLog(@"\n%@", (number % 2 == 0) ? @"Even" : @"Odd");
}

int main(int argc, const char * argv[])
{
    @autoreleasepool
    {
        int input = 0;
        NSLog(@"\nInput numbers, and we'll tell you if they are Even or Odd.");
        NSLog(@"\nEnter 999 to exit!");
        for ( ;input != 999; )
        {
            scanf(" %i", &input);
            even_or_odd(input);
        }
    }
    return 0;
}