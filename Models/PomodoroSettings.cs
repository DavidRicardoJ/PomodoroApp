using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PomodoroApp.Models
{
    public class PomodoroSettings
    {
        [Required(ErrorMessage ="Specify the Pomodoro duration time.")]
        [Range(1, 60, ErrorMessage ="Pomodoro duration time invalid. The value must be between 1 and 60.")]
        public int PomodoroDuration { get; set; }

        [Range(1,15 , ErrorMessage ="Short break time invalid. The value must be between 1 and 15.")]
        public int ShortBreak { get; set; }

        [Range(15, 60, ErrorMessage ="Short break time invalid. The value must be between 15 and 60.")]
        public int LongBreak { get; set; }
    }
}
