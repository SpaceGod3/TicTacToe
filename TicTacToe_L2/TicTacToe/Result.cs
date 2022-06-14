using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    public class Result {
        public int SessionCount;
        public int Player1Score;
        public int Player2Score;
        public int Time;
        public DateTime DateTime;

        public Result() {
            DateTime = DateTime.Now;
        }

        public override string ToString() {
            return string.Format(
                "{0} - {1}:{2}, сеансів {3}, час {4}",
                DateTime.ToString(),
                Player1Score, Player2Score,
                SessionCount, TimeString);
        }

        public string TimeString {
            get {
                return String.Format("{0:D2}:{1:D2}",
                    Time / 60, Time % 60);
            }
        }
    }
}
