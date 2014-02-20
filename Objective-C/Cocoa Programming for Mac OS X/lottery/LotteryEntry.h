//
//  LotteryEntry.h
//  lottery
//
//  Created by Nic Lake on 3/18/11.
//  Copyright 2011 niclake.com. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface LotteryEntry : NSObject {
	NSCalendarDate *entryDate;
	int firstNumber;
	int secondNumber;
}
- (void)prepareRandomNumbers;
- (void)setEntryDate:(NSCalendarDate *)date;
- (NSCalendarDate *)entryDate;
- (int)firstNumber;
- (int)secondNumber;
@end