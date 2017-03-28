using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instancia_del_objeto
{
    class Auto
    {
        //esto son atributos
        rueda dd1;
        //dd1=new rueda();//lo  hacmos separados por mejorar o hacer mejor mantenimiento
        rueda dd2;
        //dd2=new rueda();
        rueda dd3;
        //dd3=new rueda();
        rueda dd4;
        //dd4=new rueda();
        //instanciamos las rueda  en el constructor del auto
        public Auto()
        {
            //se pone this porq no son atributos
            this.dd1 = new rueda();
            this.dd2 = new rueda();
            this.dd3 = new rueda();
            this.dd4 = new rueda();
        }

    }
}
