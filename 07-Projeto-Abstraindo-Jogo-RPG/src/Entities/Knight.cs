namespace Jogo_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public virtual string Attack() {
            return $"Nome: {Name} atacou com sua espada!";
        }
         public virtual string Attack(int Bonus) {
            return $"Nome: {Name} ganhou um bonus de {Bonus} e atacou com sua espada!";
        }
    }
}