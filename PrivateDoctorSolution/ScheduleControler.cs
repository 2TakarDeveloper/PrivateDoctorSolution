using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using GridScheduleSample;

namespace PrivateDoctorSolution
{
    public partial class ScheduleControler : UserControl
    {
        public ScheduleControler()
        {
            InitializeComponent();
            LoadScheduel();
        }

        private void LoadScheduel()
        {
            this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
            scheduleControl1.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;


            SimpleScheduleDataProvider dataProvider = new SimpleScheduleDataProvider();
            dataProvider.MasterList = SimpleScheduleDataProvider.InitializeRandomData();
            scheduleControl1.DataSource = dataProvider;
        }
    }
}
