//int lettre = Convert.ToInt32('a');



string ChiffrerCesar(char cle, string mot)
{
    char[] motCodeTable = new char[mot.Length];

    int cle2 = cle - 97;

    for (int i = 0; i < motCodeTable.Length; i++)
    {
        if (mot[i] != ' ')
        {
            if ((mot[i] + cle2) > 122) motCodeTable[i] = Convert.ToChar(96 + cle2 - (122 - mot[i]));
            else motCodeTable[i] = Convert.ToChar(mot[i] + cle2);
        }
        else motCodeTable[i] = ' ';
    }

    return String.Join(null, motCodeTable);
}

string DechiffrerCesar(char cle, string mot)
{
    char[] motCodeTable = new char[mot.Length];

    int cle2 = cle - 97;

    for (int i = 0; i < motCodeTable.Length; i++)
    {
        if (mot[i] != ' ')
        {
            if ((mot[i] - cle2) < 97) motCodeTable[i] = Convert.ToChar(122 - cle2 + (mot[i] - 96));
            else motCodeTable[i] = Convert.ToChar(mot[i] - cle2);
        }
        else motCodeTable[i] = ' ';
    }

    return String.Join(null, motCodeTable);
}



Console.Write("Clé (lettre entre a et z):");
char cle = Convert.ToChar(Console.ReadLine()!);

Console.Write("Mot à coder:");
string mot = Console.ReadLine()!;

Console.WriteLine(ChiffrerCesar(cle, mot));

Console.WriteLine(DechiffrerCesar(cle, ChiffrerCesar(cle, mot)));