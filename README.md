# Panasonic Bakım Modülü

## Genel Bakış

**Panasonic Bakım Modülü**, bakım süreçlerinin yönetimini kolaylaştırmak amacıyla geliştirilmiş, kullanıcı dostu arayüze sahip bir masaüstü uygulamasıdır. Proje, Panasonic Electric Works Türkiye'nin bakım operasyonlarını dijitalleştirmek ve merkezi olarak yönetmek için tasarlanmıştır. Bu proje, Panasonic'te yapılan staj sürecinde verilen bir projedir.

## Özellikler

- **Kullanıcı Girişi ve Yetkilendirme:**  
  Kullanıcılar, yetkilerine göre sisteme giriş yapar. "User" rolündeki kullanıcılar kısıtlı menülere erişebilir.
- **Çoklu Form ve Modüler Yapı:**  
  Farklı işlevler için (kullanıcı yönetimi, rol düzenleme, bakım işlemleri vb.) ayrı formlar kullanılır.
- **Tema Desteği:**  
  Varsayılan, Karanlık ve Mavi olmak üzere üç farklı renk modu ile kullanıcı deneyimi kişiselleştirilebilir.
- **Çoklu Dil Altyapısı:**  
  `LanguageManager` ile çoklu dil desteği için altyapı hazırlanmıştır.
- **Veritabanı Entegrasyonu:**  
  SQL Server ile bağlantı, kullanıcı ve bakım verilerinin yönetimi.
- **Modern Arayüz:**  
  DevExpress WinForms bileşenleri ile zengin ve modern kullanıcı arayüzü.
- **Yardım ve Hakkımızda:**  
  Uygulama içinden Panasonic web sitesine yönlendirme ve iletişim bilgileri.

## Kullanılan Teknolojiler

- **.NET Framework 4.7.2**
- **C# WinForms**
- **DevExpress WinForms Bileşenleri (v23.1)**
- **Dapper (v2.0.143)**
- **System.Data.SqlClient (v4.8.5)**
- **MSSQL Server**

## Proje Yapısı
ProjectPanasonic_/
│
├── Form1.cs, Form2.cs, ... # Ana formlar ve işlevsel ekranlar
├── Util/
│ └── DBUtil.cs # Veritabanı yardımcı sınıfı
├── Services/
│ └── UserServices.cs # Kullanıcı işlemleri için servis katmanı (altyapı)
├── Properties/
│ ├── Settings.settings # Uygulama ayarları ve bağlantı stringleri
│ ├── Resources.resx # Kaynak dosyaları (ikon, metin vb.)
│ └── AssemblyInfo.cs # Derleyici ve sürüm bilgileri
├── App.config # Uygulama yapılandırma dosyası
├── ProjectPanasonic_.csproj # Proje dosyası
└── packages.config # NuGet bağımlılıkları
