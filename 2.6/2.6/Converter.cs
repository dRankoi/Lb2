using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6
{
    class Converter
    {
        public double UsdToUah { get; set; }
        public double EurToUah { get; set; }
        public double KrnToUah { get; set; }
        public Converter(double usd, double eur, double krn)
        {
            UsdToUah = usd;
            EurToUah = eur;
            KrnToUah = krn;
        }
            public double ConvertToUsd(double uah)
            {
                return uah * UsdToUah;
            }

            public double ConvertToEur(double uah)
            {
                return uah * EurToUah;
            }

            public double ConvertToKrn(double uah)
            {
                return uah * KrnToUah;
            }
        public double ConvertFromUsd(double usd)
        {
            return usd / UsdToUah;
        }

        public double ConvertFromEur(double eur)
        {
            return eur / EurToUah;
        }

        public double ConvertFromKrn(double krn)
        {
            return krn / KrnToUah;
        }
    }
}

