using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TracktiveDataObjectLayer.Web.DTO.Category;
namespace TracktiveWebMVC.Models.Category
{

    public class CategoryViewModel
    {
        public List<CategoryDTO> CategoryListModel { get; set; }

        public CategoryProfileDTO categoryProfileModel { get; set; }
    }
}