using System;
using System.Windows.Forms;
//using Syncfusion.Windows.Forms.Schedule;
using System.IO;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms.Schedule;

namespace PrivateDoctorSolution.Controls
{
    public partial class ScheduleControler : UserControl
    {
        private SimpleScheduleDataProvider _data;
        public ScheduleControler()
        {
            InitializeComponent();
            LoadScheduel();
            scheduleControl1.GetScheduleHost().Schedule.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            scheduleControl1.EnableTouchMode = true;
        }

        private void LoadScheduel()
        {
           
            if (File.Exists("default.schedule"))
            {
                _data = SimpleScheduleDataProvider.LoadBinary("default.schedule");
                _data.FileName = "default.schedule";
            }

            else
            {
                _data = new SimpleScheduleDataProvider
                {
                    MasterList = new SimpleScheduleAppointmentList(),
                    FileName = "default.schedule"
                };

            }

            scheduleControl1.ScheduleType = ScheduleViewType.Month;
            scheduleControl1.DataSource = _data;    
        }


        private void PushNotification()
        {
            
           
        }

    }
}
