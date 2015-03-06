import os

name = 'Nic Lake'
age = 25
height = 68 #inches
weight = 176 #lbs
eyes = 'blue'
teeth = 'white'
hair = 'brown'

os.system('clear')

print "Let's talk about %s." % name
print "He's %d inches tall." % height
print "He weighs %d pounds." % weight
print "Actually, that's not too heavy."
print "He's got %s eyes and %s hair." % (eyes, hair)
print "His teeth are usually %s depending on the coffee." % teeth
print "If I add %d, %d, and %d, I get %d." % (height, weight, age, age + height + weight)

for x in range(1,11):
	print repr(x).rjust(2), repr(x*x).rjust(3),
	#note trailing comma on previous line
	print repr(x*x*x).rjust(4)

for x in range(1,11):
	print '{0:2d} {1:3d} {2:4d}'.format(x, x*x, x*x*x)