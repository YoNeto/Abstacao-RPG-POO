using ProjetoRPG_POO.src.Entities;

Knight guerreiro = new Knight("Arus", 42);
WhiteWizzard magoBranco = new WhiteWizzard("Jessie", 42);
Ninja ninja = new Ninja("Melby", 42);
BlackWizzard magoPreto = new BlackWizzard("Jorge", 42);

System.Console.WriteLine(guerreiro);
System.Console.WriteLine(guerreiro.Attack());
System.Console.WriteLine(magoBranco);
System.Console.WriteLine(magoBranco.Attack(32));
System.Console.WriteLine(ninja);
System.Console.WriteLine(ninja.Attack(true));
System.Console.WriteLine(magoPreto);
System.Console.WriteLine(magoPreto.Attack(70));