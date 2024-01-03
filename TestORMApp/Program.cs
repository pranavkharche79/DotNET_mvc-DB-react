using System;
using System.Collections.Generic;
using BOL;
using DAL;

Console.WriteLine("Welcome to the Program");

IDBManager dbm=new DBManager();

bool status=true;
// Console based Menu driven User Interface
while(status)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Insert  new record");
    Console.WriteLine("3. Update existing record");
    Console.WriteLine("4. Delete existing record");
    Console.WriteLine("5. Exit");

    switch(int.Parse(Console.ReadLine()))
    {
        //Display Departments
        case 1:
        {
            List<Product> allDepartments=dbm.GetAll();

            foreach (var dept in allDepartments)
            {
                Console.WriteLine(" Id: {0}, Title: {1}, Description: {2},Unitprice: {3},Categoryid: {4},Unitinstock: {5}",
                                    dept.Productid,dept.Title,dept.Description,dept.Unitprice,dept.Categoryid,dept.Unitinstock );
            }
        }
        break;
            
        //Insert new  Department
        case 2:
            Console.WriteLine("Enter product id: ");
            int id= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Title: ");
            string tit= Console.ReadLine();
            Console.WriteLine("Enter product Description: ");
            string des= Console.ReadLine();
            Console.WriteLine("Enter product Unitprice: ");
            int unt= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Categotyid: ");
            int cid= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product Unitinstock: ");
            int us= int.Parse(Console.ReadLine());
            var newDept = new Product()
            {
                Productid = id,
                Title = tit,
                Description = des,
                Unitprice = unt,
                Categoryid = cid,
                Unitinstock = us
            };
            dbm.Insert(newDept);
        break;

        // Update existing Department
        case 3:
            Console.WriteLine("Enter product id: ");
            int id1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Title: ");
            string tit1= Console.ReadLine();
            Console.WriteLine("Enter Updated Description: ");
            string des1= Console.ReadLine();
            Console.WriteLine("Enter Updated Unitprice: ");
            int unt1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Categotyid: ");
            int cid1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Unitinstock: ");
            int us1= int.Parse(Console.ReadLine());
            var updateProduct = new Product(){
                Productid = id1,
                Title = tit1,
                Description = des1,
                Unitprice = unt1,
                Categoryid = cid1,
                Unitinstock = us1   
            };
            dbm.Update(updateProduct);

        break;
    
        // Delete existing Department
        case 4:
            Console.WriteLine("Enter product id to delete: ");
            int a= int.Parse(Console.ReadLine());
            dbm.Delete(a);
        break;
    
        //Exit from loop
        case 5:
            status = false;
        break;
    }
}


