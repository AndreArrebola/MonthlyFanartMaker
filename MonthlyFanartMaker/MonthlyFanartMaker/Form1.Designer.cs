namespace MonthlyFanartMaker
{
    partial class Maker
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maker));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tx_tag = new System.Windows.Forms.TextBox();
            this.mediapv = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_link = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_imgprev = new System.Windows.Forms.Button();
            this.picprev = new System.Windows.Forms.PictureBox();
            this.tx_thumb = new System.Windows.Forms.TextBox();
            this.media_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_nick = new System.Windows.Forms.TextBox();
            this.table_fanarts = new System.Windows.Forms.DataGridView();
            this.btn_go = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Fanart = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Media = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Thumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediapv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picprev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_fanarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tx_tag);
            this.panel1.Controls.Add(this.mediapv);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tx_link);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_imgprev);
            this.panel1.Controls.Add(this.picprev);
            this.panel1.Controls.Add(this.tx_thumb);
            this.panel1.Controls.Add(this.media_box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tx_nick);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 239);
            this.panel1.TabIndex = 0;
            // 
            // tx_tag
            // 
            this.tx_tag.Location = new System.Drawing.Point(323, 74);
            this.tx_tag.MaxLength = 4;
            this.tx_tag.Name = "tx_tag";
            this.tx_tag.Size = new System.Drawing.Size(75, 20);
            this.tx_tag.TabIndex = 13;
            this.tx_tag.Visible = false;
            this.tx_tag.TextChanged += new System.EventHandler(this.Tx_tag_TextChanged);
            // 
            // mediapv
            // 
            this.mediapv.Location = new System.Drawing.Point(405, 36);
            this.mediapv.Name = "mediapv";
            this.mediapv.Size = new System.Drawing.Size(21, 21);
            this.mediapv.TabIndex = 12;
            this.mediapv.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(182, 194);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(121, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Link";
            // 
            // tx_link
            // 
            this.tx_link.Location = new System.Drawing.Point(196, 147);
            this.tx_link.Name = "tx_link";
            this.tx_link.Size = new System.Drawing.Size(202, 20);
            this.tx_link.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(121, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thumb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(121, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(121, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Media";
            // 
            // btn_imgprev
            // 
            this.btn_imgprev.Location = new System.Drawing.Point(323, 109);
            this.btn_imgprev.Name = "btn_imgprev";
            this.btn_imgprev.Size = new System.Drawing.Size(75, 23);
            this.btn_imgprev.TabIndex = 8;
            this.btn_imgprev.Text = "Preview";
            this.btn_imgprev.UseVisualStyleBackColor = true;
            this.btn_imgprev.Click += new System.EventHandler(this.Button1_Click);
            // 
            // picprev
            // 
            this.picprev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picprev.Location = new System.Drawing.Point(15, 50);
            this.picprev.Name = "picprev";
            this.picprev.Size = new System.Drawing.Size(100, 100);
            this.picprev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picprev.TabIndex = 4;
            this.picprev.TabStop = false;
            // 
            // tx_thumb
            // 
            this.tx_thumb.Location = new System.Drawing.Point(196, 111);
            this.tx_thumb.Name = "tx_thumb";
            this.tx_thumb.Size = new System.Drawing.Size(121, 20);
            this.tx_thumb.TabIndex = 4;
            this.tx_thumb.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // media_box
            // 
            this.media_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.media_box.FormattingEnabled = true;
            this.media_box.Items.AddRange(new object[] {
            "Atelier 801",
            "Deviantart",
            "Instagram",
            "Reddit",
            "Tumblr",
            "Twitter"});
            this.media_box.Location = new System.Drawing.Point(196, 36);
            this.media_box.Name = "media_box";
            this.media_box.Size = new System.Drawing.Size(202, 21);
            this.media_box.TabIndex = 0;
            this.media_box.SelectedIndexChanged += new System.EventHandler(this.media_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(179, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Fanart";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tx_nick
            // 
            this.tx_nick.Location = new System.Drawing.Point(196, 74);
            this.tx_nick.Name = "tx_nick";
            this.tx_nick.Size = new System.Drawing.Size(202, 20);
            this.tx_nick.TabIndex = 3;
            // 
            // table_fanarts
            // 
            this.table_fanarts.AllowUserToAddRows = false;
            this.table_fanarts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.table_fanarts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_fanarts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fanart,
            this.Nickname,
            this.Media,
            this.Thumb,
            this.Link,
            this.Delete,
            this.Update});
            this.table_fanarts.GridColor = System.Drawing.Color.DimGray;
            this.table_fanarts.Location = new System.Drawing.Point(477, 44);
            this.table_fanarts.Name = "table_fanarts";
            this.table_fanarts.RowTemplate.Height = 40;
            this.table_fanarts.Size = new System.Drawing.Size(655, 322);
            this.table_fanarts.TabIndex = 2;
            this.table_fanarts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_fanarts_CellContentClick);
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(351, 390);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(263, 48);
            this.btn_go.TabIndex = 7;
            this.btn_go.Text = "Generate BBCode";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.Btn_go_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::MonthlyFanartMaker.Properties.Resources.no;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Update";
            this.dataGridViewImageColumn2.Image = global::MonthlyFanartMaker.Properties.Resources.image;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MonthlyFanartMaker.Properties.Resources.Milinili_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Fanart
            // 
            this.Fanart.HeaderText = "Fanart";
            this.Fanart.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Fanart.Name = "Fanart";
            this.Fanart.ToolTipText = "Click in the image to update thumb";
            this.Fanart.Width = 40;
            // 
            // Nickname
            // 
            this.Nickname.HeaderText = "Nickname";
            this.Nickname.Name = "Nickname";
            // 
            // Media
            // 
            this.Media.HeaderText = "Media";
            this.Media.Items.AddRange(new object[] {
            "Atelier 801",
            "Deviantart",
            "Instagram",
            "Reddit",
            "Tumblr",
            "Twitter"});
            this.Media.Name = "Media";
            this.Media.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Media.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Thumb
            // 
            this.Thumb.HeaderText = "Thumb";
            this.Thumb.Name = "Thumb";
            this.Thumb.Width = 130;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Width = 130;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::MonthlyFanartMaker.Properties.Resources.no2;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 50;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Image = global::MonthlyFanartMaker.Properties.Resources.image;
            this.Update.Name = "Update";
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Width = 50;
            // 
            // Maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.table_fanarts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Maker";
            this.Text = "Monthly Fanart Maker";
            this.Load += new System.EventHandler(this.Maker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediapv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picprev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_fanarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox media_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_nick;
        private System.Windows.Forms.TextBox tx_thumb;
        private System.Windows.Forms.PictureBox picprev;
        private System.Windows.Forms.Button btn_imgprev;
        private System.Windows.Forms.PictureBox mediapv;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_link;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_tag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView table_fanarts;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Fanart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewComboBoxColumn Media;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Update;
    }
}

