//
//  main.m
//  Ch04_ProgEx01
//
//  Created by user168240 on 1/11/21.
//  Copyright © 2021 user168240. All rights reserved.
//

#import <Foundation/Foundation.h>

float get_celsius_from_fahrenheit(float fahrenheit)
{
    return (fahrenheit - 32) * (5.0f/9.0f);
}

int main(int argc, const char * argv[])
{
    @autoreleasepool
    {
        float input;
        NSLog(@"\nPlease enter a temperature in Fahrenheit. (-999 to exit)");
        while (scanf(" %f", &input))
        {
            if (input == -999) break;
            NSLog(@"\n%.2f", get_celsius_from_fahrenheit(input));
            NSLog(@"\nPlease enter a temperature in Fahrenheit. (-999 to exit)");
        }
    }
    return 0;
}
