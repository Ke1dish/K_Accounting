using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Accounting.Models
{
    public enum DebtType
    {
        Received,  // Полученный долг
        Given      // Выданный долг
    }

    public enum DebtStatus
    {
        Active,    // Активный
        Repaid     // Погашенный
    }
}
