# FinalProject-Backend
Proje, çok katmanlı mimariye ve SOLID ilkelerine uygun olarak C# dilinde geliştirildi. CRUD işlemleri Entity Framework kullanılarak gerçekleştirildi. Projede veritabanı olarak MSSQL Localdb kullanıldı. Bu sistem kimlik doğrulama ve yetkilendirmeyi içerir. Kullanıcılar yalnızca yetkili oldukları işlemleri gerçekleştirebilirler. JWT'nin uygulamaları; İşlem, Önbellek, Doğrulama ve Performans yönleri uygulandı. Doğrulama için Akıcı Doğrulama desteği, IoC için Autofac desteği eklendi.
# Layers
- Core : The core layer of the project is used for universal operations.
- DataAccess : It is the layer that connects the project with the Database.
- Entities: Our tables in the database have been created as objects in our project. It also contains DTO objects.
- Business : It is the business layer of our project. Various business rules; Data controls, validations and authorization controls
- WebAPI : It is the Restful API Layer of the project. Known methods: Get, Post, Put, Delete
