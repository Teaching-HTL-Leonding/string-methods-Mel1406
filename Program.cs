#region var
string char1;
string char2;
string input;
#endregion

#region program
do
{
    Console.Write("Please enter your first character: ");
    char1 = Console.ReadLine()!;
} while (char1.Length != 1);
do
{
    Console.Write("Please enter your second character: ");
    char2 = Console.ReadLine()!;
} while (char2.Length != 1);

do
{
    Console.Write("Please enter your string: ");
    input = Console.ReadLine()!;
    if (Trim(input, ' ') == "") { break; }
    Console.WriteLine($"{input} contains {char1} is: {Contains(input, char.Parse(char1))}");
    Console.WriteLine($"The first index of {char1} in {input} is: {IndexOf(input, char.Parse(char1))}");
    Console.WriteLine($"The last index of {char1} in {input} is: {LastIndexOf(input, char.Parse(char1))}");
    Console.WriteLine($"Trim all {char2} from the start of {input}: {TrimStart(input, char.Parse(char2))}");
    Console.WriteLine($"Trim all {char2} from the end of {input}: {TrimEnd(input, char.Parse(char2))}");
    Console.WriteLine($"Trim all {char2} from {input}: {Trim(input, char.Parse(char2))}");
    Console.Write("Which index do you want for the substring and the remove method? ");
    int index = int.Parse(Console.ReadLine()!);
    Console.Write("Which length do you want for the substring and the remove method? ");
    int length = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"The substring of {input} with index {index} and length {length}: {Substring(input, index, length)}");
    Console.WriteLine($"The output of {input} if you remove all characters from index {index} with a length of {length}: {Remove(input, index, length)}");
} while (true);
#endregion

bool Contains(string input, char character)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (character == input[i]) return true;
    }
    return false;
}
int IndexOf(string input, char character)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (character == input[i]) return i;
    }
    return -1;
}
int LastIndexOf(string input, char character)
{
    for (int i = input.Length - 1; i >= 0; i--)
    {
        if (character == input[i]) return i;
    }
    return -1;
}
string TrimStart(string input, char character)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != character) return input[i..];
    }
    return input;
}
string TrimEnd(string input, char character)
{
    for (int i = input.Length - 1; i >= 0; i--)
    {
        if (input[i] != character) return input[..(i + 1)];
    }
    return input;
}
string Trim(string input, char character)
{
    int i = 0;
    for (; i < input.Length; i++)
    {
        if (input[i] != character) { break; }
    }
    input = input[i..];
    for (i = input.Length - 1; i >= 0; i--)
    {
        if (input[i] != character) { break; }
    }
    return input[..(i + 1)];
}
string Substring(string input, int index, int length)
{
    string output = "";
    if (length > input.Length - index) length = input.Length - index;
    for (int i = 0; i < length; i++, index++)
    {
        output += input[index];
    }
    return output;
}
string Remove(string input, int index, int length)
{
    string output = input[..index];
    if (length > input.Length - index) length = input.Length - index;
    output += input[(index + length)..];
    return output;
}