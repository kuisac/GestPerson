using GestPerson.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPerson.Core
{
    /// <summary>
    /// Class Person : Permet la gestion d'une personne.
    /// </summary>
    public class Person
    {
        private string m_firstName;
        private string m_lastName;
        private DateTime m_birthDate;

        
        /// <summary>
        /// Constructeur de la class Person
        /// </summary>
        /// <param name="p_firstName">Prénom de la personne</param>
        /// <param name="p_lastName">Nom de la personne</param>
        /// <param name="p_birthDate">Date de naissance</param>
        public Person(string p_firstName, string p_lastName, DateTime p_birthDate)
        {
            if (string.IsNullOrWhiteSpace(p_firstName) || string.IsNullOrWhiteSpace(p_lastName)) throw new ArgumentNullException("Le prénom doit être non vide");
            if (p_lastName.Length < 3) throw new ArgumentException("La taille du nom n'est pas correcte.");
            if (p_birthDate == null || p_birthDate > DateTime.Now) throw new ArgumentException("Date non valide");
            m_firstName = p_firstName;
            m_lastName = p_lastName;
            m_birthDate = p_birthDate;
        }

        public string FirstName { get => m_firstName;  }
        public string LastName { get => m_lastName;  }
        public DateTime BirthDate { get => m_birthDate; }

        public int Age
        {
            get
            {
                /* DateTime v_zeroTime = new DateTime(1, 1, 1);
                 TimeSpan v_time = DateTime.Now - m_birthDate;
                 int v_years = (v_zeroTime + v_time).Year - 1;
                 return v_years;*/
                return m_birthDate.DiffDateInYear(DateTime.Now);
            }
        }
               

        public override string ToString()
        {
            return string.Format("{0} {1} dont l'age est de {2} an(s)", m_firstName, m_lastName, Age);
        }
    }
}
