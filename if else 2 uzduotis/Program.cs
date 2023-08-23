Console.WriteLine("Labas,parasyk kokia siandien diena, aciu");
string userInput  = Console.ReadLine();
int usetInputInteger  = Convert.ToInt32(userInput);
if (usetInputInteger == 1)
    Console.WriteLine("Pirmadienis");
else if (usetInputInteger == 2)
    Console.WriteLine("Antradienis");
else if (usetInputInteger == 3)
    Console.WriteLine("Treciadienis");
else if (usetInputInteger == 4)
    Console.WriteLine("Ketvertadinis");
else if (usetInputInteger == 5)
    Console.WriteLine("Penktadienis");
else if (usetInputInteger == 6)
    Console.WriteLine("Sestadienis");
else if (usetInputInteger == 7)
    Console.WriteLine("Sekmadienis");
else
    Console.WriteLine("Neteisingas dienos numeris");