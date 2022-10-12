using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Interfaces
{
    interface IRepositoryBase 
    {
        List<Employee> ListAll();

        Employee Select(int Id);

        Employee Insert(Employee objeto);

        Employee Edit(Employee objeto);

        int Delete(Employee objeto);
        

    }
}
