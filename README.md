# Zadatak1.1-Studenti
https://book.tsp.edu.rs/mod/assign/view.php?id=22777

  **Rad sa generičkim tipovima**
1. Kerirati Windows Forms (.NET Framework) aplikaciju za rad sa podacima o studentima koristeći naredno uputstvo.
2. Kreirati klasu Student sa poljima: brojIndeksa, Prezime, Ime. Implementirati interfejs IEquatable<Student> kojim ćemo omogućiti ispitivanje jednakosti dva objekta klase Student metodom Equals(), kao i interfejs IComparable<Student> kako bi omogućili metodu Sort() nad nekom kolekcijom studenata. Predefinisati ToString() metodu koja će se između ostalog koristiti i za prikaz studenata u Items kolekciji kontrole ListBox na glavnoj formi. Predefinisati i GetHashCode() metodu koja će omogućiti kreiranje kolekija HashTable tipa.
3. Dizajnirati glavnu formu prema slici ispod i omoguciti kreiranje objekta student i ubacivanje u ListBox kontrolu, kao i brisanje. Za broj indeksa korisiti TryParse() metodu.
   ![download](https://github.com/tspirot/Zadatak1.1b-Studenti/assets/62893666/e23fac34-e0e9-4db2-91bd-35d3686e2014)
4.  Klasi Student dodati polje za kolekciju ocena tipa Dictionary<string, int>, gde će ključ biti naziv predmeta, a vrednost ocena int tipa. Modifikovati frontend dodavanjem kontrola za rad sa ocenama selektovanog studenta. Listbox sa ocenama prikazuje kolekciju ocena selektovanog studenta u listi studenata. U klasi Form1 kreirati listu predmeta tipa List<string>, a Combo box za izbor predmeta popuniti predmetima iz te liste u metodi Form1_Load(). Kreirati metodu za osvežavanje listboxa ocenama selektovanog studenta, a istu pozivati na promenu selektovanog studenta, dodavanje i brisanje ocene.
![download (1)](https://github.com/tspirot/Zadatak1.1b-Studenti/assets/62893666/48a37ada-c78d-4d5b-864f-c0a168bb2348)
5. Klasi Student dodati generički tip TPraksa za tip rezultata Studenta sa prakse na kraju studija, koji može biti celobrojna ocena 6-9, opisna u vidu teksta. U klasu Student kreirati generičko svojstvo tipa TPraksa u koji će se upisati rezultat sa prakse. Korisniku na formi omogućiti text box za unos/prikaz rezultata sa prakse i radio dugmad brojčana/opisna ocena za izbor tipa rezultata prakse kao i dugme za snimanje rezultata prakse.
  
