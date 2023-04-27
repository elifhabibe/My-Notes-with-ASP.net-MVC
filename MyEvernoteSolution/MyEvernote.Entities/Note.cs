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
    [Table("Notes")]
    public class Note : MyEntityBase
    {
        [DisplayName("Not Başlığı"), Required, StringLength(60)]
        public string Title { get; set; }

        [DisplayName("Not Metni"), Required, StringLength(2000)]
        public string Text { get; set; }

        [DisplayName("Taslak")]
        public bool IsDraft { get; set; }

        [DisplayName("Beğenilme")]
        public int LikeCount { get; set; }

        [DisplayName("Kategori")]
        public int CategoryId { get; set; }//İlişkili olduğu tablo adı ve o tablodaki primary keyi yazarsan entitiy otamatik bağlantı kurar (CategoryId)


        public virtual EvernoteUser Owner { get; set; }//Bir notun yazarı vardır ama sadece bir tane
        public virtual List<Comment> Comments { get; set; }
        public virtual Category Categorys { get; set; }//Her notun sadece bir tane kategorisi vardır
        public virtual List<Liked> Likes { get; set; }//Bir notun birden fazla likeı vardır


        public Note()//ilk oluşurken boş gelmemesi için null hatası almamak içincontructor
        {
            Comments = new List<Comment>();
            Likes = new List<Liked>();
        }
    }
}
