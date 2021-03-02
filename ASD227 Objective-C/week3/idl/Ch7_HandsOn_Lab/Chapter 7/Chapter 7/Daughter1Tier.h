//
//  Daughter1Tier.h
//  Chapter 7
//

#import <Foundation/Foundation.h>
#import "Parent.h"

@interface Daughter1Tier : Parent{
    
    NSString* anxiety;
    
}

@property (getter = getAnxiety, setter = setAnxiety:) NSString *anxiety;

@end
