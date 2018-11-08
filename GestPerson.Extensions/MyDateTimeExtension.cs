using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPerson.Extensions
{
    public static class MyDateTimeExtension
    {
        /// <summary>
        /// Calcul le nombre d'années entre la date courante et la date passé en paramètre.
        /// </summary>
        /// <param name="p_orig"></param>
        /// <param name="p_second">Date avec laquelle on souhaite calculer la différence.</param>
        /// <returns></returns>
        public static int DiffDateInYear(this DateTime p_orig, DateTime p_second)
        {
            DateTime v_zeroTime = new DateTime(1, 1, 1);
            TimeSpan v_time = p_second - p_orig;
            int v_years = (v_zeroTime + v_time).Year - 1;
            return v_years;            
        }
    }
}
