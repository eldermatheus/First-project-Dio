namespace Jogo_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int hp, int mp) {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HP = hp;
            this.MP = mp;
        }
        public virtual string Attack() {
            return $"Nome: {Name} atacou com sua espada!";
        }
         public virtual string Attack(int bonus) {
            return $"Nome: {Name} ganhou um bonus de {bonus} e atacou com sua espada!";
        }
    }
}