CypherBarrel
============

Cypher Barrel is a small barrel cypher encoder and decoder

The cypher works with a key and a message.
The key is a suite of numbers between 1 and 9, the message a space separated list of lower case words.
To encrypt a message, we repeatedly travel through the numbers of the key from left to right and then from right to left and shift the letter in the alphabet by the corresponding number.

Example:
1
key 1595
message hello world

The top line is how many messages there are.
We start processing the words and using the digits from the key from left to right:

h+1=i, e+5=j, l+9=u, l+5=q

Now that we used all the digits, we do it again from right to left:

o+5=t, the space is discarded, w+9=f, o+5=t, r+1=s

And finally we repeat the process, starting from left to right:

l+1=m, d+5=i

The encrypted message is: ijuqt ftsmi

- - -

Included is a test sample for the decrypter.