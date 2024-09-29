using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.PL
{
    public partial class Login : Form
    {
        BL.CLS_activation act = new BL.CLS_activation();

        
        public Login()
        {
            InitializeComponent();

        }


    
  

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt =  act.Activ(Text_Name.Text, Text_Pas.Text);
            if (dt.Rows.Count > 0)
            {
               

               
                //}
                //Main m = new Main();
                //m.ShowDialog();
                Program.SalesMan = dt.Rows[0]["ID_AC"].ToString();
                this.Close();
                Thread thread = new Thread(openform);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();



            }
            else
            {
                MessageBox.Show("falid");
            }
            void openform()
            {
                Application.Run(new Main());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
           
        }

        private void Text_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_Pas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
