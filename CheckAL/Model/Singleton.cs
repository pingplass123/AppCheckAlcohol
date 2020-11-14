using System;
using SQLite;
namespace CheckAL.Model
{
    public class Singleton
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string BAC { get; set; }
        public string typeAL { get; set; }
        public string LevelBAC { get; set; }

        public override string ToString()
        {
            return this.typeAL + "(" + BAC + " " + LevelBAC +  ")";  
        }
    }

    
}
