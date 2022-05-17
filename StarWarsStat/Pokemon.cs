using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Net;
using RestSharp;
using Newtonsoft.Json;
using System.Text.Json.Serialization;


public class Pokemon
{
    public string name { get; set; }
    public int id { get; set; }
    public bool is_default { get; set; }

    public moveWrapper[] moves { get; set; }

}

