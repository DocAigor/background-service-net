using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DogServices;
public class DataDogSearcher : IDataDogSearcher
{
    public IEnumerable<string> Retrieve(string source) =>
        File.Exists(source) ? File.ReadLines(source) : Enumerable.Empty<string>();


    public bool Search(IEnumerable<string> dogList, string dogUrl) => dogList.Contains(dogUrl);
}
