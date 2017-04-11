using Ecommerce2.Core.Transaction;
using Ecommerce2.Data.Model;
using Ecommerce2.Data.Dto;
using System.Collections.Generic;
using System.Web.Http;

namespace Ecommerce2.Api.Controllers
{
    public class ProductController : ApiController
    {
        private ProductTransaction pTran = new ProductTransaction();

        [HttpGet]
        public ProductDto Get(int id)
        {
            return pTran.Get(id);
        }

        [HttpGet]
        public ICollection<ProductDto> List()
        {
            ICollection<ProductDto> pList = pTran.List();
            return pList;
        }

        [HttpPost]
        public string Insert(object product)
        {
            ProductDto p = product as ProductDto;
            return pTran.Insert(p) > 0 ? "İşlem Başarılı" : "Bir Hata Oluştu";
        }

        [HttpPost]
        public string Update(object product)
        {
            ProductDto p = product as ProductDto;
            return pTran.Update(p) > 0 ? "İşlem Başarılı" : "Bir Hata Oluştu";
        }

        [HttpPost]
        public string Delete(int id)
        {
            return pTran.Delete(id) > 0 ? "İşlem Başarılı" : "Bir Hata Oluştu";
        }
    }
}
