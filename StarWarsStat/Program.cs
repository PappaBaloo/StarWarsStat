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

Console.WriteLine(response.StatusCode);

Console.WriteLine($"Name: {charizard.name}  id:{charizard.id}");
Console.WriteLine("all of charizards moves");

for (int i = 0; i < charizard.moves.Count; i++)
{

    Console.WriteLine(charizard.moves[i].move.name);

    // string answer = Console.ReadLine();
    // bool isPunch = answer.Contains("punch");

    // if (isPunch == true)
    // {

    //     Console.WriteLine(charizard.moves[i].move.name);

    // }
}

Console.ReadLine();
