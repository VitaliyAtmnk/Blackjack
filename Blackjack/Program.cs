using Blackjack;

Player krupier = new Player("Krupier Fanda");
Player hrac = new Player("Vitalij");

bool bezi = true;

// Lízne 2 karty
krupier.Hit();
krupier.Hit();

// Lízne 2 karty
hrac.Hit();
hrac.Hit();

while (bezi)
{
 
}



void GameState()
{
    int kScore = krupier.Score;
    int hScore = hrac.Score;

    Console.WriteLine($"{krupier.Name}: {kScore}");
    Console.WriteLine($"{hrac.Name}: {hScore}");
}