using Jogo_RPG.src.Entities;

Knight arus = new Knight("Arus", 12, "Knight",100,20);
WhiteMage wizard = new WhiteMage("Jennica", 12, "White Mage",70,90);

Console.WriteLine(wizard.Attack());
Console.WriteLine(wizard.Attack(5));
Console.WriteLine(wizard.Attack(10));