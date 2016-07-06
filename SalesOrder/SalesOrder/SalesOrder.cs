using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SalesOrder
{
    public class SalesOrder
    {
        private int _cost;
        private int _revenue;
        private string _salesorderno;
        private int _sellprice;

        public SalesOrder()
        {

        }

        public int Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = value;
            }
        }

        public int Revenue
        {
            get
            {
                return _revenue;
            }

            set
            {
                _revenue = value;
            }
        }

        public string Salesorderno
        {
            get
            {
                return _salesorderno;
            }

            set
            {
                _salesorderno = value;
            }
        }

        public int Sellprice
        {
            get
            {
                return _sellprice;
            }

            set
            {
                _sellprice = value;
            }
        }

        public int[] GetTotalCostbyGroup(int v, List<SalesOrder> solist)
        {
            int[] rtnCost = new int[(solist.Count / v) + 1];
            int i = 0;
            foreach (var item in solist.GroupBy(a => Math.Truncate((double)(int.Parse(a.Salesorderno) - 1) / v)))
            {

                rtnCost[i] = item.Sum(so => so.Cost);
                i++;
            }

            return rtnCost;
        }

        public int[] GetTotalRevenuebyGroup(int v, List<SalesOrder> solist)
        {
            int[] rtnRevenue = new int[(solist.Count / v) + 1];
            int i = 0;
            foreach (var item in solist.GroupBy(a => Math.Truncate((double)(int.Parse(a.Salesorderno) - 1) / v)))
            {

                rtnRevenue[i] = item.Sum(so => so.Revenue);
                i++;
            }

            return rtnRevenue;
        }
         
    }
}
