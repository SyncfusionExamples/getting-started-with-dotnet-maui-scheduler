using Syncfusion.Maui.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerSample
{
    public class ControlViewModel
    {
        public ObservableCollection<SchedulerAppointment> SchedulerEvents { get; set; }
        public ObservableCollection<ControlModel> CustomEvents { get; set; }
        public ControlViewModel() {

            this.CustomEvents = new ObservableCollection<ControlModel> { 
                new ControlModel
                {
                    EventStart = new DateTime(2022, 11, 16, 13, 0, 0),
                    EventEnd = new DateTime(2022, 11, 16, 14, 0, 0),
                    Name = "Demo Meeting",
                    Color = Colors.Red
                }
            
            };

            this.SchedulerEvents = new ObservableCollection<SchedulerAppointment> {
                new SchedulerAppointment
                {
                    StartTime = new DateTime(2022, 11, 18, 15, 0, 0),
                    EndTime = new DateTime(2022, 11, 18, 17, 0, 0),
                    Subject = "Client Meeting",
                    Background = Colors.Green
                }
            };
        
        }
    }
}
