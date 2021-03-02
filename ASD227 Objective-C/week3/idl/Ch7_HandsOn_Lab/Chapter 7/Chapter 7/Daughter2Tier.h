//
//  Daughter2Tier.h
//  Chapter 7
//

#import <Foundation/Foundation.h>
#import "Daughter1Tier.h"

@interface Daughter2Tier : Daughter1Tier{
    
    NSString *mood;
    
}

@property(getter = getMood, setter = setMood:) NSString *mood;

@end
