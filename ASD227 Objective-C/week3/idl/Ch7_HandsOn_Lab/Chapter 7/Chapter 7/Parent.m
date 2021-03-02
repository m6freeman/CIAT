//
//  Parent.m
//  Chapter 7
//
//

#import "Parent.h"

@implementation Parent

@synthesize height, hairType;

-(id)initWithParent: (double) theHeight: (NSString*) theHairType{
    if (self == [super init]) {
        [self setHeight:theHeight];
        [self setHairType:theHairType];
    }
    return  self;
}

-(void) setHeight: (double) newHeight{
    height = newHeight;
}

-(void) setHairType: (NSString*) newHairType{
    hairType = newHairType;
}

-(double) getHeight{
    return height;
}

-(NSString*) getHairType{
    return hairType;
}



@end
