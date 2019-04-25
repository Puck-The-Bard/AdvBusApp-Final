using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesCharacter.Models
{
    public class Player
    {
        int PlayerID {get; set;}
        string PlayerName {get; set;}
        string FlavorText {get; set;}
    }
}