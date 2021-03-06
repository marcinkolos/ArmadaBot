﻿using System;
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
        public float X { get; set; }
        public float Y { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public string Armada = "";
        public int priority = 999999999;
        public EntityType Type { get; set; }
    }
    public enum EntityType
    {
        Animal,
        Npc,
        Player,
        Glow
    };
    public class MyPlayer
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public string Shooting { get; set; }
        public bool Repairing { get; set; }
        public bool Moving { get; set; }
    }
}
