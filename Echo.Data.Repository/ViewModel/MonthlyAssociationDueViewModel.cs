﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echo.Data.Repository;

namespace Echo.Data.Repository.ViewModel
{
    public class MonthlyAssociationDueViewModel: ViewModelBase<MonthlyAssociationDue>
    {
        public MonthlyAssociationDue GetPreviousBilling(string _unitNo)
        {
            var prevBilling = GetLast(r => r.UnitNumber == _unitNo);

            if(prevBilling != null)
            {
                return prevBilling;
            }

            return null;
        }

        public bool CreateMonthlyAssoc(MonthlyAssociationDue _monthlyAssocDue)
        {
            try
            {
                Add(_monthlyAssocDue);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}