using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notepad_app
{
    public partial class Form1 : Form
    {

        // Search for folder
        string folder = @"C:\EJournalApp\";



    public Form1()
        {
            InitializeComponent();
            dir();
            PrintQueue();
        }

        public void dir()
        {
            // If directory does not exist, create it
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Saves the textbox data to string and then clears the textbox
            string jEntry = entryText.Text;
            Console.WriteLine($"Text entered: {jEntry}");
            SaveText(jEntry);
            entryText.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load title with date
            jTitle.Text = "Journal: " + DateTime.Today.ToString("d");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dirList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PrintQueue()
        {
            //Refresh listview with data currently in directory
            dirList.Items.Clear();
            string directoryLocation = folder;
            DirectoryInfo di = new DirectoryInfo(directoryLocation);
            foreach (FileInfo fi in di.GetFiles().OrderByDescending(d => d.LastWriteTime))
            {
                dirList.Items.Add(fi);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveText(string jEntry)
        {

            // Filename
            string fileName = DateTime.Today.ToString("dMMMyyyy") + ".txt";
            Console.WriteLine(fileName);
            // Fullpath
            string fullPath = folder + fileName;

            //Write data to file
            File.WriteAllText(fullPath, jEntry);
            Console.WriteLine($"Text saved as {fullPath}");

            //Refresh listView
            PrintQueue();
        }

        private void ReadText()
        {
            ////Code for on click of delete
            string selectedItem = dirList.Items[dirList.SelectedIndex].ToString();
            Console.WriteLine(selectedItem);

            //Read text from file
            string fileLocation = folder + selectedItem;
            string returnedText = File.ReadAllText(fileLocation);

            Console.WriteLine($"Text returned: {returnedText}");

            entryText.Text = returnedText;
        }



        private void loadFile_Click(object sender, EventArgs e)
        {
            ReadText();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DelText();

            PrintQueue();
        }

        private void DelText()
        {
            //find file
            string selectedItem = dirList.Items[dirList.SelectedIndex].ToString();
            string fileLocation = folder + selectedItem;

            //Delete file
            File.Delete(fileLocation);
            Console.WriteLine($"File deleted: {selectedItem}");
            entryText.Clear();
        }

    }

}
