using order_management.Database1DataSetTableAdapters;
using System;
using System.Windows.Forms;

namespace order_management
{
    public partial class Form1 : Form
    {
        UserTableAdapter userTableAdapter = new UserTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.User' table. You can move, or remove it, as needed.
            //this.userTableAdapter.Fill(this.database1DataSet.User);
            //this.userDataGridView.DataSource = this.database1DataSet.User;

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hi");
            try {
                int role_id = 2;
                if (this.role_CheckBox.CheckState == CheckState.Checked)
                {
                    role_CheckBox.Text = "Admin";
                    role_id = 1;
                }
                
                else role_CheckBox.Text = "Standard User";
                this.userTableAdapter.Insert(this.nomTxt.Text, this.emailTxt.Text, this.pwdTxt.Text, role_id);
                this.userDataGridView.DataSource = userTableAdapter.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
