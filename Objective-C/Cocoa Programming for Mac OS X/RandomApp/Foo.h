//
//  Foo.h
//  RandomApp
//
//  Created by Nic Lake on 3/17/11.
//  Copyright 2011 niclake.com. All rights reserved.
//

#import <Cocoa/Cocoa.h>


@interface Foo : NSObject {
	IBOutlet NSTextField *textField;
}
- (IBAction)seed:(id)sender;
- (IBAction)generate:(id)sender;
@end
