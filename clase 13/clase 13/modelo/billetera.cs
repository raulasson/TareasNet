using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13.modelo
{
    internal class billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }





        public decimal Total()
        {
            decimal total;
            return total = (BilletesDe10 * 10) + (BilletesDe20 * 20) + (BilletesDe50 * 50) +
            (BilletesDe100 * 100) + (BilletesDe200 * 200) + (BilletesDe500 * 500) + (BilletesDe1000 * 1000);
        }

        public void MostrarBilletes()
        {
            Console.WriteLine($"Billetes de 10: {BilletesDe10}\nBilletes de 20: {BilletesDe20}\nBilletes de 50: {BilletesDe50}\nBilletes de 100: {BilletesDe100}\nBilletes de 200: {BilletesDe200}\nBilletes de 500: {BilletesDe500}\nBilletes de 1000: {BilletesDe1000}");
        }

        public void Vaciar()
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }
        public billetera Combinar(billetera combinar)
        {
            billetera combinada = new billetera();

            combinada.BilletesDe10 = BilletesDe10 + combinar.BilletesDe10;
            combinada.BilletesDe20 = BilletesDe20 + combinar.BilletesDe20;
            combinada.BilletesDe50 = BilletesDe50 + combinar.BilletesDe50;
            combinada.BilletesDe100 = BilletesDe100 + combinar.BilletesDe100;
            combinada.BilletesDe200 = BilletesDe200 + combinar.BilletesDe200;
            combinada.BilletesDe500 = BilletesDe500 + combinar.BilletesDe500;
            combinada.BilletesDe1000 = BilletesDe1000 + combinar.BilletesDe1000;
            this.Vaciar();
            combinar.Vaciar();
            return combinada;
        }
    }
}
