using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.BusinessLayer.Constants
{
    public static class Messages
    {
        public static string WriterNamePropertyNotEmpty = "Yazar adı alanı boş geçilemez.";
        public static string WriterNamePropertyMinimumSize = "Yazar adı alanı en az 3 karakter olabilir.";
        public static string WriterNamePropertyMaximumSize = "Yazar adı alanı en çok 20 karakter olabilir.";
        public static string WriterNamePropertyNotNumber = "Yazar adı alanı sayı içeremez.";


        public static string WriterSurnamePropertyNotEmpty = "Yazar soyadı alanı boş geçilemez.";
        public static string WriterSurnamePropertyMinimumSize = "Yazar soyadı alanı en az 3 karakter olabilir.";
        public static string WriterSurnamePropertyMaximumSize = "Yazar soyadı alanı en çok 20 karakter olabilir.";
        public static string WriterSurnamePropertyNotNumber = "Yazar soyadı alanı sayı içeremez.";


        public static string DateofBirthPropertyNotEmpty = "Doğum tarihi alanı boş geçilemez.";
        public static string DateofBirthPropertyMinimumSize = "Doğum tarihi alanı en az 3 karakter olabilir.";
        public static string DateofBirthPropertyMaximumSize = "Doğum tarihi alanı en çok 20 karakter olabilir.";
        public static string DateofBirthPropertyNotValidFormat = "Doğum tarihi alanı geçersiz bir tarih formatında yada tarih formatında değil.";
        //public static string DateofBirthPropertyNotNumber = "Doğum tarihi alanı sayı içeremez.";

        //public static string WriterImageUrlPropertyNotEmpty = "Yazar profil resmi boş geçilemez.";
        public static string WriterImageUrlPropertyMinimumSize = "Profil resmi URL alanı en az 10 karakter olabilir.";
        public static string WriterImageUrlPropertyMaximumSize = "Yazar adı alanı en çok 250 karakter olabilir.";
        //public static string WriterImageUrlPropertyNotNumber = "Yazar adı alanı sayı içeremez.";

        public static string WriterAboutPropertyMinimumAndMaximumSize = "En az 50 karakter, en çok 250 karakter aralığında olabilir.";


        //public static string WriterAboutPropertyNotEmpty = "Hakkında alanı boş geçilemez.";
        public static string WriterEmailPropertyNotEmpty = "Yazar e-mail alanı boş geçilemez.";
        public static string WriterEmailPropertyNotCorrectEmailFormat = "Geçerli eposta adresi formatı değil.";
        //public static string WriterStatusPropertyNotEmpty = "Yazar durumu alanı boş geçilemez.";
        //public static string ConfirmCodePropertyNotEmpty = "Onay kodu alanı boş geçilemez.";


        public static string WriterTitlePropertyNotEmpty = "Yazar başlığı alanı boş geçilemez.";
        public static string WriterTitlePropertyMinimumSize = "Yazar başlığı alanı en az 3 karakter olabilir.";
        public static string WriterTitlePropertyMaximumSize = "Yazar başlığı alanı en çok 20 karakter olabilir.";
        public static string WriterTitlePropertyNotNumber = "Yazar başlığı alanı sayı içeremez.";

        public static string PasswordPropertyNotEmpty = "Parola alanı boş geçilemez.";
        public static string PasswordPropertyMinimumSize = "Parola alanı en az 8 karakter olmadılır.";
        public static string PasswordPropertyMaximumSize = "Parola alanı en fazla 16 karakter olmadılır.";
        public static string MustContainAtLeastTwoSpecialCharacters = "Parola alanı en az 2 özel karakter içermelidir.";
        public static string MustContainAtLeastTwoNumber = "Parola alanı en az 2 sayı içermelidir.";
        public static string MustContainAtLeastTwoCapitalLetters = "Parola alanı en az 2 büyük harf içermelidir.";
        public static string MustContainAtLeastTwoLowercaseLetters = "Parola alanı en az 2 küçük harf içermelidir.";

        public static string ConfirmPasswordPropertyNotEmpty = "Parola onayı alanı boş geçilemez.";
        public static string ConfirmPasswordPropertyMinimumSize = "Parola onayı alanı en az 8 karakter olmadılır.";
        public static string ConfirmPasswordPropertyMaximumSize = "Parola onayı alanı en fazla 16 karakter olmadılır.";
        public static string ConfirmPasswordPMustContainAtLeastTwoSpecialCharacters = "Parola onayı alanı en az 2 özel karakter içermelidir.";
        public static string ConfirmPasswordPMustContainAtLeastTwoNumber = "Parola onayı alanı en az 2 sayı içermelidir.";
        public static string ConfirmPasswordPMustContainAtLeastTwoCapitalLetters = "Parola onayı alanı  en az 2 büyük harf içermelidir.";
        public static string ConfirmPasswordPMustContainAtLeastTwoLowercaseLetters = "Parola onayı alanı en az 2 küçük harf içermelidir.";
    }
}
/*
 *  public string WriterName { get; set; }

        public string WriterSurname { get; set; }

        public DateTime DateofBirth { get; set; }
        public string? WriterImageUrl { get; set; }
        public string WriterAbout { get; set; }

        public string WriterEmail { get; set; }

        public string WriterTitle { get; set; }

        public bool WriterStatus { get; set; }

        public int? ConfirmCode { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
 * */
