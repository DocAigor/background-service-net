using System;
using System.IO;

namespace DogServices;

public class DogWriter : IWriter
{
    public void Write(string source, string line)
    {
        try
        {
            File.AppendAllText(source, $"{line}{Environment.NewLine}");
        }
        catch (IOException ex)
        {
            throw new InvalidOperationException("Unable to write to the file.", ex);
        }
    }
}
