# FinalProject-Backend
Proje, çok katmanlı mimariye ve SOLID ilkelerine uygun olarak C# dilinde geliştirildi. CRUD işlemleri Entity Framework kullanılarak gerçekleştirildi. Projede veritabanı olarak MSSQL Localdb kullanıldı. Bu sistem kimlik doğrulama ve yetkilendirmeyi içerir. Kullanıcılar yalnızca yetkili oldukları işlemleri gerçekleştirebilirler. JWT'nin uygulamaları; İşlem, Önbellek, Doğrulama ve Performans yönleri uygulandı. Doğrulama için Akıcı Doğrulama desteği, IoC için Autofac desteği eklendi.
# Layers
- Core : Projenin çekirdek katmanı evrensel işlemler için kullanılıyor.
- DataAccess : Projeyi Veritabanına bağlayan katmandır.
- Entities: Veritabanındaki tablolarımız projemizde obje olarak oluşturulmuştur. Ayrıca DTO nesnelerini de içerir.
- Business : Projemizin iş katmanıdır. Çeşitli iş kuralları; Veri kontrolleri, doğrulamalar ve yetkilendirme kontrolleri
- WebAPI : Projenin Restful API Katmanıdır. Bilinen methodlar: Get, Post, Put, Delete
# Used Technologies
- Restful API
- Result Types
- Interceptor
- Autofac
- AOP, Aspect Oriented Programming
- Caching
- Performance
- Transaction
- Validation
- Fluent Validation
- Cache Management
- JWT Authentication
- Repository Design Pattern
- Cross Cutting Concerns
- Caching
- Validation
- Extensions
- Claim
- Exception Middleware
- Service Collection
- Error Handling
- Validation Error Details
