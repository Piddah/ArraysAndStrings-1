
namespace ArraysAndStrings1;

public class TextToParagraphs
{

    public static string CreateParagraphs(string text, int width)
    {
        return AddLineBreaks(text, width, TextToArrayOfSentences(text));
    }

    public static string AddLineBreaks(string text, int width, string[] arrayForLinebreaks)
    {
        string[] sentences = TextToArrayOfSentences(text);
        string updatedString = "";
        int currentLength = 0;

        for (int i = 0; i < sentences.Length; i++)
        {
            if (currentLength + sentences[i].Length <= width)
            {
                updatedString += sentences[i];
                currentLength += sentences[i].Length + 1;
            }
            else
            {
                updatedString += "\n";
                currentLength = 0;
            }
        }
        return updatedString;
    }

    public static string[] TextToArrayOfSentences(string text)
    {
        string[] arrayOfSentences = text.Split('.', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < arrayOfSentences.Length; i++)
        {
            arrayOfSentences[i] = arrayOfSentences[i].Trim() + ". ";
        }
        return arrayOfSentences;
    }

}
