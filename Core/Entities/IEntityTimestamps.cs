using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    
        public interface IEntityTimestamps
        {
        //classların içi private interface içi public default değerleri
            DateTime CreatedDate { get; set; }
            DateTime? UpdatedDate { get; set; }
            DateTime? DeletedDate { get; set; }
        }
    
}
