using System.Collections.Generic;

namespace DogServices;

public interface ISearcher
{
    bool Search(IEnumerable<string> dogList, string dogUrl);
}
