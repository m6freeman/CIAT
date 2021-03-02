//
//  main.m
//  Ch06_ProgEx02
//
//  Created by user168240 on 1/11/21.
//  Copyright © 2021 user168240. All rights reserved.
//

#import <Foundation/Foundation.h>

NSMutableArray* make_doctor(NSArray *list_of_students)
{
    NSMutableArray *new_list = [[NSMutableArray alloc] init];
    for (NSString *student in list_of_students)
    {
        NSString *new_doc = [@"Dr. " stringByAppendingString: student];
        [new_list addObject:new_doc];
    }
    return new_list;
}

int main(int argc, const char * argv[])
{
    @autoreleasepool
    {
        NSArray *students = [NSArray arrayWithObjects: @"John", @"Bella", @"Stephanie", @"Leonardo", @"Michelangelo", @"Tom", @"Brad", nil];
        NSLog(@"%@", make_doctor(students));
    }
    return 0;
}
