using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string book, int chapter, int verse, string content)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();
        foreach (var word in content.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public int WordCount()
    {
        return _words.Count;
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(count, _words.Count);

        HashSet<int> hiddenIndices = new HashSet<int>();
        while (hiddenIndices.Count < wordsToHide)
        {
            int index = random.Next(_words.Count);
            if (!hiddenIndices.Contains(index))
            {
                _words[index].Hide();
                hiddenIndices.Add(index);
            }
        }
    }

    public override string ToString()
    {
        return $"{_reference}\n{string.Join(" ", _words)}";
    }

    public static List<Scripture> LoadVerses(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();

        try
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        string book = parts[0].Trim();
                        int chapter = int.Parse(parts[1].Trim());
                        int verse = int.Parse(parts[2].Trim());
                        string content = parts[3].Trim();

                        Scripture scripture = new Scripture(book, chapter, verse, content);
                        scriptures.Add(scripture);
                    }
                }
            }
            else
            {
                Console.WriteLine("Scripture file not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scripture: {ex.Message}");
        }

        return scriptures;
    }

    public static void DisplayVerses(List<Scripture> scriptures)
    {
        Console.Clear();
        foreach (var scripture in scriptures)
        {
            Console.WriteLine(scripture);
            Console.WriteLine();
        }
    }

    public static void HideWords(List<Scripture> scriptures, int count)
    {
        int totalWordCount = 0;
        foreach (var scripture in scriptures)
        {
            totalWordCount += scripture.WordCount();
        }

        if (count > totalWordCount)
        {
            Console.WriteLine($"You entered too many words. Hiding the maximum available: {totalWordCount} words.");
            count = totalWordCount;
        }

        int remainingWordsToHide = count;
        Random random = new Random();
        while (remainingWordsToHide > 0)
        {
            foreach (var scripture in scriptures)
            {
                if (remainingWordsToHide == 0)
                {
                    break;
                }
                int wordsToHide = Math.Min(remainingWordsToHide, scripture.WordCount());
                scripture.HideRandomWords(wordsToHide);
                remainingWordsToHide -= wordsToHide;
            }
        }

        Console.WriteLine("After hiding words:");
        DisplayVerses(scriptures);
    }
}
