using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.Entities
{
    [Table("Categories")]
    public class Category : MyEntityBase//id, CreateOn, ModifiedOn, ModifiedUserName özelliklerini her yerde kullanacağımız için tekrar tekrar yazmamak için "MyEntitiesBase" classına yazdık ve category clasını ondan türettik böylece o alanlar buraya gelmiş oldu
    {
        [DisplayName("Kategori"), 
            Required(ErrorMessage ="{0} alanı gereklidir."), 
            StringLength(50, ErrorMessage = "{0} alanı max. {1} karakter içermeli.")]
        public string Title { get; set; }

        [DisplayName("Açıklama"), 
            StringLength(150, ErrorMessage = "{0} alanı max. {1} karakter içermeli.")]
        public string Description { get; set; }

        public virtual List<Note> Notes { get; set; }//Notların kategorileri var o yüzden buraya ekledik, notları geri dönceği için note veri tipinde, ama birden fazla note geri dönceği için List<note> içerisinde, başka bir classla iletişimli bir property olduğu için virtual olarak tanımladık

        public Category()//null hatası almamak için
        {
            Notes = new List<Note>();
        }
    }
}
