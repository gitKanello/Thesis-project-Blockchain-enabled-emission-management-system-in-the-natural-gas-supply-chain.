using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Collections.Generic;
/// <summary>
/// Summary description for Class1
/// </summary>
public class IO
{
    public string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EmissionsBlocks"); //EmissionsBlocks
    
    public BlockChain Load()
    {
        Console.WriteLine(FilePath);
        BlockChain Chain = new BlockChain(true);
        string[] fileNames = Directory.GetFiles(FilePath);
        foreach (string fileName in fileNames)
        {
            dynamic jsonObject = null;
            using (StreamReader sr = new StreamReader(Path.Combine(FilePath, fileName)))
            {
                string json;
                while ((json = sr.ReadLine()) != null)
                {
                    List<Emissions> emissions = new List<Emissions>();
                    jsonObject = JsonConvert.DeserializeObject(json);
       
                    foreach (JToken x in jsonObject.Transactions)
                    {
                        string[] propertyNames = GetPropertyNames(x);
                        Chain.CreateTransaction(JsonConvert.DeserializeObject<Emissions>(x.ToString()));
                    }
                }
            }
            Chain.LoadPendingTransactions(int.Parse(jsonObject.Index.ToString()), DateTime.Parse(jsonObject.TimeStamp.ToString()), jsonObject.PreviousHash.ToString(), jsonObject.Hash.ToString(), int.Parse(jsonObject.Nonce.ToString()) , "me");
        }
        return Chain;
    }
    
    public void Save(Block block)
    {
        string fileName = "block_" + block.Index.ToString() + "_" + block.TimeStamp.ToString("yyyyMMddHHmmss") + ".json";
        Console.WriteLine(FilePath);
        
        using (StreamWriter sw = new StreamWriter(Path.Combine(FilePath, fileName)))
        {
            string json = JsonConvert.SerializeObject(block);
            sw.WriteLine(json);
        }
        
    }

    public static bool TryDeserialize<T>(string json, out T result)
    {
        try
        {
            result = JsonConvert.DeserializeObject<T>(json);
            return true;
        }
        catch
        {
            result = default;
            return false;
        }
    }
    private static string[] GetPropertyNames(JToken token)
    {
        switch (token.Type)
        {
            case JTokenType.Object:
                return token.Children<JProperty>()
                    .Select(prop => prop.Name)
                    .ToArray();
            case JTokenType.Array:
                return token.Children()
                    .SelectMany(child => GetPropertyNames(child))
                    .ToArray();
            default:
                return new string[0];
        }
    }
}
