using System;
using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Factory.Products;

namespace AbstractFactoryPattern{
    class Program{
        static void Main(string[] args){
                AbstractFactory factory = new MediaSocialFactory();
                var mediaSocial = factory.CreateMediaSocial();
                mediaSocial.Post(title:"Titulo do post",body: "Minha publicação no");
                mediaSocial.Like();
        }
    }
}   


