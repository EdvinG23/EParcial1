using System;
using System.Collections.Generic;
using System.Text;

namespace EParcial1
{
    class Student
    {
        private string _nombre;
        private double _nota1;
        private double _nota2;
        private double _parcial1;

        public Student(string nombre, double nota1, double nota2, double parcial1)
        {
            _nombre = nombre;
            _nota1 = nota1;
            _nota2 = nota2;
            _parcial1 = parcial1;
        }

        public string ReturnInfo() => _nombre;

        public double ReturnGrade() => (_nota1 * .3) + (_nota2 * .3) + (_parcial1 * .4);

    }


}

