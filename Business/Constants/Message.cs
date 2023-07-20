using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Message
    {

        // ************* CAR MESSAGES **************//
        public static string AddedCar = "Araba eklendi.";
        public static string UpdatedCar = "Araba güncellendi.";
        public static string DeletedCar = "Araba silindi.";
        public static string CarNameInValid = "Araba adı en az iki karakterden oluşmalı";
        public static string CarPriceIsNegative = "Araba günlük fiyatı 0'dan büyük olmalıdır";

        // ************* BRAND MESSAGES **************//
        public static string AddedBrand = "Marka eklendi.";
        public static string UpdatedBrand = "Marka güncellendi.";
        public static string DeletedBrand = "Marka silindi.";
        public static string BrandNameInValid = "Marka adı en az iki karakterden oluşmalı";

        // ************* COLOR MESSAGES **************//
        public static string AddedColor = "Renk eklendi.";
        public static string UpdatedColor = "Renk güncellendi.";
        public static string DeletedColor = "Renk silindi.";
        public static string ColorNameInValid = "Renk adı en az iki karakterden oluşmalı";

        // ************* RENTAL MESSAGES **************//
        public static string CarNotReturn = "İstediğiniz araç henüz teslim edilmemiş";


        // ************* CARIMAGES MESSAGES **************//
        public static string CheckIfCarImagesCarLimit = "Bir arabanın en fazla 5 resmi olabilir.";
        public static string CarImagesAdded = "Araba fotoğrafı eklendi.";
        public static string CarImagesUpdated = "Araba fotoğrafı güncellendi.";
        public static string CarImagesDeleted = "Araba fotoğrafı silindi.";





        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
