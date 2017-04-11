using Ecommerce2.Core.Transaction;
using Ecommerce2.Data.Model;
using Ecommerce2.Data.Dto;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Ecommerce2.Api.Controllers
{
    public class CategoryController : ApiController
    {
        private CategoryTransaction cTran = new CategoryTransaction();

        [HttpGet]
        public CategoryDto Get(int id)
        {
            return cTran.Get(id);
        }

        [HttpGet]
        public ICollection<CategoryDto> List()
        {
            ICollection<CategoryDto> cList = cTran.List();
            return cList;
        }

        [HttpPost]
        public string Insert(object category)
        {
            CategoryDto c = new JavaScriptSerializer().Deserialize<CategoryDto>(category.ToString());
            return cTran.Insert(c) > 0 ? "İşlem Başarılı" : "Bir Hata Oluştu";
        }

        [HttpPost]
        public string Update(object category)
        {
            CategoryDto c = category as CategoryDto;
            return cTran.Update(c) > 0 ? "İşlem Başarılı" : "Bir Hata Oluştu";
        }

        [HttpPost]
        public string Delete(int id)
        {
            return cTran.Delete(id) > 0 ? "İşlem Başarılı" : "Bir Hata Oluştu";
        }
    }
}
