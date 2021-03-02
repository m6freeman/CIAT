//
//  Parent.h
//  Chapter 7
//

#import <Foundation/Foundation.h>

@interface Parent : NSObject{
    double height;
    NSString *hairType;
}

-(id)initWithParent: (double) theHeight: (NSString*) theHairType;

@property (getter = getHeight, setter = setHeight:) double height;
@property (getter = getHairType, setter = setHairType:) NSString* hairType;

@end
