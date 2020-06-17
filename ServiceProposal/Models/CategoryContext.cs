namespace ServiceProposal.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CategoryContext : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ServiceProposal.Models.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public CategoryContext()
            : base("CategoryContext")
        {
        }
        public DbSet<Category> Categories { get; set; }


        

     //   public class CategoryInitializer : DropCreateDatabaseAlways<CategoryContext>
      //  { }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
   