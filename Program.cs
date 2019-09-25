using System;

namespace Null_Coalescing_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
              Customer customerA = new Customer();
              customerA.PermanentAddress = "Permanent Address for the customer A";
              customerA.Age = 90;
             Customer customerB = new Customer();
             customerB.NationalName = "oliver Kipkemei Mengich";
               customerB.LocalAddress = "Local Address for customer B";
               Customer customerC = new Customer();
               
               customerC.OfficialAddress = "Official address for customer C";
               Customer customerD = new Customer();
               

              string addressForCustomerA = null;
           string addressForCustomerB = null;
           string addressForCustomerC  = null;
           string addressForCustomerD = null;


        //    if(customerA.PermanentAddress != null)
        //    addressForCustomerA = customerA.PermanentAddress;
        //    else if(customerA.LocalAddress != null)
        //    addressForCustomerA = customerA.LocalAddress;
        //    else if(customerA.OfficialAddress != null)
        //    addressForCustomerA = customerA.OfficialAddress;
        //    else
        //    addressForCustomerA = "No Address for Customer A is Provided";

        //               if(customerB.PermanentAddress != null)
        //    addressForCustomerB = customerB.PermanentAddress;
        //    else if(customerB.LocalAddress != null)
        //    addressForCustomerB = customerB.LocalAddress;
        //    else if(customerB.OfficialAddress != null)
        //    addressForCustomerB = customerB.OfficialAddress;
        //    else
        //    addressForCustomerB = "No Address for Customer B is Provided";

        //               if(customerC.PermanentAddress != null)
        //    addressForCustomerC = customerC.PermanentAddress;
        //    else if(customerC.LocalAddress != null)
        //    addressForCustomerC = customerC.LocalAddress;
        //    else if(customerC.OfficialAddress != null)
        //    addressForCustomerC = customerC.OfficialAddress;
        //    else
        //    addressForCustomerC = "No Address for Customer C is Provided";

        //                   if(customerD.PermanentAddress != null)
        //    addressForCustomerD = customerD.PermanentAddress;
        //    else if(customerD.LocalAddress != null)
        //    addressForCustomerD = customerD.LocalAddress;
        //    else if(customerD.OfficialAddress != null)
        //    addressForCustomerD = customerD.OfficialAddress;
        //    else
        //    addressForCustomerD = "No Address for Customer D is Provided";


          //  Now to introduce the null coalescing operator as
               addressForCustomerA  = customerA.PermanentAddress ?? customerA.LocalAddress ?? customerA.OfficialAddress ?? customerA.NationalName  ??" No Address for Customer A is Provided";
               addressForCustomerB  = customerB.PermanentAddress ??  customerB.NationalName ?? customerB.LocalAddress?? customerB.OfficialAddress ??" No Address for Customer B is Provided";
               addressForCustomerC  = customerC.PermanentAddress ?? customerC.LocalAddress ?? customerC.OfficialAddress  ??" No Address for Customer C is Provided";
               addressForCustomerD  = customerD.PermanentAddress ?? customerD.LocalAddress ?? customerD.OfficialAddress  ?? "No Address for Customer D is Provided";
            foreach(var iten in addressForCustomerB)
            {
                System.Console.WriteLine(customerB.NationalName+" \n"+ customerB.LocalAddress );
                break;
            }

           System.Console.WriteLine("Address for Customer A " + addressForCustomerA);
           System.Console.WriteLine("Address for Customer B " + addressForCustomerB);
           System.Console.WriteLine("Address for customer C " + addressForCustomerC);
           System.Console.WriteLine("Address for customer D " + addressForCustomerD); 

               
                
        }
    }
    class Customer
    {
         string  permanentAddress = null;
         string localAddress = null;
         string officialAddress = null;
         string nationalName = null;
         private int? age = null;
         public int? Age
         {
             get{return age;}
             set
             {
                 if(age <18){throw new MissingMemberException("You A not A legal Citizen"); }
                 else{value = age; }
             }
         }
         public string NationalName
         {
             get{return nationalName;}
             set
             {
                 nationalName = value;
             }
         }
         public string PermanentAddress
         {
            get{return permanentAddress;  }
           set {permanentAddress = value;}
         }
         public string LocalAddress
         {
             get{return localAddress;}
             set{localAddress = value;}
         }
         public string OfficialAddress
         {
             get {return officialAddress;}
             set {officialAddress = value;}
         }
    }
}
