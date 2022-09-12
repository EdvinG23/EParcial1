using System;
using System.Collections.Generic;
using System.Text;

namespace EParcial1
{
    class Students
    {
        private string _nombre;
        private double _nota1;
        private double _nota2;
        private double _parcial1;

        public string ReturnInfo() => _nombre;

        public double ReturnGrade() => (_nota1 * .3) + (_nota2 * .3) + (_parcial1 * .4);
        
    }
    

}
