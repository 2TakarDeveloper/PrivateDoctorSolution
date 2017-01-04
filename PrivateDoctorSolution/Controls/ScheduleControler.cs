using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using System.IO;

namespace PrivateDoctorSolution.Controls
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
            SimpleScheduleDataProvider data;
            if (File.Exists("default.schedule"))
            {
                data = SimpleScheduleDataProvider.LoadBinary("default.schedule");
                data.FileName = "default.schedule";
            }

            else
            {
                data = new SimpleScheduleDataProvider
                {
                    MasterList = new SimpleScheduleAppointmentList(),
                    FileName = "default.schedule"
                };

            }

            scheduleControl1.ScheduleType = ScheduleViewType.Month;
            scheduleControl1.DataSource = data;


        }
    }
}
