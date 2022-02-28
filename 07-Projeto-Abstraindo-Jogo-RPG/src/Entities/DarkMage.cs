namespace Jogo_RPG.src.Entities
{
    public class DarkMage : Hero
    {
        public DarkMage(string Name, int Level, string HeroType, int HP, int MP) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack() {
            return $"Nome: {Name} lançou um raio negro!";
        }                 
        public virtual string Attack(int Bonus) {
            return $"Nome: {Name} ganhou um bonus de {Bonus} e lançou um raio negro!";
        }
    }
}