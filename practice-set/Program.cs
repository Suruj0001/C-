/*
    This program converts a string to an array of chars, then reversing it.
    Also it counts how many times the letter `s` appears in the string, using
    the variable `x` as a counter. Then printing the results to the console.
*/

string originalMessage = "Hello There Myself Suruj Kalita , this  a message from play i like code do you , hope you find the repo usefull";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int count = 0;
foreach (char letter in message) { if (letter == 's') { count++; } }

string reversedMessage = new String(message);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'s' appears {count} times.");
