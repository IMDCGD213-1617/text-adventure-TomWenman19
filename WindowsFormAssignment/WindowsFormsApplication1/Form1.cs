using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            var PossibleExits = LocationExits.Items; //Created a variable for the list box in the form to display possible exits for the user to choose from.
            PossibleExits.Add("North");
            PossibleExits.Add("East");
            PossibleExits.Add("South");
            PossibleExits.Add("West");
        }
        private void SaveLocation_Click(object sender, EventArgs e)
        {
            try
            {
                LocationInfo info = new LocationInfo();
                info.locationName = LocationNameBox.Text;
                info.locationDescription = LocationDescBox.Text;
                info.locationItems = textBox1.Text;
                info.locationItemsDesc = textBox2.Text;
                info.locationExits = LocationExits.Text;
                SaveXML.SaveData(info, "SavedData.xml"); // Saves the information put into the text boxes  / list boxes to a XML file.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("SavedData.xml")) //Searches for the file named
            {
                XmlSerializer xs = new XmlSerializer(typeof(LocationInfo));
                FileStream read = new FileStream("SavedData.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                LocationInfo info = (LocationInfo)xs.Deserialize(read); //Deserializes the XML data back into the form
                LocationNameBox.Text = info.locationName;
                LocationDescBox.Text = info.locationDescription;
                textBox1.Text = info.locationItems;
                textBox2.Text = info.locationItemsDesc;
                LocationExits.Text = info.locationExits; //Displays previously saved data back into the form boxes.
            }

        }
    }
}
