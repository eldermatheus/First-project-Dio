namespace Jogo_RPG.src.Entities
{
    public class WhiteMage : Hero
    {
        public WhiteMage(string Name, int Level, string HeroType, int HP, int MP) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack() {
            return $"Nome: {Name} lançou uma magia!";
        }         
        public virtual string Attack(int Bonus) {

            if (Bonus > 6) {
                return $"{Name} lançou uma magia efetiva com bonus de {Bonus}!";
            }
            else 
                return $"{Name} lançou uma magia fraca com bonus de {Bonus}!";
        }
    }
}