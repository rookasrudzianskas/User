using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Security.AccessControl;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace User
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();

            SelectQuery sq = new SelectQuery("Win32_UserAccount", "Domain= '" + Environment.MachineName + "'");

            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);

            foreach (var item in mos.Get())
            {
                lstUsers.Items.Add(item["Name"]);
            }
        }

        private void txtPassRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtPassRep.Text) return;
            if (txtUsername.Text.Trim() == "") return;

            CreateUser(txtUsername.Text, txtPass.Text, chCanChange.Checked, chExpired.Checked, !chEnable.Checked);
            button1.PerformClick();

        }
        private void CreateUser(string username, string password, bool canChange, bool isExpired, bool isDisabled)
        {
            try
            {
                PrincipalContext principalContext = new PrincipalContext(ContextType.Machine, Environment.MachineName);

                UserPrincipal user = new UserPrincipal(principalContext);

                user.SetPassword(password);
                if(isExpired)
                {
                    user.ExpirePasswordNow();
                }

                user.Name = username;
                user.Enabled = !isDisabled;
                user.UserCannotChangePassword = !canChange;
                

                user.Save();

                GroupPrincipal group = GroupPrincipal.FindByIdentity(principalContext, "Users");
                group.Members.Add(user);
                group.Save();

                MessageBox.Show("User Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUsers.SelectedItem == null) return;
                string username = lstUsers.SelectedItem.ToString();
                DirectoryEntry host = new DirectoryEntry("WinNT://"+Environment.MachineName);
                DirectoryEntries entries = host.Children;
                DirectoryEntry user = entries.Find(username);
                entries.Remove(user);
                MessageBox.Show("User deleted");
                button1.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
