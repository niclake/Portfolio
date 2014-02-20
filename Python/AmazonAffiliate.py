#!/usr/bin/env python

import re
import sys
from urlparse import urlparse

## Amazon affiliate code goes here
affcode = 'niclake-20'

rawurl = '%clipboard'.strip()

## Get the base url without all of the query string shit
baseurl = rawurl.split('?')[0]

try:
    parts = urlparse(baseurl)
except Exception:
    sys.stdout.write(rawurl)
    raise SystemExit

## Make sure it's actually an Amazon URL
amazonre = re.compile('[www\.]{0,1}amazon\.')

if not amazonre.search(parts.netloc):
    # Not an amazon URL, so return whatever was passed initially
    sys.stdout.write(rawurl)
    raise SystemExit

# Format the simpler URL & append the affiliate code
goodurl = "%s://%s%s?tag=%s" % (parts.scheme,parts.netloc,parts.path,affcode)

# Write formatted URL to stdout
sys.stdout.write(goodurl)
