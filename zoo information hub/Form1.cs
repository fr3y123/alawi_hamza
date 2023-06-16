using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace zoo_information_hub
{

    public partial class Form1 : Form
    {
        // initalize main function which is setupUI
        public Form1()
        {

            InitializeComponent();
            SetupUI();
        }

        // This function handles animal listbox selection
        private void list_animals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (list_animals.SelectedIndex != -1)
            {
                string selectedValue = list_animals.SelectedItem.ToString(); // Use the selectedValue as needed
                animal_excel_list(selectedValue);
            }
        }

        // This function handles reading information from excel sheet.
        // It also searches for animal names based on the selected value of list_animals listbox
        private void animal_excel_list(string selectedValue)
        {
            string currentPath = Application.StartupPath;
            string parentPath = Path.GetDirectoryName(Path.GetDirectoryName(currentPath));
            string grandparentPath = Path.GetDirectoryName(parentPath);
            string greatGrandparentPath = Path.GetDirectoryName(grandparentPath);

            string filepath = greatGrandparentPath + "\\animal_info.xlsx";
            string searchValue = selectedValue; // Specify the value you want to search for
            int searchColumn = 1; // Specify the column number to search in (1 for Column A, 2 for Column B, and so on)

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filepath);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            Excel.Range usedRange = worksheet.UsedRange;
            int rowCount = usedRange.Rows.Count;
            int columnCount = usedRange.Columns.Count;

            List<AnimalInfo> matchingRows = new List<AnimalInfo>();

            for (int row = 1; row <= rowCount; row++)
            {
                Excel.Range cell = (Excel.Range)worksheet.Cells[row, searchColumn];
                string cellValue = cell.Text;

                if (cellValue == searchValue)
                {
                    AnimalInfo animalInfo = new AnimalInfo();

                    // Store the values from the row in variables
                    for (int column = 1; column <= columnCount; column++)
                    {
                        Excel.Range rowDataCell = (Excel.Range)worksheet.Cells[row, column];
                        string rowDataValue = rowDataCell.Text;

                        // Store the value in the AnimalInfo object based on the column number or name
                        switch (column)
                        {
                            case 1:
                                animalInfo.Column1Value = rowDataValue;
                                break;
                            case 2:
                                animalInfo.Column2Value = rowDataValue;
                                break;
                            case 3:
                                animalInfo.Column3Value = rowDataValue;
                                break;
                            case 4:
                                animalInfo.Column4Value = rowDataValue;
                                break;
                            case 5:
                                animalInfo.Column5Value = rowDataValue;
                                break;
                            case 6:
                                animalInfo.Column6Value = rowDataValue;
                                break;
                            case 8:
                                animalInfo.Column8Value = rowDataValue;
                                break;
                            case 10:
                                animalInfo.Column10Value = rowDataValue;
                                break;
                            case 13:
                                animalInfo.Column13Value = rowDataValue;
                                break;

                                // Add more cases for additional columns if needed
                        }
                    }

                    matchingRows.Add(animalInfo);
                }
            }


            foreach (AnimalInfo animalInfo in matchingRows)
            {
                // Add excel columns result to the textbox

                animal_name.Text = animalInfo.Column1Value;
                animal_habitat.Text = animalInfo.Column2Value;
                location.Text = animalInfo.Column3Value;
                weight.Text = animalInfo.Column6Value;
                diet.Text = animalInfo.Column8Value;
                top_speed.Text = animalInfo.Column10Value;

                // Get image link for found row
                string imageLink = animalInfo.Column13Value;

                using (WebClient client = new WebClient())
                {
                    // Save the content of the image in imageData. Note that images are going to be temporarily saved in MemoryStream
                    byte[] imageData = client.DownloadData(imageLink);

                    // Save the downloaded data in stream
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(stream);
                        pictureBox1.Image = image; // Assign the image to the PictureBox control
                    }
                }
            }
            // Close workbook to avoid errors
            workbook.Close();
            excelApp.Quit();

        }

        // Main function
        private void SetupUI()
        {
            // This excel sheet only reads to get the animal names saved in the excel sheet and display it in list_animals listbox
            // Read excel file
            string currentPath = Application.StartupPath;

            // get path of the excel file
            string parentPath = Path.GetDirectoryName(Path.GetDirectoryName(currentPath));
            string grandparentPath = Path.GetDirectoryName(parentPath);
            string greatGrandparentPath = Path.GetDirectoryName(grandparentPath);

            string filepath = greatGrandparentPath + "\\animal_info.xlsx";

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filepath);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
            Excel.Range usedRange = worksheet.UsedRange;

            int rowCount = usedRange.Rows.Count;
            list_animals.Items.Clear(); // Clear previous items

            for (int row = 2; row <= rowCount; row++)
            {
                // Read the value from the specified column
                string cellValue = ((Excel.Range)worksheet.Cells[row, 1]).Value?.ToString();

                // Add the value to the ListBox
                list_animals.Items.Add(cellValue);
            }

            // Cleanup
            workbook.Close();
            excelApp.Quit();
            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(excelApp);
        }

        // This function is used for excel sheets to handle errors
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception occurred while releasing object: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        // Unused function
        private void label10_Click(object sender, EventArgs e)
        {}
        // unused function
        private void label4_Click(object sender, EventArgs e)
        {}

        // This Handles event listbox 
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedIndex != -1)
            {
                string selectedItem = listBox.SelectedItem.ToString();

                // Perform actions with the selected item

                if (selectedItem == "Animal Encounters")
                {
                    event_name.Text = "These events allow visitors to get up close and personal with certain animals, such as feeding sessions, behind-the-scenes tours, or interactive shows.";
                    event_date.Text = "16/2/2009";
                }
                else if (selectedItem == "Educational Talks")
                {
                    event_name.Text = "Zoos often organize educational presentations and lectures where experts share knowledge about specific animals, conservation efforts, or environmental topics.";
                    event_date.Text = "29/3/2010";
                }

                else if (selectedItem == "Animal Shows")
                {
                    event_name.Text = "These shows feature trained animals showcasing their natural behaviors or performing entertaining tricks and stunts. Examples include dolphin shows, bird demonstrations, or sea lion performances.";
                    event_date.Text = "29/3/2011";
                }

                else if (selectedItem == "Conservation Awareness Events")
                {
                    event_name.Text = "Zoos actively participate in conservation initiatives, and they organize events to raise awareness about endangered species, habitat preservation, and sustainable practices. These events may include workshops, panel discussions, or fundraising activities.";
                    event_date.Text = "16/7/2012";
                }

                else if (selectedItem == "Seasonal or Holiday Events")
                {
                    event_name.Text = "Zoos often celebrate special occasions such as Halloween, Christmas, or Easter with themed events. These can include activities like pumpkin carving contests, holiday lights displays, or Easter egg hunts.";
                    event_date.Text = "20/6/2019";
                }

            }
        }
    }

    // Define a class or structure to store the values from a row
    public class AnimalInfo
    {
        // Store the searched column here
        public string Column1Value { get; set; }
        public string Column2Value { get; set; }
        public string Column3Value { get; set; }
        public string Column4Value { get; set; }
        public string Column5Value { get; set; }
        public string Column6Value { get; set; }
        public string Column8Value { get; set; }
        public string Column10Value { get; set; }
        public string Column13Value { get; set; }
    }

}
