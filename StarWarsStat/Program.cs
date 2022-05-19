using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Net;
using RestSharp;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

RestClient client = new RestClient("https://pokeapi.co/api/v2/");

Console.WriteLine("This is an engine where you can search up a pokemon.\n Then you will be able to see if that pokemon has a punch move");
Console.WriteLine("Do not write any numbers and write the pokemon's name in lowercase");
Console.WriteLine("Please write below which pokemon you would like to search up:");

string chari = Console.ReadLine();

// string chari = "ditto";

RestRequest request = new RestRequest($"pokemon/{chari}");

RestResponse response = await client.GetAsync(request);

string content = response.Content;

Pokemon poke = JsonConvert.DeserializeObject<Pokemon>(content);

Console.WriteLine(response.StatusCode);

string status = response.StatusCode.ToString();



if (status == "OK")
{



    Console.WriteLine($"Name: {poke.name}  id:{poke.id}");
    Console.WriteLine($"all of {chari} punch moves");

    for (int i = 0; i < poke.moves.Count; i++)
    {

        string answer = poke.moves[i].move.name;
        bool isPunch = answer.Contains("punch");

        if (isPunch == true)
        {

            Console.WriteLine(poke.moves[i].move.name);

        }
    }
}
else
{
    Console.WriteLine("please write a correct pokemon");

}

Console.ReadLine();
