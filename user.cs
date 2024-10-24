using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrbilgisistemi
{
    public string TCKimlik { get; set; }          // Türkiye Cumhuriyeti Kimlik Numarası
    public string ogradi { get; set; }            // Ad
    public string ogrsoyadi { get; set; }         // Soyad
    public string ogrdogumyeri { get; set; }      // Doğum Yeri
    public DateTime ogrtime { get; set; }         // Doğum Tarihi
    public string ogrtel { get; set; }            // Cep Telefonu
    public string ogrposta { get; set; }          // E-posta
    public string veliadi { get; set; }           // Veli Adı
    public string velisoyadi { get; set; }        // Veli Soyadı
    public string Gender { get; set; }            // Cinsiyet
    public string ogrno { get; set; }             // Okul Numarası
    public string ogrbolum { get; set; }          // Bölüm
    public string ogrdonem { get; set; }          // Dönem
}