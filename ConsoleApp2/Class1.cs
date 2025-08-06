using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Flags]
    enum permission
    {
        select = 1,
        insert = 2,
        update = 4,
        delete = 8
    }
    internal class Human
    {    public String username;
         public String password;
         public string role;
        public permission per=permission.select; 
        

        public void AddPermission(permission p)
        {
            this.per =per | p;
        }

        public bool HasPermission(permission p)
        {
            return (this.per & p) == p;
        }

        public void Insert() { 
            if (HasPermission(permission.insert))
            {
                Console.WriteLine("Insert operation allowed.");
            }
            else
            {
                Console.WriteLine("Insert operation not allowed.");
            }
        }

        public void Delete()
        {
            if (HasPermission(permission.delete))
            {
                Console.WriteLine("Delete operation allowed.");
            }
            else
            {
                Console.WriteLine("Delete operation not allowed.");
            }
        }

        public void Select()
        {
            if (HasPermission(permission.select))
            {
                Console.WriteLine("Select operation allowed.");
            }
            else
            {
                Console.WriteLine("Select operation not allowed.");
            }
        }
        public void Update()
        {
            if (HasPermission(permission.update))
            {
                Console.WriteLine("Update operation allowed.");
            }
            else
            {
                Console.WriteLine("Update operation not allowed.");
            }
        }

        public void ShowPermissions()
        {
            Console.WriteLine("Current permissions"+ per);

        }
    }
}
