namespace Jogo_RPG.src.Entities
{
    public class DarkMage : Hero
    {
        public DarkMage(string name, int level, string heroType, int hp, int mp) {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HP = hp;
            this.MP = mp;
        }
        public override string Attack() {
            return $"Nome: {Name} lançou um raio negro!";
        }                 
        public virtual string Attack(int bonus) {
            return $"Nome: {Name} ganhou um bonus de {bonus} e lançou um raio negro!";
        }
    }
}