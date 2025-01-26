using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tuttle
{
    public class DeskQuote
    {
        public string _name;
        public decimal _deskWidth;
        public decimal _deskDepth;
        public decimal _numDrawers;
        public string _surfaceMaterial;
        public decimal _rushDays;
        public decimal _finalPrice;
        public DeskQuote(string name, decimal deskWidth, decimal deskDepth, decimal numDrawers, string surfaceMaterial, decimal rushDays, decimal finalPrice) {
            _name = name;
            _deskWidth = deskWidth;
            _deskDepth = deskDepth;
            _numDrawers = numDrawers;
            _surfaceMaterial = surfaceMaterial;
            _rushDays = rushDays;
            _finalPrice = finalPrice;

        }

        public string GetString()
        {
            return $"Order Name: {_name}, Desk Width: {_deskWidth}, Desk Depth: {_deskDepth}, Number of Drawers: {_numDrawers}, Surface Material: {_surfaceMaterial}, Rush Days: {_rushDays}, Final Price: ${_finalPrice}";
        }

        public string GetSurfaceMaterial()
        {
            return _surfaceMaterial ;
        }
    }
}
