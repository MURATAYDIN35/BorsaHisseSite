namespace BorsaHisseSite.Models
{
    public class HisseModel
    {
        public int Id { get; set; }
        public string Sembol { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public decimal OncekiFiyat { get; set; }
        public decimal KapanisFiyati { get; set; }
        public DateTime Tarih { get; set; }

        public decimal Degisim => KapanisFiyati - OncekiFiyat;
    }
}