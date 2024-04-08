using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLonWinform.Classes
{
    internal class CommonFuntions
    {
        public void FillComboBox(ComboBox comboName, DataTable data, string displayMember, string valueMember)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }
    }
}
