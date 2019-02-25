using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public abstract class Monster
    {
        public enum MonsterAction { Attack, Defend, Retreat};

        private int _id;
        private string _name;
        private int _age;
        private string _color;
        private string _weight;
        private bool _canFly;
        private bool _hasTail;
        private string _language;


        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }



        public bool HasTail
        {
            get { return _hasTail; }
            set { _hasTail = value; }
        }


        public bool CanFly
        {
            get { return _canFly; }
            set { _canFly = value; }
        }


        public string Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }


        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string Greeting()
        {
            return $"Hello, my name is {_name}";
        }

        public abstract bool IsHappy();

        public abstract bool IsHostile();

        public Monster()
        {

        }

        public Monster(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
