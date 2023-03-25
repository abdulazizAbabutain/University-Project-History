using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class HistoryAuditEntity
    {
        public OperationType OperationType { get; private set; }
        public OperationType OperationTypeId { get; private set; }
        public DateTimeOffset OperationDate { get; private set; }
        public string? DoneBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
