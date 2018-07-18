using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_intervals_desktop
{
    public partial class DateIntervalsForm : Form
    {
        protected enum TypeOfDateInterval { Before, After };

        public DateIntervalsForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // negative interval length means the list should go backwards
            var intervalLength = radioButtonBefore.Checked ? numPickerIntervalLength.Value * -1 : numPickerIntervalLength.Value;

            var listOfDates = MakeListOfDates(dateTimePicker.Value, (int)numPickerDates.Value, (int)intervalLength);
            DatesForm datesForm = new DatesForm(listOfDates);
            datesForm.Show();
        }

        /// <summary>
        /// Creates a list of dates specified by the input parameters.
        /// </summary>
        /// <param name="startDate">The first date of the list of dates.</param>
        /// <param name="numDates">Number of dates to include in the final list.</param>
        /// <param name="daysBetweenDates">Number of days between each date in the final list.</param>
        /// <returns></returns>
        protected IList<DateTime> MakeListOfDates(DateTime startDate, int numDates, int daysBetweenDates)
        {
            if (startDate == null)
            {
                throw new ArgumentNullException("startDate");
            }

            if (numDates < 1)
            {
                throw new ArgumentOutOfRangeException("numDates");
            }

            var listOfDates = new List<DateTime>(numDates);
            for (int i = 0; i < numDates; i++)
            {
                int daysToAddToStartDate = i * daysBetweenDates;
                listOfDates.Add(startDate.AddDays(daysToAddToStartDate));
            }

            return listOfDates;
        }
    }
}
