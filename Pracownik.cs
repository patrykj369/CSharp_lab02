using System;

namespace lab02
{
    class Pracownik
    {
        //Zrobione 6 zadan, do zrobienia od 7
        private string _nazw;
        public string Nazwisko {
            get => _nazw;
            set => _nazw = value.Trim();
        }
        private DateTime _data = DateTime.Today;
        public DateTime DataZatrudnienia{
            get => _data;
            set => _data = (value > _data)? throw new ArgumentException("Zła data") : value;
        }
        private decimal _wyn;
        public decimal Wynagrodzenie{
            get => _wyn;
            set => _wyn = (value < 0) ? _wyn = 0 : value;
        }

        public override string ToString() => $"({Nazwisko}, {DataZatrudnienia:d MMM yyyy} ({CzasZatrudnienia}), {Wynagrodzenie} PLN)";
        
        public Pracownik(){
            Nazwisko = "Anonim";
            DataZatrudnienia = DateTime.Today;
            Wynagrodzenie = 0;
        }
        public Pracownik(string nazwisko, DateTime dataZatrudnienia, decimal wynagrodzenie){
             Nazwisko = nazwisko;
             DataZatrudnienia = dataZatrudnienia; 
             Wynagrodzenie = wynagrodzenie;
        }

        public int CzasZatrudnienia => (DateTime.Now - DataZatrudnienia).Days / 30;
    }
}
