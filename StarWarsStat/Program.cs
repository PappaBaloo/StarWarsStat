using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Net;
using RestSharp;
using Newtonsoft.Json;
using System.Text.Json.Serialization;



RestClient client = new RestClient("https://pokeapi.co/api/v2/");

RestRequest request = new RestRequest("pokemon/charizard");

RestResponse response = await client.GetAsync(request);

string content = response.Content;

Pokemon charizard = JsonConvert.DeserializeObject<Pokemon>(content);

Console.WriteLine(content);

Console.ReadLine();
