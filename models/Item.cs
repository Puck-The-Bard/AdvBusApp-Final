using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Player.Models
{
    public class Item
    {
        public int ItemID {get; set;}
        public string ItemFlvrTxt {get; set;} //item descritpion
        public string ItemAbil {get; set;} //item effects and abilities

        public ICollection<Char2Item> Characters { get; set; }

    }
}