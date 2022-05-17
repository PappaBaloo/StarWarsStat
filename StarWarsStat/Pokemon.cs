using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Net;
using RestSharp;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


public class Pokemon
{
    public string name = "";

    // [JsonPropertyName("Name")]
    // public List<string> Name { get; set; }

    // [JsonPropertyName("Species")]
    // public List<string> Species { get; set; }
}