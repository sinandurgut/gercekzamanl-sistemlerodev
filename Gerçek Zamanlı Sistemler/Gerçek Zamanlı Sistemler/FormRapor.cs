using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerçek_Zamanlı_Sistemler
{
    public partial class FormRapor : Form
    {
        ArduinoEntities db;
        public FormRapor()
        {
            InitializeComponent();
            db = new ArduinoEntities();
            dataGridView1.DataSource = db.OLCUM.ToList();

        }

    }
}
