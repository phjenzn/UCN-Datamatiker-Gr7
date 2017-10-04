﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace LSP.service
{
    

    public interface ICustomer

    {
        // Customer CreateNewCustomer();
        string DeleteCustomer();
        string UpdateCustomer();
        string ReadCustomer();

        string GetCustomerName();
        string SetCustomerName();

        string GetCustomerLastName();
        string SetCustomerLastName();

        int GetCustomerPhoneNumber();
        int SetCustomerPhoneNumber();

        int GetCustomerCvr();
        int SetCustomerCvr();

        int GetCustomerAddress();
        int SetCurstomerAddress();

        int GetCustomerZip();
        int SetCustomerZip();




    }
}