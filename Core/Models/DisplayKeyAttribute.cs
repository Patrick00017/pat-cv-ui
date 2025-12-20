using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    [AttributeUsage(AttributeTargets.Field)]
    public class DisplayKeyAttribute(string key) : Attribute
    {
        public string Key { get; } = key;
    }

    public enum MenuName
    {
        [DisplayKey("Menu.Home")]
        HOME,
        [DisplayKey("Menu.Rank")]
        RANK
    }
}
