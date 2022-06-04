﻿

namespace HRProject.DAL.Managers
{
    public class ManagerStorage
    {
        public DepartmentManager DepartmentManager { get; private set;}
        public EmployeeHistoryManager EmployeeHistoryManager { get; private set;}
        public EmployeeManager EmployeeManager { get; private set;}
        public EmployeeRequestManager EmployeeRequestManager { get; private set;}

        public ManagerStorage()
        {
            DepartmentManager = new DepartmentManager();
            EmployeeHistoryManager = new EmployeeHistoryManager();
            EmployeeRequestManager = new EmployeeRequestManager();
            EmployeeManager = new EmployeeManager();
        }
    }
}