using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objects;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace PRPproto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Project p = new Project(215, "abc", 314);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdSaveBinary.Filter = "Binary files|*.bin";
            sfdSaveBinary.ShowDialog();

            Project temp = new Project(101, "Peter");
            Stream TestFileStream = File.Create(sfdSaveBinary.FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, temp);
            TestFileStream.Close();
        }
    }
}
