using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicComponentDemo
{
    public class ComponentMetaData
    {
        public required Type Type {get;set;}
        public required string Name { get; set; }
        public Dictionary<string, object> Parameters {get;} = [];
    }
}