//
//  main.m
//  Ch02_Ex09
//
//  Created by user168240 on 1/7/21.
//  Copyright © 2021 user168240. All rights reserved.
//

#import <Foundation/Foundation.h>

int main(int argc, const char * argv[])
{
    @autoreleasepool
    {
        int GMT_Time = 10;
        int CST_Time = 10;
        int *state1 = &CST_Time;
        CST_Time += 5;

        // CORRECTED FORMAT SPECIFIERS TO MATCH VARIABLE VALUE DATATYPE
        // CORRECTED LAST VARIABLE PASSED AS ARGUMENT TO NSLog() TO SHOW VALUE, NOT MEMORY ADDRESS
        NSLog(@"\nWhen the GMT time is %i o'clock, \nthen it is %i o'clock in Minnesota.", GMT_Time, *state1);
    }
    return 0;
}
