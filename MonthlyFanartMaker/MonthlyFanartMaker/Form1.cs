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
            if (media_box.Text == "Atelier 801")
            {
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
            try
            {
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(tx_thumb.Text);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                picprev.Image = img;
            }
            catch
            {
                MessageBox.Show("Please add the thumbnail.");
            }
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
            int fanartcount = table_fanarts.Rows.Count;
            if (fanartcount < 15)
            {
                string Nickname = tx_nick.Text;
                if (media_box.Text == "Atelier 801")
                {
                    Nickname = Nickname + "#" + tx_tag.Text;
                }
                WebClient wc = new WebClient();
                System.Drawing.Image img;
                try
                {
                    byte[] bytes = wc.DownloadData(tx_thumb.Text);
                    MemoryStream ms = new MemoryStream(bytes);
                    img = System.Drawing.Image.FromStream(ms);
                }
                catch
                {
                    byte[] bytes = wc.DownloadData("https://i.imgur.com/wvCqhzD.jpg");
                    MemoryStream ms = new MemoryStream(bytes);
                    img = System.Drawing.Image.FromStream(ms);
                }

                table_fanarts.Rows.Add(img, Nickname, media_box.Text, tx_thumb.Text, tx_link.Text);
                tx_tag.Text = "";
                tx_nick.Text = "";
                tx_thumb.Text = "";
            }
            else
            {

                MessageBox.Show("Número de Fanarts máximo atingido");
            }

        }

        private void Maker_Load(object sender, EventArgs e)
        {

        }

        private void Table_fanarts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = table_fanarts.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to delete this Fanart?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    table_fanarts.Rows.Remove(table_fanarts.Rows[e.RowIndex]);
                    MessageBox.Show("Deleted.");
                }
                row.Dispose();
            }
            if (e.ColumnIndex == 6)
            {
                WebClient wc = new WebClient();
                System.Drawing.Image img;
                DataGridViewRow row = table_fanarts.Rows[e.RowIndex];
                try
                {
                    byte[] bytes = wc.DownloadData(row.Cells[3].Value.ToString());
                    MemoryStream ms = new MemoryStream(bytes);
                    img = System.Drawing.Image.FromStream(ms);
                }
                catch
                {
                    byte[] bytes = wc.DownloadData("https://i.imgur.com/wvCqhzD.jpg");
                    MemoryStream ms = new MemoryStream(bytes);
                    img = System.Drawing.Image.FromStream(ms);
                }
                row.Cells[0].Value = img;
                row.Dispose();
                wc.Dispose();

                table_fanarts.Refresh();
            }
        }

        private void Btn_go_Click(object sender, EventArgs e)
        {
            string[,] arrayfanart = new string[15, 5];
            for(int i = 0; i < 15; i++)
            {
                try
                {
                    
                    arrayfanart[i, 0] = formatnick(table_fanarts.Rows[i].Cells[1].Value.ToString(), arrayfanart[i, 1] = table_fanarts.Rows[i].Cells[2].Value.ToString());
                    arrayfanart[i, 1] = table_fanarts.Rows[i].Cells[2].Value.ToString();
                    arrayfanart[i, 2] = table_fanarts.Rows[i].Cells[3].Value.ToString();
                    arrayfanart[i, 3] = table_fanarts.Rows[i].Cells[4].Value.ToString();
                }
                catch
                {
                    arrayfanart[i, 0] = "";
                    arrayfanart[i, 1] = "";
                    arrayfanart[i, 2] = "";
                    arrayfanart[i, 3] = "";
                }
                
            }
            string table = File.ReadAllText(Application.StartupPath + "/basetable.txt");
            string tabledit = String.Format(table, arrayfanart[0, 3], arrayfanart[0, 2], arrayfanart[0, 0], arrayfanart[1, 3], arrayfanart[1, 2], arrayfanart[1, 0], arrayfanart[2, 3], arrayfanart[2, 2], arrayfanart[2, 0], arrayfanart[3, 3], arrayfanart[3, 2], arrayfanart[3, 0], arrayfanart[4, 3], arrayfanart[4, 2], arrayfanart[4, 0], arrayfanart[5, 3], arrayfanart[5, 2], arrayfanart[5, 0], arrayfanart[6, 3], arrayfanart[6, 2], arrayfanart[6, 0], arrayfanart[7, 3], arrayfanart[7, 2], arrayfanart[7, 0], arrayfanart[8, 3], arrayfanart[8, 2], arrayfanart[8, 0], arrayfanart[9, 3], arrayfanart[9, 2], arrayfanart[9, 0], arrayfanart[10, 3], arrayfanart[10, 2], arrayfanart[10, 0], arrayfanart[11, 3], arrayfanart[11, 2], arrayfanart[11, 0], arrayfanart[12, 3], arrayfanart[12, 2], arrayfanart[12, 0], arrayfanart[13, 3], arrayfanart[13, 2], arrayfanart[13, 0], arrayfanart[14, 3], arrayfanart[14, 2], arrayfanart[14, 0]);
            string bbtemp = File.ReadAllText(Application.StartupPath + "/bbtemplate.txt");
            string bbfinal = String.Format(bbtemp, tabledit);
            Clipboard.SetText(bbfinal);
            MessageBox.Show("BBCode generated! Sent to your clipboard.");
        }
        public string colorcode(string media)
        {
            if(media=="Atelier 801")
            {
                return "@009D9D";
            }
            else if (media == "Deviantart")
            {
                return "@05CC47";
            }
            else if (media == "Instagram")
            {
                return "@FF69B4";
            }
            else if (media == "Reddit")
            {
                return "@FE6831";
            }
            else if (media == "Steam")
            {
                return "@26A4E0";
            }
            else if (media == "Tumblr")
            {
                return "@456FAD";
            }
            else if (media == "Twitter")
            {
                return "@1DA1F2";
            }
            else
            {
                return "@009D9D";
            }



        }
        public string mediaicon(string media)
        {
            if (media == "Atelier 801")
            {
                return "https://www.transformice.com/images/x_transformice/x_divers/a801.png";
            }
            else if (media == "Deviantart")
            {
                return "https://www.transformice.com/images/x_transformice/x_divers/deviantart.png";
            }
            else if (media == "Instagram")
            {
                return "https://www.transformice.com/images/x_transformice/x_divers/instagram.png";
            }
            else if (media == "Reddit")
            {
                return "https://i.imgur.com/TlTRhQY.png";
            }
            else if (media == "Steam")
            {
                return "https://i.imgur.com/TcshcED.png";
            }
            else if (media == "Tumblr")
            {
                return "https://www.transformice.com/images/x_transformice/x_divers/tumblr.png";
            }
            else if (media == "Twitter")
            {
                return "https://www.transformice.com/images/x_transformice/x_divers/twitter.png";
            }
            else
            {
                return "https://www.transformice.com/images/x_transformice/x_divers/a801.png";
            }



        }
        public string formatnick(string nick, string media)
        {

            
            
            if (media=="Atelier 801")
            {
                nick = nick.Replace("[/b]", "");
                nick = nick.Replace("#", "[/b][size=10]#");
                nick = nick.Replace("@", "#");
                nick += "[/size]";
                nick = String.Format("[img]https://www.transformice.com/images/x_transformice/x_divers/a801.png[/img] [color=#009D9D][b]{0}[/color]", nick);
            }
            else
            {
                nick = String.Format("[img]{0}[/img] [color={1}][b]{2}[/b][/color]", mediaicon(media), colorcode(media), nick);
                nick = nick.Replace("@", "#");
            }
            

            return nick;
        }

        private void mediapv_Click(object sender, EventArgs e)
        {

        }
    }
}
