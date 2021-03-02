//
//  main.m
//  Week1_Discussion
//
//  Created by user168240 on 1/7/21.
//  Copyright © 2021 user168240. All rights reserved.
//

#import <Foundation/Foundation.h>

int main(int argc, const char * argv[])
{
    @autoreleasepool
    {
        int x = 1;
        int y = 2;
        int z = 3;

        // What is a relational operator?
        // A relational operator takes two operands and compares them, returning a TRUE or FALSE value. Below, we'll compare x to y. Is x less than y? It is, so the relational operator will return TRUE, allowing us to enter the IF block.
        if (x < y)
        {
            // Why is the if-else statement used?
            // if-else statements allow us to control the logical structure of our code. If x wasn't less than y, this block would have been skipped over. IF statements allow us to use relational and logical operators to control how our code flows.
            if (x != z)
            {
                // When are nested if statements used?
                // Nested If statements are used if another comparison needs to be made only after a sperate condition has been evaluated TRUE.
            }
        }

        // What is the use for the logical operators?
        // Logical operators include AND, OR, XOR, and NOT. These allow us to chain or invert relational operations to create more complex conditions for code execution.
        if (x < y && y < z)
        {
            // What does this operator “&&” stand for?
            // The AND (&&) logical operator states that both conditions must be true for the expression to be true. This block will execute because X is less than Y AND Y is less than Z.
        }

        if (x > y || y < z)
        {
            // What does this operator “||” stand for?
            // The OR (||) logical operator states that at least one of the conditions must be true for the expression to be true. This block will execute because even though X is not greater than Y, Y is less than Z.
        }

    }
    return 0;
}
