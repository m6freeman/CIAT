//
//  main.m
//  Chapter 7
//

#import <Foundation/Foundation.h>
#import "Parent.h"
#import "Son.h"
#import "Daughter1Tier.h"
#import "Daughter2Tier.h"

int main(int argc, const char * argv[])
{

    @autoreleasepool {
        
        Parent *parent = [[Parent alloc] initWithParent:20 :@"type"];
        
        Son *son = [[Son alloc] init];
        
        Daughter1Tier *daughter = [[Daughter1Tier alloc] init];
        
        Daughter2Tier *grandDaughter = [[Daughter2Tier alloc] init];
        
    }
    return 0;
}

