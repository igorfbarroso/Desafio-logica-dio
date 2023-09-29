// Declarando as variáveis nome e contador de XP
string nome = "Flash";
string nivel = string.Empty;
int xp = 0;

// Estrutura de Decisão IF/ELSE
Console.WriteLine("Digite o nível de XP do herói: ");

xp = int.Parse(Console.ReadLine());

if(xp < 1000)
{
     nivel = "Ferro";
}
else if(xp >= 1001 && xp <= 2000)
{
     nivel = "Bronze";
}
else if(xp >= 2001 && xp <= 5000)
{
     nivel = "Prata";
}
else if(xp >= 6001 && xp <= 7000)
{
     nivel = "Ouro";
}
else if (xp >= 7001 && xp <= 8000 )
{
      nivel = "Platina";
}
else if (xp >= 8001 && xp <= 9000 )
{
      nivel = "Ascendente";
}
else if (xp >= 9001 && xp <= 10000 )
{
      nivel = "Imortal";
}
else if (xp >= 10001)
{
     nivel = "Radiante";
}
else
{
    nivel = "Nível não definido";
}

Console.WriteLine($"O herói de nome {nome} está no nível de {nivel}");