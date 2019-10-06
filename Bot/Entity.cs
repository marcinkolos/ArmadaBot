using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace CSharpArmadaBot.Bot
{

    public class Entity
    {
        public string Id { get; set; }
        public string Nickname { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public string Armada = "";
        public int priority = 999999999;
        //[JsonProperty("type")]
        //[JsonConverter(typeof(StringEnumConverter))]
        public string Type { get; set; }
        //public Types Type { get; set; }
        public enum Types {
            animal,
            Npc,
            Player,
            Glow };
    }

    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }

    }
}
