var range = 250;
var counts = new int[range];
string text = "Something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine().ToUpper();
    foreach (var character in text ?? string.Empty)
    {
        counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i]);
                
        }
    }
}
//Not done yet, the math part is kinda confusing me.