namespace Jogo_RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }        
        public Hero() {            
        }
        public Hero(string name, int level, string heroType, int hp, int mp) {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HP = hp;
            this.MP = mp;
        }
        public virtual string Attack() {
            return $"Nome: {Name} atacou!";
        }
        public virtual string Attack(int bonus) {
            return $"Nome: {Name} ganhou um bonus e atacou!";
        }

        public override string ToString() {
            return $"Nome: {Name}, Level: {Level}, HeroType: {HeroType}";
        }
    }
}