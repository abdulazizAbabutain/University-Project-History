using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CollageHistory
    {
        public int CollageHistoryId { get; set; }
        public string NameArabic { get; private set; }
        public string NameEnglish { get; private set; }
        public string? DescriptionArabic { get; private set; }
        public string? DescriptionEnglish { get; private set; }
        public int CollageId { get; set; }
    }
}
