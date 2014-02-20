# from sys import argv
# 
# script, filename = argv

print "Enter the name of the file you wish to erase:"
filename = raw_input("> ")

print "Opening the file..."
file_display = open(filename)

print "\nHere are the current contents of %r:\n" % filename
print file_display.read()

print "\nWe're going to erase %r." % filename
print "If you don't want that, hit CTRL-C (^C)."
print "If you DO want that, hit RETURN."

raw_input("?")

# print "Opening the file..."
target = open(filename, 'w')

print "Truncating the file. Goodbye!"
target.truncate()

print "Now I'm going to ask you for three lines."

line1 = raw_input("line 1: ")
line2 = raw_input("line 2: ")
line3 = raw_input("line 3: ")

print "I'm going to write these to the file."
target.write(line1 + "\n" + line2 + "\n" + line3 + "\n")

print "And finally, we close it."
target.close()