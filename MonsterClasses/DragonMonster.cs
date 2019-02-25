using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class DragonMonster : Monster, IBattle
    {
 
        //public enum DragonCivilAlignment {Lawful, Neutral, Chaotic};

        
        private bool _hasTreasure;
        private string _dragonMoralAlignment;
        private string _dragonCivilAlignment;
        private string _breathElement;


        public string BreathElement
        {
            get { return _breathElement; }
            set { _breathElement = value; }
        }


        public string DragonCivilAlignment
        {
            get { return _dragonCivilAlignment; }
            set { _dragonCivilAlignment = value; }
        }

        public string DragonMoralAlignment
        {
            get { return _dragonMoralAlignment; }
            set { _dragonMoralAlignment = value; }
        }

        public bool HasTreasure
        {
            get { return _hasTreasure; }
            set { _hasTreasure = value; }
        }

 


        public override bool IsHostile()
        {
            return _hasTreasure ? false : true;
        }

        public override bool IsHappy()
        {
            return _hasTreasure ? true : false;
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();
            int battleResponseNumber = randomNumber.Next(0, 101);

            if (HasTreasure == false)
            {
                return MonsterAction.Attack;
            }
            else if (battleResponseNumber >= 33)
            {
                return MonsterAction.Defend;
            }
            else
            {
                return MonsterAction.Retreat;
            }
        }
    }
}
