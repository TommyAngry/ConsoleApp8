using System;

namespace ClassLibrary1
{
    public class Person
    {
        public virtual string Name { get; set; }
        
        public virtual int MyChip { get; set; };
        public virtual int EnemyChip { get; set; }
        protected virtual string Prefix { get; } = "F.";

    }
    public class People : Person {
        public override string Name { get; set; } = "Player";
        public override int MyChip { get; set; } = 0;  public override int EnemyChip { get; set; } = 0;
        protected override string Prefix { get; } = "S.";
    }

    public class Bot : Person {
        public override string Name { get; set; } = "Bot";
        public override int MyChip { get; set; } = 0; public override int EnemyChip { get; set; } = 0; }
}
