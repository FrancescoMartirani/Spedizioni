using Spedizioni;

Pacco pacco1 = new Pacco(10,20,30,"Francesco","Andrea",213);
Pacco pacco2 = new Pacco(12, 21, 31, "Fabio", "Luca", 214);
Pacco pacco3 = new Pacco(14, 26, 35, "Lucia", "Sara", 215);
Plico plico1 = new Plico(24, 32, "Maria", "Giuseppe", 216);
Plico plico2 = new Plico(12, 21, "Luigi", "Giuseppe", 216);
Plico plico3 = new Plico(45, 23, "Maria", "Lucia", 216);

List<Spedizione> sped = new List<Spedizione>();

Corriere corriere = new Corriere("Bartolini", sped);

corriere.aggiungiSpedizione(pacco1);
corriere.aggiungiSpedizione(pacco2);
corriere.aggiungiSpedizione(pacco3);
corriere.aggiungiSpedizione(plico1);
corriere.aggiungiSpedizione(plico2);
corriere.aggiungiSpedizione(plico3);

corriere.getLista();
Console.WriteLine(corriere.ingombroTotale());

Console.WriteLine(pacco1.equals(pacco1));
Console.WriteLine(pacco1.equals(pacco2));

