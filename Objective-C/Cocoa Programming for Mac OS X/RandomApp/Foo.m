//
//  Foo.m
//  RandomApp
//
//  Created by Nic Lake on 3/17/11.
//  Copyright 2011 niclake.com. All rights reserved.
//

#import "Foo.h"


@implementation Foo

- (void)awakeFromNib {
	NSCalendarDate *now;
	now = [NSCalendarDate calendarDate];
	[textField setObjectValue:now];
}

- (IBAction)generate:(id)sender
{
	// Generate a number between 1 and 100 inclusive
	int generated;
	generated = (random() % 100) + 1;
	
	NSLog(@"generated = %d", generated);
	
	// Ask the text field to change what it's displaying
	[textField setIntValue:generated];
}

- (IBAction)seed:(id)sender
{
	// Seed the random number generator w/ the time
	srandom(time(NULL));
	[textField setStringValue:@"Generator seeded"];
}

@end
