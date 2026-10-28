using System.Dynamic;
using System.Globalization;

namespace Solution.Books;

public class Buku
{
   private string _judul;
   private string _pengarang;

   public string Judul
    {
        get {return _judul;}
        set{_judul = value;}
    }
    public string Pengarang
    {
        get {return _pengarang;}
        set{_pengarang = value;}
    }
    
   public Buku(string judul, string pengarang)
    {
        _judul = judul;
        _pengarang = pengarang;
    }
}
    public class BukuFiksi : Buku
    {
        private string _genre;

        public BukuFiksi(string judul, string pengarang, string genre)
        : base (judul, pengarang)
        {
            _genre = genre;
        }
        public string Genre
        {
            get {return _genre;}
            set {_genre = value;}
        }
    }
    public class BukuPelajaran : Buku
    {
        private string _subjek; 

        public BukuPelajaran(string judul, string pengarang, string subjek)
        : base(judul, pengarang)
        {
            _subjek = subjek;
        }
        public string Subjek
        {
            get {return _subjek;}
            set {_subjek = value;}
        }
    }
