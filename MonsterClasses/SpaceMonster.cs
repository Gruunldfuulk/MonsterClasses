using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class SpaceMonster : Monster, IBattle
    {
        private string _galaxy;
        private int _numberOfEyes;
        private string _system;
        private string _homePlanet;


        public string HomePlanet
        {
            get { return _homePlanet; }
            set { _homePlanet = value; }
        }


        public string System
        {
            get { return _system; }
            set { _system = value; }
        }


        public int NumberOfEyes
        {
            get { return _numberOfEyes; }
            set { _numberOfEyes = value; }
        }


        public string Galaxy
        {
            get { return _galaxy; }
            set { _galaxy = value; }
        }


        public override bool IsHappy()
        {
            return true;
        }
        public override bool IsHostile()
        {
            return true;
        }

        public override string Greeting()
        {
            return $"Hello, my name is {Name} and I am from the {_galaxy} galaxy.";
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random randomNumber = new Random();
            int battleResponseNumber = randomNumber.Next(0, 101);

            if (battleResponseNumber >=66)
            {
                return MonsterAction.Attack;
            }
            else if (battleResponseNumber >=33)
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
