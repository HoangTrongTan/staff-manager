using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HẹThongQuanLyNhanVien
{
    public partial class ThoiTiet : Form
    {
        public ThoiTiet()
        {
            InitializeComponent();
        }

        private void ThoiTiet_Load(object sender, EventArgs e)
        {
            cbxkhuvuc.Items.Add("City");
            cbxkhuvuc.Items.Add("ZIP");
            cbxkhuvuc.Items.Add("ID");

            cbxkhuvuc.SelectedIndex = 0;
        }
        private const string API_KEY = "f53674ddc6dbb85fed67f69981706ea0";
        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        private string[] QueryCodes = { "q", "zip", "id", };

        private void btnDuBaoThoiTiet_Click(object sender, EventArgs e)
        {
            string url = ForecastUrl.Replace("@LOC@", txtkhuvuc.Text);
            url = url.Replace("@QUERY@", QueryCodes[cbxkhuvuc.SelectedIndex]);
            using (WebClient client = new WebClient())
            {
                try
                {
                    DisplayForecast(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error\n" + ex.Message);
                }
            }
        }
        private void DisplayForecast(string xml)
        {
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);

            XmlNode loc_node = xml_doc.SelectSingleNode("weatherdata/location");
            txtThanhPho.Text = loc_node.SelectSingleNode("name").InnerText;
            txtQuocgia.Text = loc_node.SelectSingleNode("country").InnerText;
            XmlNode geo_node = loc_node.SelectSingleNode("location");
            txtViDo.Text = geo_node.Attributes["latitude"].Value;
            txtKinhDo.Text = geo_node.Attributes["longitude"].Value;
            txtId.Text = geo_node.Attributes["geobaseid"].Value;

            lvwForecast.Items.Clear();
            char degrees = (char)176;

            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {

                DateTime time =
                    DateTime.Parse(time_node.Attributes["from"].Value,
                        null, DateTimeStyles.AssumeUniversal);


                XmlNode temp_node = time_node.SelectSingleNode("temperature");
                string temp = temp_node.Attributes["value"].Value;

                ListViewItem item = new ListViewItem(time.DayOfWeek.ToString());
                ListViewItem.ListViewSubItem lv1 = new ListViewItem.ListViewSubItem(item, time.ToShortTimeString());
                ListViewItem.ListViewSubItem lv2 = new ListViewItem.ListViewSubItem(item, temp + degrees);
                item.SubItems.Add(lv1);
                item.SubItems.Add(lv2);
                lvwForecast.Items.Add(item);

            }
        }
        private void DisplayError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                MessageBox.Show(message_node.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error\n" + ex.Message);
            }
        }
    }
}
