using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMon
{
    public class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        

        public List<Monster> OwnedMonsters = new List<Monster>();
       
        
        public Player clonePlayer()
        {
            Player playerClone = new Player();
            playerClone.Name = this.Name;
            playerClone.Money = this.Money;
            foreach (Monster monster in OwnedMonsters)
            {
                Monster clonedMonster = monster.clone();
                playerClone.OwnedMonsters.Add(clonedMonster);
            }
            return playerClone;
        }
    }
}
