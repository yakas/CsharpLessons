using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Contructor_Kurucu_Metod
{
    class Ev
    {
        int kat;
        int metreKare;
        string semt;
        int odaSayisi;

        #region Default Constructor
        public Ev()
        {
        } 
        #endregion

        #region Constructor Method
        public Ev(int kat, int metreKare, string semt, int odaSayisi)
        {
            Kat = kat;
            MetreKare = metreKare;
            Semt = semt;
            OdaSayisi = odaSayisi;
        } 
        #endregion
        #region Properties

        public int Kat
        {
            get
            {
                return kat;
            }

            set
            {
                if (value < -2)
                {
                    throw new ArgumentException("kat -2'den kücük olamaz");
                }
                else
                {
                    kat = value;
                }

            }
        }

        public int MetreKare
        {
            get
            {
                return metreKare;
            }

            set
            {

                metreKare = Math.Abs(value);
            }
        }

        public string Semt
        {
            get
            {
                return semt;
            }

            set
            {
                semt = value.Trim().ToUpper();
            }
        }

        public int OdaSayisi
        {
            get
            {
                return odaSayisi;
            }

            set
            {
                odaSayisi = Math.Abs(value);
            }
        }
        #endregion

        public string EvBilgileriniGetir()
        {

            return string.Format("Kat: {0}\nMetrekare :{1}\nSemt :{2}\nOda sayisi :{3}", Kat, metreKare, semt, odaSayisi);

        } 
        
    }
}
