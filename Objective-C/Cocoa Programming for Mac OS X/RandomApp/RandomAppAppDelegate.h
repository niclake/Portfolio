//
//  RandomAppAppDelegate.h
//  RandomApp
//
//  Created by Nic Lake on 3/17/11.
//  Copyright 2011 niclake.com. All rights reserved.
//

#import <Cocoa/Cocoa.h>

@interface RandomAppAppDelegate : NSObject <NSApplicationDelegate> {
    NSWindow *window;
}

@property (assign) IBOutlet NSWindow *window;

@end
