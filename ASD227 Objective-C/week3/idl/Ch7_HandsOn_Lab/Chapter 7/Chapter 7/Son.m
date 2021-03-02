//
//  Son.m
//  Chapter 7
//

#import "Son.h"

@implementation Son

@synthesize baldness;

-(NSString*)getBaldness{
    return baldness;
}

-(void)setBaldness:(NSString *)newBaldness{
    baldness = newBaldness;
}

@end
