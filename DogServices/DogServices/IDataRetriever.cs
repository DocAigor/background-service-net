using System.Collections.Generic;

namespace DogServices;

public interface IDataRetriever
{
    IEnumerable<string> Retrieve(string source);
}
