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
    public partial class DatesForm : Form
    {
        /// <summary>
        /// Creates a form which displays the input dates in a list box.
        /// </summary>
        /// <param name="datesToDisplay">The dates to display</param>
        public DatesForm(IList<DateTime> datesToDisplay = null)
        {
            InitializeComponent();

            datesToDisplay = datesToDisplay ?? new List<DateTime>();
            listBoxDates.DataSource = datesToDisplay;
        }
    }
}
