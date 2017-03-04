using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;






namespace ShortCutManager
{
    public partial class shortcutManagerForm : Form
    {
        public shortcutManagerForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {



            //need to change delete

         


            for (int v = 0; v < shortcutListBox.SelectedItems.Count; v++)
            {
                shortcutListBox.Items.Remove(shortcutListBox.SelectedItems[v]);
            }



            shortcutListBox.Items.Remove(shortcutListBox.SelectedIndex);



        }






        private void shortcutManagerForm_Load(object sender, EventArgs e)
        {


        


          


        }
          
     


           
           

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            const string sPath = "Shortcut_Items.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in shortcutListBox.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("saved!");
        }

        private void openButton_Click(object sender, EventArgs e)
        {


 if (shortcutListBox.SelectedIndex == -1) 
            {
                DialogResult dialogResult = MessageBox.Show("You did not select a shortcut to open");

            }

         else {
                try
                {
                    string file = shortcutListBox.SelectedItem.ToString();
                    Process.Start(file);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("You did not select a shortcut to open");
                }


        }   


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? All shortcuts will be lost.", "Clear?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                shortcutListBox.DataSource = null;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            


        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            



            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            

              
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string path = "Shortcut_Items.txt";
                string tempPath = "";
                tempPath = openFileDialog1.FileName;

         
                
                string appendText = Environment.NewLine + tempPath + Environment.NewLine;

                File.AppendAllText(path, appendText);

        //        MessageBox.Show("Shortcut added");




                
                    }
                }

        private void loadSaveButton_Click(object sender, EventArgs e)
        {
            


                if (File.Exists("Shortcut_Items.txt"))
                {
                    shortcutListBox.DataSource = File.ReadAllLines("Shortcut_Items.txt");
                   
                }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Process.Start("Shortcut_Items.txt");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Process.Start("Readme.txt");
        }
    }






           
            



        }
    
