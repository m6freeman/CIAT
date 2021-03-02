//
//  main.m
//  Ch06_ProgEx01
//
//  Created by user168240 on 1/11/21.
//  Copyright © 2021 user168240. All rights reserved.
//

#import <Foundation/Foundation.h>

NSString* determine_major(NSString *student_id)
{
    int identifier = [[student_id substringFromIndex:[student_id length] - 2] intValue];
    NSString *major;
    switch (identifier)
    {
        case 1:
            major = @"\n01 Undecided";
            break;
        case 2:
            major = @"\n02 English";
            break;
        case 3:
            major = @"\n03 Biochemistry";
            break;
        case 54:
            major = @"\n54 Economics";
            break;
        case 77:
            major = @"\n77 Mathematics";
            break;
        case 87:
            major = @"\n87 Computer Science";
            break;
        case 98:
            major = @"\n98 Chemistry";
            break;

        default:
            break;
    }
    return major;
}

int main(int argc, const char * argv[])
{
    @autoreleasepool
    {
        NSArray *student_ids = [NSArray arrayWithObjects: @"JHGUS01", @"PHYBO02", @"GFIKH98", @"JGFTB54", @"RBWKG87", @"HGTVN77", nil];
        for (NSString *student_id in student_ids) NSLog(@"%@", determine_major(student_id));
    }
    return 0;
}
