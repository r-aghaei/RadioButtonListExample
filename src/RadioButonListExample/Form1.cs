using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButonListExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var datasource1 = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

            var persianCulture = CultureInfo.GetCultureInfo("fa");
            var dataSource2 = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>()
                .Select(x => new
                {
                    Value = x,
                    Name = persianCulture.DateTimeFormat.DayNames[(int)x]
                });

            this.radioButtonList1.DataSource = datasource1.ToList();

            this.radioButtonList2.DataSource = datasource1.ToList();

            this.radioButtonList3.DataSource = datasource1.ToList();

            this.radioButtonList4.DataSource = dataSource2.ToList();
            this.radioButtonList4.ValueMember = "Value";
            this.radioButtonList4.DisplayMember = "Name";

            this.radioButtonList5.DataSource = dataSource2.ToList();
            this.radioButtonList5.ValueMember = "Value";
            this.radioButtonList5.DisplayMember = "Name";
        }
    }
}
