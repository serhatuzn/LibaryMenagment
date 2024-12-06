# Patika+ Week9 MVC Projesi :)

## Proje Açıklaması
**MvcEndProject**, ASP.NET MVC mimarisini kullanarak geliştirilmiş bir web uygulamasıdır. Bu proje, Model-View-Controller yapısının organize bir şekilde uygulanmasını sağlar ve kullanıcı dostu bir deneyim sunmayı hedefler.

## Proje Yapısı
MvcEndProject/ ├── MvcEndProject.sln # Çözüm (Solution) dosyası ├── MvcProject/ # Ana uygulama klasörü ├── appsettings.json # Yapılandırma dosyası ├── Controllers/ # İstekleri işleyen kontrolörler ├── Models/ # Veri modelleri ├── Views/ # Kullanıcı arayüzü için Razor görünümleri ├── wwwroot/ # Statik dosyalar (CSS, JS, görseller) ├── Program.cs # Uygulamanın giriş noktası ├── Properties/ # Proje ayarları ├── MvcProject.csproj # Proje yapılandırma dosyası ├── bin/ # Derlenmiş çıktı dosyaları ├── obj/ # Derleme artefaktları
## Kurulum ve Çalıştırma

### Gereksinimler
- .NET SDK'nın makinenize kurulu olması.
- Visual Studio veya uyumlu bir IDE.

### Adımlar
1. Bu projeyi bilgisayarınıza klonlayın veya kaynak kodu indirin.
2. `MvcEndProject.sln` dosyasını Visual Studio ile açın.
3. Gerekirse NuGet paketlerini geri yükleyin:
   - **Tools > NuGet Package Manager > Manage NuGet Packages for Solution** yolunu izleyin ve eksik paketleri yükleyin.
4. Projeyi çalıştırmak için `Ctrl + F5` tuşlarına basın.

## Özellikler
- **MVC Yapısı**: Model-View-Controller mimarisi düzenli bir şekilde uygulanmıştır.
- **Yapılandırılabilirlik**: `appsettings.json` dosyası ile kolay yapılandırma.
- **Statik Dosyalar**: `wwwroot` klasörü üzerinden CSS, JS ve görseller gibi dosyalar sunulabilir.

## Testler
Testlerinizi çalıştırmak için şu adımları izleyebilirsiniz:
1. Visual Studio üzerinde **Test Explorer** penceresini açın.
2. Testleri çalıştırmak için uygun butonu tıklayın.

## Katkıda Bulunma
Projeye katkıda bulunmak isterseniz şu yolları izleyebilirsiniz:
- Bir **Issue** oluşturun.
- Yeni özellikler veya düzeltmeler için **Pull Request** gönderin.
