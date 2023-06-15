using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2k1Shop.Model.Abstract
{
   public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
        string UpdatedBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

         bool Status { set; get; }
    }
}
