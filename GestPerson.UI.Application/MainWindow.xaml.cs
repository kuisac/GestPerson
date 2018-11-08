using GestPerson.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestPerson.UI.App
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> m_persons;

        public MainWindow()
        {
            InitializeComponent();
            m_persons = new List<Person>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Person v_pers = new Person(txb_firstName.Text, txb_lastName.Text, dtp_BirthDate.SelectedDate.Value);
                m_persons.Add(v_pers);
                string v_text = "";
                foreach(var v_tpPers in m_persons)
                {
                    v_text += string.Format("Bienvenu {0}", v_tpPers) + "\r\n";
                }
                txb_Result.Text = v_text;
            }
            catch(Exception p_ex)
            {
                MessageBox.Show(string.Format("Erreur à la création de personne : {0}", p_ex.Message));
            }
        }
    }
}
