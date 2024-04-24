//Cox Automotive

Console.WriteLine("Please enter desired arguement");
string input = Console.ReadLine();
string formattedString = FormatInput(input);
Console.WriteLine($"Your formatted string is:\n{formattedString}");

string FormatInput(string input)
{
    // Declare Values
    string output = "";
    List<string> inputList = new List<string>();
    List<string> outputList = new List<string>();
    string tempWord = "";
    int uniqueCharacters = 0;
    string modifiedString = "";
        
    // Parse input and add each string into list
    foreach (char c in input)
    {
        if (Char.IsLetter(c))
        {
            tempWord = tempWord + (c.ToString());
        }
        else
        {
            inputList.Add(tempWord);
            tempWord = "";
            inputList.Add(c.ToString());
        }

        if(c == input.Last())
        {
            inputList.Add(tempWord);
            tempWord = "";
        }
    }

    // Calculate unique characters and add newly formatted strings
    foreach (string s in inputList)
    {
        if (s.Length == 1)
        {
            outputList.Add(s);
            continue;
        }
        if (s.Length == 2)
        {
            modifiedString = $"{s[0]}0{s[1]}";
            outputList.Add(modifiedString);
            modifiedString = "";
            continue;
        }
        List<char> uniqueChars = new List<char>();
        for (int i = 1; i < s.Length - 1; i++) 
        {
            if (!uniqueChars.Contains(s[i]))
            {
                uniqueCharacters++;
                uniqueChars.Add(s[i]);
            }
        }
        modifiedString= $"{s[0]}{uniqueCharacters}{s[s.Length - 1]}";
        if (modifiedString != "")
        {
            outputList.Add(modifiedString);
        }
        modifiedString = "";
        uniqueCharacters = 0;
    }

    output = String.Join("", outputList.ToArray());
    return output;
}