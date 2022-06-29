using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;

namespace Rosa
{
    public partial class UserControlDays : UserControl
    {
        
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void lbdays_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
          
        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";

        }
        private void displayEvent()
        {
           

        }
    }
}
