using System.Collections.Generic;
namespace cSharp_NinjaRemoteIsland.Interfaces
{
    public interface IConsumable
    {
    string Name {get;set;}
    int HealthPoints {get;set;}
    string GetInfo();
    
    }
}