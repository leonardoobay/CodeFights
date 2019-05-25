bool checkPalindrome(string inputString) {
 int length = inputString.Length;
for (int x = 0; x < length / 2; x++)
{
    if (inputString[x] != inputString[length - x - 1])
        return false;
}
return true;

}
