using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleList simplelist = new SimpleList();
        private void btnTest_Click(object sender, EventArgs e)
        {
            Node node;
            node = new Node(0); simplelist.Add_at_header(node);
            node = new Node(1); simplelist.Add_at_header(node);
            node = new Node(2); simplelist.Add_at_header(node);
            txtPrint.Text = simplelist.Print();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            simplelist.Clear();
            txtPrint.Text = simplelist.Print();
        }

        private void btnMake20_Click(object sender, EventArgs e)
        {
            for(int i=0; i<20;i++)
            {
                // Node node = new Node(i);
                // simplelist.Append(node);
                new Node(i, simplelist); 
                // 메모리가 잡히면서 내부 클래스에서 참조변수가 따로 존재하므로 가능
            }
            txtPrint.Text = simplelist.Print();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Node removed_node = simplelist.FindNodeOfData(Convert.ToInt32(txtRemoveData.Text));
            simplelist.Add_at_tail(new Node(10));
            txtPrint.Text = simplelist.Print();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            simplelist = simplelist.Reverse();
            txtPrint.Text = simplelist.Print();
        }
    }
}
