using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.UI
{
    public class DBService
    {
        public List<Article> GetAllArticles()
        {
            using (VideothekEntities dbv = new VideothekEntities())
            {
                var articles = from x in dbv.Article
                               select new { x.Id, x.Description, x.Quantity, x.RentalPrice, x.CategoryId };
                var listArticle = new List<Article>();

                foreach (var item in articles)
                {
                    listArticle.Add(new Article()
                    {
                        Id = item.Id,
                        Description = item.Description,
                        Quantity = item.Quantity,
                        RentalPrice = item.RentalPrice,
                        CategoryId = item.CategoryId
                    });
                }
                return listArticle;
            }
        }
    }
}
