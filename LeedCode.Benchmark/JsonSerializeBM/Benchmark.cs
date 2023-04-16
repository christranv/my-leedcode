using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Nodes;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LeedCode.Benchmark.JsonSerializeBM;

// [SimpleJob(RuntimeMoniker.Wasm)]
// [SimpleJob(RuntimeMoniker.Net70)]
[MemoryDiagnoser]
public class JsonSerializeBenchmark
{
    private string _json;
    private Company _data;

    public JsonSerializeBenchmark(string json, Company data)
    {
        _json = json;
        _data = data;
    }

    [GlobalSetup]
    public void Setup()
    {
        using StreamReader reader = new(@$"{AppContext.BaseDirectory}/JsonSerializeBM/sample.json");
        _json = reader.ReadToEnd();
        _data = JsonSerializer.Deserialize<Company>(_json) ?? throw new Exception();
    }

    // [Benchmark]
    // public string SystemTextJsonSerialize() => JsonSerializer.Serialize(_data);
    //
    // [Benchmark]
    // public string NewtonSoftSerialize() => JsonConvert.SerializeObject(_data);

    [Benchmark(Baseline = true)]
    public Company? SystemTextJsonDeserialize() => JsonSerializer.Deserialize<Company>(_json);
    
    [Benchmark]
    public JsonElement? SystemTextJsonJsonElementDeserialize() => JsonSerializer.Deserialize<JsonElement>(_json);
    
    [Benchmark]
    public JsonObject? SystemTextJsonJsonObjectDeserialize() => JsonSerializer.Deserialize<JsonObject>(_json);

    [Benchmark]
    public Company? NewtonSoftDeserialize() => JsonConvert.DeserializeObject<Company>(_json);

    [Benchmark]
    public ExpandoObject? NewtonSoftExpandoDeserialize() => JsonConvert.DeserializeObject<ExpandoObject>(_json);
}
