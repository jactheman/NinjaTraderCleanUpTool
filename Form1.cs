using System.Diagnostics;

namespace NinjaTraderCleanUpTool
{
    public partial class Form1 : Form
    {
        private string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private bool deleteCache = false;
        private bool deleteDB_DayMinTickReplay = false;
        private bool deleteDB_Playback = false;
        private string ninjaDirectory;

        public Form1()
        {
            InitializeComponent();

            ninjaDirectory = String.Concat(userProfilePath, "\\", "OneDrive\\Desktop\\JaxExampleFolder");
            textBox1.Text = ninjaDirectory;


        }
        private void Button2_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of selected folder
                string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                ninjaDirectory = selectedFolderPath;
                textBox1.Text = ninjaDirectory;

                // Do something with the selected path, for example:
                MessageBox.Show("Selected folder: " + selectedFolderPath);

                // You might want to use this path to read from or write to the directory
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> directories = new List<string>();

            // Perform your work here
            if (deleteCache)
            {
                directories.Add(String.Concat(ninjaDirectory, "\\", "db\\cache"));
                directories.Add(String.Concat(ninjaDirectory, "\\", "cache"));
                directories.Add(String.Concat(ninjaDirectory, "\\", "tmp"));
                directories.Add(String.Concat(ninjaDirectory, "\\", "log"));
            }
            if (deleteDB_DayMinTickReplay)
            {
                directories.Add(String.Concat(ninjaDirectory, "\\", "db\\minute"));
                directories.Add(String.Concat(ninjaDirectory, "\\", "db\\day"));
                directories.Add(String.Concat(ninjaDirectory, "\\", "db\\tick"));


            }
            if (deleteDB_Playback)
            {
                directories.Add(String.Concat(ninjaDirectory, "\\", "db\\replay"));
            }


            foreach (var directory in directories)
            {

                try
                {
                    if (Directory.Exists(directory))
                    {
                        // Delete the file
                        Directory.Delete(directory, true);


                        // Wait for the file to be actually deleted from the disk
                        // This loop checks if the file still exists, with a small delay between checks
                        while (Directory.Exists(directory))
                        {
                            Thread.Sleep(50); // Wait for 100 ms before checking again
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while trying to delete the directory: " + ex.Message);
                }
            }
            foreach (var directory in directories) { Directory.CreateDirectory(directory); }

            // Refresh the UI if necessary
            Application.DoEvents();


            //string ninjaExe = "C:\\Windows\\System32\\notepad.exe";
            string ninjaExe = "C:\\Program Files\\NinjaTrader 8\\bin\\NinjaTrader.exe";
            Process.Start(ninjaExe);
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            deleteCache = (checkBox.Checked) ? true : false;
        }
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cB2 = (CheckBox)sender;
            deleteDB_DayMinTickReplay = (cB2.Checked) ? true : false;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox CB3 = (CheckBox)sender;
            deleteDB_Playback = (CB3.Checked) ? true : false;
        }

    }
}