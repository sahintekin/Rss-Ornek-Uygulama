using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHur_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader( "https://www.hurriyet.com.tr/rss/anasayfa");

            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
            //hmtgiltypack
              
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku2 = new XmlTextReader("https://www.fotomac.com.tr/rss/anasayfa.xml");

            while (xmloku2.Read())
            {
                if (xmloku2.Name == "title")
                {
                    listBox1.Items.Add(xmloku2.ReadString());
                }
            }
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku3 = new XmlTextReader("https://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");

            while (xmloku3.Read())
            {
                if (xmloku3.Name == "title")
                {
                    listBox1.Items.Add(xmloku3.ReadString());
                }
            }
        }
    }
}
