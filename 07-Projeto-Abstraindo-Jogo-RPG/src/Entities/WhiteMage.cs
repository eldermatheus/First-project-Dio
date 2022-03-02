namespace Jogo_RPG.src.Entities
{
    public class WhiteMage : Hero
    {
        public WhiteMage(string name, int level, string heroType, int hp, int mp) {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HP = hp;
            this.MP = mp;
        }
        public override string Attack() {
            return $"Nome: {Name} lançou uma magia!";
        }         
        public virtual string Attack(int bonus) {

            if (bonus > 6) {
                return $"{Name} lançou uma magia efetiva com bonus de {bonus}!";
            }
            else 
                return $"{Name} lançou uma magia fraca com bonus de {bonus}!";
        }
    }
}