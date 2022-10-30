//Написать АПИ для работы зооМагазина
//Для создания бд использовать миграции 
//Для работы с бд использовать EF

using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop_EFCoreApiHW4.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        ////[ForeignKey("FK_Type")]
        public int Type_Id { get; set; }

        ////[ForeignKey("FK_Manufacturer")]
        public int ManufacturerId { get; set; }
        public virtual Type_ type_ { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }


    }
}
