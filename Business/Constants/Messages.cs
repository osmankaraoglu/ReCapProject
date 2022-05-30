using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //CarMessages
        public static string CarAdded = "Araç kayıt işlemi başarılı.";
        public static string CarDeleted = "Araç silme işlemi başarılı.";
        public static string CarUpdated = "Araç güncelleme işlemi başarılı.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarNameInValid = "Araba ismi geçersiz.";

        //ColorMessages
        public static string ColorAdded = "Renk kayıt işlemi başarılı.";
        public static string ColorUpdated = "Renk güncelleme işlemi başarılı.";
        public static string ColorDeleted = "Renk silme işlemi başarılı.";
        public static string ColorsListed = "Renkler listelendi.";

        //BrandMessages
        public static string BrandAdded = "Marka kayıt işlemi başarılı.";
        public static string BrandUpdated = "Marka güncelleme işlemi başarılı.";
        public static string BrandDeleted = "Marka silme işlemi başarılı.";
        public static string BrandsListed = "Markalar listelendi.";

        //FuelMessages
        public static string FuelTypeAdded = "Yakıt tipi kayıt işlemi başarılı.";
        public static string FuelTypeUpdated = "Yakıt tipi güncelleme işlemi başarılı.";
        public static string FuelTypeDeleted = "Yakıt tipi silme işlemi başarılı.";
        public static string FuelTypesListed = "Yakıt tipleri listelendi.";

        //CustomerMessages
        public static string CustomerAdded = "Müşteri kayıt işlemi başarılı.";
        public static string CustomerUpdated = "Müşteri güncelleme işlemi başarılı.";
        public static string CustomerDeleted = "Müşteri silme işlemi başarılı.";
        public static string CustomersListed = "Müşteriler listelendi.";

        //UserMessages
        public static string UserAdded = "Kullanıcı kayıt işlemi başarılı.";
        public static string UserUpdated = "Kullanıcı güncelleme işlemi başarılı.";
        public static string UserDeleted = "Kullanıcı silme işlemi başarılı.";
        public static string UsersListed = "Müşteriler listelendi.";

        //Rental Messages
        public static string RentalAdded = "Kiralama işlemi başarılı.";
        public static string RentalUpdated = "Kiralama Bilgisi Güncellendi.";
        public static string RentalDeleted = "Kiralama Bilgisi Silindi.";
        public static string RentalsListed = "Kiralamalar listelendi.";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalUpdatedReturnDate = "Araç Teslim Alındı.";
        public static string RentalUpdatedReturnDateError = "Araç Zaten Teslim Alındı.";

        //Car Image Messages
        public static string ImageAdded = "Resim başarıyla yüklendi.";
        public static string ImageDeleted = "Resim silindi.";
        public static string ImageUpdated = "Resim Güncellendi.";
        public static string ImageAddedError = "Bir arabanın 5'den fazla resmi olamaz.";


        //JWT
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserListed = "Kullanıcı listelendi";
    }
}
