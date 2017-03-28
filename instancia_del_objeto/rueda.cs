using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instancia_del_objeto
{
    class rueda
    {
        public string marca;
        public int tamanio;
        //el constructor es lo primero q se ejecuta
        public rueda()
        {
            // como es de instancia no funcina por eso no lleva "static" rueda.marca = "sinmarca";
            // a veces funciona de esta manera marca = "sinmarca";
            //es para atributos sin instancias
            this.marca = "sinmarca";
            this.tamanio = 11;
        }
    }
}
