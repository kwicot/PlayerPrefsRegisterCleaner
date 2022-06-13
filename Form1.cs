using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private RegistryKey currentUser;
        private RegistryKey software;
        
        private string[] companyKeys;

        private string SelectedCompany => companyKeys[comboBox_Company.SelectedIndex];
        private string SelectedProject => CompanyProjects[comboBox_Projects.SelectedIndex];
        private string[] CompanyProjects => GetSubKeyNames(software, SelectedCompany);
        private string[] ProjectPrefs => GetValueNames(SelectedCompanyKey, SelectedProject);
        private RegistryKey SelectedCompanyKey => software.OpenSubKey(SelectedCompany,true);
        private RegistryKey SelectedProjectKey => SelectedCompanyKey.OpenSubKey(SelectedProject,true);
        public Form1()
        {
            InitializeComponent();
            
            GetAllCompany();
            InitializeCompanyComboBox();
        }

        void Reload()
        {
            
        }
        void GetAllCompany()
        {
            currentUser = Registry.CurrentUser;
            software = currentUser.OpenSubKey(@"SOFTWARE",true);
            companyKeys = software.GetSubKeyNames();
        }

        string[] GetSubKeyNames(RegistryKey registryKey, string key)
        {
            return registryKey.OpenSubKey(key,true).GetSubKeyNames();
        }

        string[] GetValueNames(RegistryKey registryKey,string key)
        {
            return registryKey.OpenSubKey(key,true).GetValueNames();
        }

        string GetValueName(string value)
        {
            return SelectedProjectKey.GetValue(value).ToString();
        }

        void InitializeCompanyComboBox()
        {
            comboBox_Company.Items.Clear();
            foreach (var companyKey in companyKeys)
                comboBox_Company.Items.Add(companyKey);
        }

        void InitializeProjectsComboBox()
        {
            comboBox_Projects.Items.Clear();
            comboBox_Projects.Text = null;
            foreach (var project in CompanyProjects)
                comboBox_Projects.Items.Add(project);
        }

        void InitializeListView()
        {
            listView1.Items.Clear();
            foreach (var projectPref in ProjectPrefs)
            {
                var listViewItem = new ListViewItem(projectPref);
                var listViewSubItem = new ListViewItem.ListViewSubItem(listViewItem,GetValueName(projectPref));

                listViewItem.SubItems.Add(listViewSubItem);
                listView1.Items.Add(listViewItem);
            }
        }

        private void comboBox_Company_SelectedIndexChanged(object sender, EventArgs e) => InitializeProjectsComboBox();

        private void comboBox_Projects_SelectedIndexChanged(object sender, EventArgs e) => InitializeListView();       
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_DeleteSelected_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                var selectedItem = listView1.SelectedItems[i];
                var index = selectedItem.Index;
                var key = ProjectPrefs[index];
                SelectedProjectKey.DeleteValue(key);
            }
            
            SelectedProjectKey.Close();
            InitializeListView();
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            GetAllCompany();
            InitializeCompanyComboBox();
        }
    }
}