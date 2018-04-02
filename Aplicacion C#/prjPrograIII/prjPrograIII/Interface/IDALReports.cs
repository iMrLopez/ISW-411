using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Interfaces
{
    interface IDALReports
    {

        DataTable GetEventsByDateRange(DateTime fromDate, DateTime toDate);

        DataTable GetEmptySeats(int pId);


    }
}
