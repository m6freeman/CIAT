//
//  main.m
//  HandsOnLab
//
//  Created by user168240 on 1/6/21.
//  Copyright © 2021 user168240. All rights reserved.
//

#import <Foundation/Foundation.h>
int main (int argc, const char * argv[])
{
    @autoreleasepool
    {
        int account;
        char operation;
        double balance = 0.0, deposit, withdraw;
        NSLog(@"\nWelcome to Navy Federal Credit Union\nPlease enter your Account number");
        scanf("%i", &account);
        switch (account)
        {
            case 785415:
                balance = 200.00;
                NSLog(@"\nYour staring balance is %.2f", balance);
                NSLog(@"\nWhat would you like to do today? Enter D for Deposit, W for Withdrawal");
                scanf("%s", &operation);
                if (operation == 'D' || operation == 'd')
                {
                    NSLog(@"Enter the amount to deposit");
                    scanf("%lf", &deposit);
                    balance += deposit;
                    NSLog(@"You deposited %.2f. Your account balance is now %.2f", deposit, balance);
                }
                else if(operation == 'W' || operation == 'w')
                {
                    NSLog(@"Enter the amount to withdraw");
                    scanf("%lf", &withdraw);
                    switch (balance < withdraw && balance >= 0.0 ? 'f' : 's')
                    {
                        case 'f':
                            NSLog(@"You cannot withdraw %.2f because you only have %.2f inYour account", withdraw, balance);
                            NSLog(@"Your account balance is %.2f", balance);
                            break;
                        case 's':
                            balance -= withdraw;
                            NSLog(@"You have withdrawn %.2f\n Your account balance is now %.2f", withdraw, balance);
                        default:
                            break;
                    }
                }
                break;
            case 348721:
            {
                balance = 480.00;
                NSLog(@"\nYour staring balance is %.2f", balance);
                NSLog(@"\nWhat would you like to do today? Enter D for Deposit, W for Withdrawal");
                scanf("%s", &operation);
                NSLog(@"The value of operation is %c", operation);
                if (operation == 'D' || operation == 'd') {
                    NSLog(@"Enter the amount to deposit");
                    scanf("%lf", &deposit);
                    balance += deposit;
                    NSLog(@"You deposited %.2f. Your account balance is now %.2f", deposit, balance);
                }
                else if(operation == 'W' || operation == 'w'){
                    NSLog(@"Enter the amount to withdraw");
                    scanf("%lf", &withdraw);
                    switch (balance < withdraw && balance >= 0.0 ? 'f' : 's')
                    {
                        case 'f':
                            NSLog(@"You cannot withdraw %.2f because you only have %.2f in your account", withdraw, balance);
                            NSLog(@"Your account balance is %.2f", balance);
                            break;
                        case 's':
                            balance -= withdraw;
                            NSLog(@"You have withdrawn %.2f\n Your account balance is now %.2f", withdraw, balance);
                        default:
                            break;
                    }
                }
            }
                break;
            case 896531:
                balance = 500.00;
                NSLog(@"\nYour staring balance is %.2f", balance);
                NSLog(@"\nWhat would you like to do today? Enter D for Deposit, W for Withdrawal");
                scanf("%s", &operation);
                if (operation == 'D' || operation == 'd')
                {
                    NSLog(@"Enter the amount to deposit");
                    scanf("%lf", &deposit);
                    balance += deposit;
                    NSLog(@"You deposited %.2f. Your account balance is now %.2f", deposit, balance);
                }
                else if(operation == 'W' || operation == 'w')
                {
                    NSLog(@"Enter the amount to withdraw");
                    scanf("%lf", &withdraw);
                    switch (balance < withdraw && balance >= 0.0 ? 'f' : 's')
                    {
                        case 'f':
                            NSLog(@"You cannot withdraw %.2f because you only have %.2f  in your account", withdraw, balance);
                            NSLog(@"Your account balance is %.2f", balance);
                            break;
                        case 's':
                            balance -= withdraw;
                            NSLog(@"You have withdrawn %.2f\n Your account balance is now %.2f", withdraw, balance);
                        default:
                            break;
                    }
                }
                break;
            case 453927:
            {
                balance = 1000.00;
                NSLog(@"\nYour staring balance is %.2f", balance);
                NSLog(@"\nWhat would you like to do today? Enter D for Deposit, W for Withdrawal\n");
                scanf("%s", &operation);
                if (operation == 'D' || operation == 'd')
                {
                    NSLog(@"Enter the amount to deposit");
                    scanf("%lf", &deposit);
                    balance += deposit;
                    NSLog(@"You deposited %.2f. Your account balance is now %.2f", deposit, balance);
                }
                else if(operation == 'W' || operation == 'w')
                {
                    NSLog(@"Enter the amount to withdraw");
                    scanf("%lf", &withdraw);
                    switch (balance < withdraw && balance >= 0.0 ? 'f' : 's')
                    {
                        case 'f':
                            NSLog(@"You cannot withdraw %.2f because you only have %.2f in your account", withdraw, balance);
                            NSLog(@"Your account balance is %.2f", balance);
                            break;
                        case 's':
                            balance -= withdraw;
                            NSLog(@"You have withdrawn %.2f\n Your account balance is now %.2f", withdraw, balance);
                        default:
                            break;
                    }
                }
            }
                break;
            default:
                NSLog(@"Invalid account number");
                break;
        }
    }
    return 0;
}
