using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermarket.model;

namespace supermarket.viewmodel
{
    public class Registeviewmodel 
    {
      
        public Rellaycommand Registercommand {  get; set; }
       
        public Rellaycommand Clearcommand {  get; set; }

        public Registermodel studitem { get; set; }


        public Registeviewmodel()
        {
            studitem = studitem ?? new Registermodel();
            studitem.Username = "Deepak";
            studitem.Password = "1232";
            studitem.Email = "dk@gmail.com";
            studitem.Salary = "12000";
            Registercommand = new Rellaycommand(Register);
            Clearcommand = new Rellaycommand(Clear);
            
        }

        public void Register()
        { 
        }
        public void Clear() 
        { 
        }
    }
}
