using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenfinalej1
{
    class negocio
    {
        private List<pedido> Listapedidos;
        public void insertar(pedido ped)
        {
            Listapedidos.Add(ped);
        }
       
        public List<pedido> GetPedido1()
        {
            List<pedido> aux = new List<pedido>();

            var consulta2 = from P in Listapedidos
                           where P.horaentrega == ""
                            select P;
                           foreach (pedido p in consulta2)
                           {
                            aux.Add(p);
                           }
            return aux;
        }
        public List<pedido> GetPedido2()
        {
            List<pedido> aux = new List<pedido>();

            var consulta3 = from P in Listapedidos
                           where P.monto <=250
                              select P;
                            foreach (pedido p in consulta3)
                            {
                              aux.Add(p);
                            }
            return aux;
        }
        public List<pedido> GetPedido3()
        {
            List<pedido> aux = new List<pedido>();

            var consulta4 = from p in Listapedidos

                        group p by p.tipoped into tipo
                        select new {tipo = tipo.Key, Cantidad = tipo.Count() };
                        foreach (var grupotipo in consulta4)
                        {
                        //aux.Add(grupotipo.tipo,grupotipo.Cantidad);
                        }
                        return aux;
        }

    }
    class pedido
    {
        public int npedido{ set; get; }
        public String tipoped { set; get; }
        public Double monto { set; get; }
        public String horapedido { set; get; }
        public String horaentrega { set; get; }
    public pedido(int npedidos, string tipopeds, double montos, string horapedidos, string horaentregas)
        {
            npedido = npedidos;
            tipoped = tipopeds;
            monto = montos;
            horapedido = horapedidos;
            horaentrega = horaentregas;

        }

    }


}
