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
        public Hero(string Name, int Level, string HeroType, int HP, int MP) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public virtual string Attack() {
            return $"Nome: {Name} atacou!";
        }
        public virtual string Attack(int Bonus) {
            return $"Nome: {Name} ganhou um bonus e atacou!";
        }

        public override string ToString() {
            return $"Nome: {Name}, Level: {Level}, HeroType: {HeroType}";
        }
    }
}