using Newtonsoft.Json;

namespace DogServices;
public class DogApiJsonMapper : IDogApiMapper
{
    internal record DataDog
    {
        public string Message { get; init; }
        public string Status { get; init; }
    }

    public string DecodeApi(string apiresult) => JsonConvert.DeserializeObject<DataDog>(apiresult)?.Message;

}
