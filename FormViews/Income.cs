using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTrack.Services;

namespace FinTrack.Views
{
    public partial class Income: Form
    {
        FinanceServices financeServices;
        public Income()
        {
            financeServices = new FinanceServices();
            InitializeComponent();
            
        }
    }
}
