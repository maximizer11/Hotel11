﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1
{
    public class Client : ModelAbstract
    {
        public Client()
        {

        }

        [JsonProperty("IdClient")]
        public override int Id { get; set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string MiddleName { get; set; } 
        public string SeriaPass { get; set; } 
        public string NumberPass { get; set; } 
        public string Phone { get; set; } 
        public DateTime DateBirthClient { get; set; }
        public string Email { get; set; } 

        [JsonIgnore]
        public override string Path { get; set; } = "Clients";
    }
}
