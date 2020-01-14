using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() {KategoriAdi="C#"},
                new Category() {KategoriAdi="ASP.Net MVC"},
                new Category() {KategoriAdi="ASP.Net Core"},
                new Category() {KategoriAdi="ASP.Net WebForm"}
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() {Baslik="Lorem ipsum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Resim="1.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=1 },
                new Blog() {Baslik="Mauris rutrum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=true,Onay=true,Resim="1.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=1 },
                new Blog() {Baslik="Lorem ipsum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-30),Anasayfa=true,Onay=true,Resim="1.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=1 },
                new Blog() {Baslik="Color ipsum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-5),Anasayfa=true,Onay=true,Resim="2.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=2 },
                new Blog() {Baslik="Lorem amet",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-40),Anasayfa=false,Onay=false,Resim="2.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=2 },
                new Blog() {Baslik="Lorem ipsum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-14),Anasayfa=true,Onay=true,Resim="2.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=2 },
                new Blog() {Baslik="Lorem octetur",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-2),Anasayfa=true,Onay=false,Resim="3.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=3 },
                new Blog() {Baslik="Lorem ipsum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-7),Anasayfa=false,Onay=true,Resim="3.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=3 },
                new Blog() {Baslik="Mauris rutrum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-18),Anasayfa=true,Onay=true,Resim="3.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=3 },
                new Blog() {Baslik="Dolor sit",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-25),Anasayfa=true,Onay=false,Resim="4.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=4 },
                new Blog() {Baslik="Lorem ipsum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-14),Anasayfa=false,Onay=true,Resim="4.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=4 },
                new Blog() {Baslik="Lorem ipsum",Aciklama="dolor sit amet, consectetur adipiscing elit. Mauris rutrum pretium arcu, sit ",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Resim="4.jpg",Icerik="Etiam metus orci, sollicitudin et tempus et, blandit a arcu. Fusce in nulla sit amet nunc eleifend lobortis vel a est. Pellentesque vehicula eros neque, nec elementum sapien feugiat ut. Praesent bibendum, odio vel sagittis interdum",CategoryId=4 },
            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}