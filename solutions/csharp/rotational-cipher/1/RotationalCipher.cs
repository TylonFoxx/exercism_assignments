public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string plain = "abcdefghijklmnopqrstuvwxyz";
        string cipher = plain.Remove(0,shiftKey) + plain.Substring(0,shiftKey); //create cipher lookup
        //uppercase variants
        string plainUpper = plain.ToUpper();
        string cipherUpper = cipher.ToUpper();

        string output = "";

        for (int i = 0; i < text.Length; i++) //iterate each char in the text
        {
            if(!char.IsPunctuation(text[i]) && !char.IsNumber(text[i]) && text[i] != ' ') //check numbers, punctuation and spaces - those are not ROT'ed
            {
                int letterIndex = plain.IndexOf(text[i]);
                if (letterIndex != -1) //lowercase matched
                {
                    output += cipher[letterIndex]; //using the cipher lookup
                }
                else
                {
                    letterIndex = plainUpper.IndexOf(text[i]); //check uppercase arrays
                    output += cipherUpper[letterIndex];
                }
            }
            else //if number, punctuation or space.
            {
                output += text[i];
            }
        }
        return output;
    }
}