using System;

namespace Parcial1
{
    internal class Students
    {
        public string Nombre { get; internal set; }
        public int Edad { get; internal set; }
        public double Nota1 { get; internal set; }
        public double Nota2 { get; internal set; }
        public double Parcial1 { get; internal set; }
        public double Notafinal { get; internal set; }

        internal bool getData()
        {
            throw new NotImplementedException();
        }
    }
}