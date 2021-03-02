//
//  Son.h
//  Chapter 7
//


#import <Foundation/Foundation.h>
#import "Parent.h"

@interface Son : Parent
{
    NSString* baldness;
}

@property (getter = getBaldness, setter = setBaldness:) NSString *baldness;

@end
