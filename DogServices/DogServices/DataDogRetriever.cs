using System.Collections.Generic;
using System.Net.Http;

namespace DogServices;
public class DataDogRetriever : IDataRetriever
{
    private readonly IDogApiMapper _dogApiMapper;
    private readonly HttpClient _httpclient;

    public DataDogRetriever(IDogApiMapper dogapimapper, HttpClient httpclient) => (_dogApiMapper, _httpclient) = (dogapimapper, httpclient);

    public IEnumerable<string> Retrieve(string source)
    {
        yield return _dogApiMapper.DecodeApi(_httpclient.GetStringAsync(source).GetAwaiter().GetResult());
    }
}