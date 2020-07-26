using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthlyFanartMaker
{
    public partial class Maker : Form
    {
        public Maker()
        {
            InitializeComponent();
        }

        private void media_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediapv.Image = Image.FromFile(Application.StartupPath + "/icons/" + media_box.Text + ".png");
            if (media_box.Text== "Atelier 801"){
                tx_nick.Size = new Size(121, 20);
                tx_tag.Visible = true;
                tx_link.Text = "https://atelier801.com/profile?pr=";
                tx_link.Enabled = false;
            }
            else
            {
                tx_nick.Size = new Size(201, 20);
                tx_tag.Visible = false;
                tx_link.Text = "";
                tx_link.Enabled = true;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(tx_thumb.Text);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            picprev.Image = img;
        }

        private void Tx_tag_TextChanged(object sender, EventArgs e)
        {
            if (tx_tag.TextLength == 4)
            {
                tx_link.Text = "https://atelier801.com/profile?pr=" + tx_nick.Text + "%23" + tx_tag.Text;
                
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string Nickname = tx_nick.Text;
            if(media_box.Text=="Atelier 801")
            {
                Nickname = Nickname + "#" + tx_tag.Text;
            }
            table_fanarts.Rows.Add(Nickname, media_box.Text, tx_thumb.Text, tx_link.Text);
        }
    }
}
