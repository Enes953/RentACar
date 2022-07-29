using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListed = "Marka Listelendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renk Listelndi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string CarAdded = "Araba Ekendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarListed = "Araba listelendi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CustomerAdded = "Müşteri Elşendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerListed = "Müşteri Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserListed = "Kullanıcı Listelendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string RentalAdded = "Araba Kiralandı";
        public static string RentalDeleted = "Araba Kiralanmadı";
        public static string RentalListed = "Kiralık Araç Listelendi";
        public static string RentalUpdated = "Araba Bilgisi Güncellendi";
        public static string InvalidTransaction = "Geçersiz işlem";
        public static string ImageAdded = "Resim eklendi";
        public static string ImageDeleted = "Resim silindi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessFulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";
        public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
    }
}
