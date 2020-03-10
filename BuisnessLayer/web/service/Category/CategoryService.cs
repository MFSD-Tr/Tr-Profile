using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TracktiveDataObjectLayer.Web.DTO.Category;
using TracktiveDataLayer.EdmxModel;

namespace TracktiveBuisnessLayer.web.service.Category
{
    public class CategoryService
    {

        private  string ServiceName{get;set;}
        private TracktiveEntity dbContext;
        public CategoryService(string ServiceName)
        {
            this.ServiceName = ServiceName;
            dbContext = new TracktiveEntity();
        }

        #region "public Method"

        public List<CategoryDTO> GetCategoryList(long categoryId=1)
        {
            List<CategoryDTO> categoryList = new List<CategoryDTO>();

            switch (ServiceName)
            {
                case "Project":
                    
                    foreach(var i in dbContext.ITC_Project.Where(use=>use.TrkIndexNumber>categoryId))
                    {
                        categoryList.Add(new CategoryDTO() {

                            CategoryId =i.TrkIndexNumber,
                            CategoryName =i.CategoryName

                        });
                    }

                    break;
                case "Client":
                    foreach (var i in dbContext.ITC_Client.Where(use => use.TrkIndexNumber > categoryId))
                    {
                        categoryList.Add(new CategoryDTO()
                        {

                            CategoryId = i.TrkIndexNumber,
                            CategoryName = i.CategoryName

                        });
                    }
                    break;

            }


            return categoryList;
        }

        public CategoryProfileDTO GetCategoryProfile(long categoryId)
        {
            CategoryProfileDTO categoryProfileDTO = new CategoryProfileDTO();
            switch (ServiceName)
            {
                case "Project":
                    var projectDTO = dbContext.ITC_Project.Where(use=>use.TrkIndexNumber==categoryId).SingleOrDefault();
                    categoryProfileDTO.CategoryId = projectDTO.TrkIndexNumber;
                    categoryProfileDTO.CategoryName = projectDTO.CategoryName;
                    categoryProfileDTO.CategoryRate = projectDTO.BaseRate;
                    categoryProfileDTO.CategoryHours = projectDTO.CategoryBillableHours;
                    categoryProfileDTO.CategoryBillable = projectDTO.CategoryBillableAmount;

                    break;
                case "Client":
                    var clientDTO = dbContext.ITC_Client.Where(use => use.TrkIndexNumber == categoryId).SingleOrDefault();
                    categoryProfileDTO.CategoryId = clientDTO.TrkIndexNumber;
                    categoryProfileDTO.CategoryName = clientDTO.CategoryName;
                    categoryProfileDTO.CategoryRate = clientDTO.BaseRate;
                    categoryProfileDTO.CategoryHours = clientDTO.CategoryBillableHours;
                    categoryProfileDTO.CategoryBillable = clientDTO.CategoryBillableAmount;

                    break;
            }
            return categoryProfileDTO;
        }

        public string GetCategoryName(long categoryId)
        {
            string value = "";
            switch (ServiceName)
            {
                case "Project":
                    value = dbContext.ITC_Project.Where(use => use.TrkIndexNumber == categoryId).SingleOrDefault().CategoryName;
                    break;
            }
            return value;
        }
        #endregion

    }
}