using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracktiveDataObjectLayer.Web.DTO.Category
{
    public class CategoryDTO
    {
        public long CategoryId { get; set; }
        public string  CategoryName { get; set; }

    }
    public class CategoryProfileDTO
    {
        public long  CategoryId { get; set; }
        public string  CategoryName { get; set; }
        public decimal ?  CategoryRate { get; set; }
        public decimal ?  CategoryBudget { get; set; }
        public decimal?  CategoryBillable { get; set; }
        public float? CategoryHours { get; set; }
        public List<CategoryAttachment> CategoryAttachment { get; set; }
        public List<CategoryContact> CategoryContact { get; set; }
    }
    public class CategoryAttachment
    {

        public long  AttachmentId { get; set; }
        public string  AttachmentName { get; set; }
        public DateTime AttachmentDate { get; set; }

    }
    public class CategoryContact
    {

        public long  ContactId { get; set; }
        public string ContactName { get; set; }
        public string MobileNo { get; set; }
        public string JobTitle { get; set; }

    }
}
