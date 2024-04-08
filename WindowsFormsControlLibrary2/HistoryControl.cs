using Patholab_DAL_V1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WindowsFormsControlLibrary2
{
    public partial class HistoryControl: UserControl
    {
        const string Medical_Title = "אין הסטוריה במדיקל";
        public event Action<string> ItemSelected;
        public SDG _sdg;
        private DataLayer _dal;

        public HistoryControl()
        {
            InitializeComponent();
        }

        public void ClearList()
        {
            lbMedical.Items.Clear();
            radListControl1.Items.Clear();
            //    lblVisit.Text = "";
        
        }

        public void LoadData(string Cusdg, SDG sdg, DataLayer dal)
        {
            _dal = dal;
            _sdg = sdg;
            IQueryable<SDG_USER> Historylist = _dal.FindBy<SDG_USER>(x => x.U_PATIENT.Value == _sdg.SDG_USER.U_PATIENT.Value).Include(x => x.CLIENT).Include(a => a.SDG);

            foreach (var item in Historylist)
            {
                if (item.SDG.NAME != Cusdg)
                {

                    RadListDataItem descriptionItem = new RadListDataItem();
                    descriptionItem.Text = item.U_PATHOLAB_NUMBER + "     " + item.SDG.CREATED_ON.Value.ToString("dd/MM/yyyy");
                    string imgN = string.Format("sdg{0}.ico", item.SDG.STATUS);
                    descriptionItem.Image = new Bitmap(Path.Combine(Patholab_Common.Utils.GetResourcePath(), "sdg" + _sdg.STATUS + ".ico"));


                    this.radListControl1.Items.Add(descriptionItem);

                }
            }

            var client = Historylist.First().CLIENT.CLIENT_USER;// sdg.SDG_USER.CLIENT.CLIENT_USER;

            List<string> split = new List<string>();
            if (client.U_VISIT_1 != null)
            {
                split.AddRange(client.U_VISIT_1.Split(','));
            }
            if (client.U_VISIT_2 != null)
            {
                split.AddRange(client.U_VISIT_2.Split(','));

            }

            foreach (var row in split)
            {
                lbMedical.Items.Add(row);
            }

            //         label1.Text = string.Format ( "{0} \n {1}", client.U_VISIT_1, client.U_VISIT_2 );
            //   }

        }


        private void radListControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var sdg = (((Telerik.WinControls.UI.RadListControl)(sender)).SelectedItem).Text;

                //Split sdg name from string
                var INDX = sdg.IndexOf(' ');
                var sdgName = sdg.Substring(0, INDX);
                ItemSelected(sdgName);

            }

            catch (Exception ex)
            {

                MessageBox.Show("Cannot Load this sdg " + ex.Message, "Nautilus", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        internal void LoadDat8a(string p, IQueryable<SDG_USER> list)
        {
            //   throw new NotImplementedException ( );
        }

        internal void LoadDa7ut8a(string p, IQueryable<SDG_USER> list)
        {
            throw new NotImplementedException();
        }


    }
}
