using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPattern.Abstract;
using AbstractFactoryPattern.Factory.Products;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factory
{
    public class MediaSocialFactory : AbstractFactory
    {
        public override MediaSocial CreateMediaSocial()
        {
           return new MediaSocialTwitter();
        }
    }
}