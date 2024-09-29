using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace PointOfSale
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public static Main frm;
        static void frmClosed(object sender , FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Main getNewMain
        {
            get { if(frm == null)
                {
                    frm = new Main();
                    frm.FormClosed += new FormClosedEventHandler(frmClosed);
                }
                return frm;
            }
        }
        public Main()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.إستعادة_نسخة.Enabled = false;
            this.إنشاء_نسخة.Enabled = false;
            this.المنتج.Enabled = false;
            this.العملاء.Enabled = false;
            this.المبيعات.Enabled = false;
            this.المستخدمين.Enabled = false;
            Main.getNewMain.accordionControlElement11.Enabled = false;
            //Main.getNewMain.accordionControlElement12.Enabled = false;
            Main.getNewMain.accordionControlElement13.Enabled = false;
            Main.getNewMain.accordionControlElement14.Enabled = false;
            Main.getNewMain.accordionControlElement15.Enabled = false;
            Main.getNewMain.accordionControlElement16.Enabled = false;
            Main.getNewMain.accordionControlElement7.Enabled = false;
            Main.getNewMain.accordionControlElement18.Enabled = false;
            Main.getNewMain.accordionControlElement19.Enabled = false;
            Main.getNewMain.accordionControlElement8.Enabled = false;
            accordionControl1.ElementClick += AccordionControl1_ElementClick;
        }

        private void AccordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            var tag = e.Element.Tag as string;
            if (tag != string.Empty)
            {
                OpenFormBN(tag);
            }
        }
        public static void OpenFormBN(string name)
        {
            Form frm = null;
            if (frm != null)
            {
                frm.Show();
                return;
            }
            else
            {
                var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == name);
                if (ins != null)
                {
                    frm = Activator.CreateInstance(ins) as Form;
                    if (Application.OpenForms[frm.Name] != null)
                    {
                        frm = Application.OpenForms[frm.Name];
                    }
                    else
                    {
                        frm.Show();
                    }
                    frm.BringToFront();
                }
            }
        }

        private void خروج_Click(object sender, EventArgs e)
        {
            this.إستعادة_نسخة.Enabled = false;
            this.إنشاء_نسخة.Enabled = false;
            this.المنتج.Enabled = false;
            this.العملاء.Enabled = false;
            this.المبيعات.Enabled = false;
            this.المستخدمين.Enabled = false;
            Main.getNewMain.accordionControlElement11.Enabled = false;
            //Main.getNewMain.accordionControlElement12.Enabled = false;
            Main.getNewMain.accordionControlElement13.Enabled = false;
            Main.getNewMain.accordionControlElement14.Enabled = false;
            Main.getNewMain.accordionControlElement15.Enabled = false;
            Main.getNewMain.accordionControlElement16.Enabled = false;
            Main.getNewMain.accordionControlElement7.Enabled = false;
            Main.getNewMain.accordionControlElement18.Enabled = false;
            Main.getNewMain.accordionControlElement19.Enabled = false;
            Main.getNewMain.accordionControlElement8.Enabled = false;
        }
    }
}
