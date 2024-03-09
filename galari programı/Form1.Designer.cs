namespace galari_programı
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.marka = new System.Windows.Forms.ComboBox();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.ğ = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.renk = new System.Windows.Forms.TextBox();
            this.yakittipi = new System.Windows.Forms.TextBox();
            this.kasa = new System.Windows.Forms.TextBox();
            this.modelyili = new System.Windows.Forms.TextBox();
            this.durumu = new System.Windows.Forms.TextBox();
            this.vites = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.resimyükle = new System.Windows.Forms.Button();
            this.aekle = new System.Windows.Forms.Button();
            this.agüncelle = new System.Windows.Forms.Button();
            this.asil = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.aresim = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.aresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marka
            // 
            this.marka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.marka.FormattingEnabled = true;
            this.marka.Items.AddRange(new object[] {
            "wolswagen",
            "skoda",
            "renault",
            "opel",
            "mercedes",
            "bmv",
            "range-rover",
            "tofaş",
            "kia",
            "hyundai",
            "seat",
            "fıat",
            "mazda",
            "toyoto\t",
            "audi",
            "volvo",
            "cıtroen",
            "ısızu",
            "subaru",
            "minicopper"});
            this.marka.Location = new System.Drawing.Point(133, 114);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(127, 21);
            this.marka.TabIndex = 0;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a.Location = new System.Drawing.Point(15, 118);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(47, 17);
            this.a.TabIndex = 2;
            this.a.Text = "marka";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b.Location = new System.Drawing.Point(15, 155);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(46, 17);
            this.b.TabIndex = 3;
            this.b.Text = "model";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.c.Location = new System.Drawing.Point(15, 194);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(34, 17);
            this.c.TabIndex = 5;
            this.c.Text = "fiyat";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.g.Location = new System.Drawing.Point(15, 233);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(38, 17);
            this.g.TabIndex = 7;
            this.g.Text = "kasa";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.d.Location = new System.Drawing.Point(13, 280);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(36, 17);
            this.d.TabIndex = 9;
            this.d.Text = "renk";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f.ForeColor = System.Drawing.Color.Black;
            this.f.Location = new System.Drawing.Point(11, 323);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(37, 17);
            this.f.TabIndex = 10;
            this.f.Text = "vites";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.e.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.e.Location = new System.Drawing.Point(266, 76);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(59, 17);
            this.e.TabIndex = 12;
            this.e.Text = "yakıt tipi";
            // 
            // ğ
            // 
            this.ğ.AutoSize = true;
            this.ğ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ğ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ğ.Location = new System.Drawing.Point(266, 114);
            this.ğ.Name = "ğ";
            this.ğ.Size = new System.Drawing.Size(66, 17);
            this.ğ.TabIndex = 14;
            this.ğ.Text = "model yılı";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.h.Location = new System.Drawing.Point(266, 154);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(56, 17);
            this.h.TabIndex = 16;
            this.h.Text = "durumu";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.s.Location = new System.Drawing.Point(266, 194);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(42, 17);
            this.s.TabIndex = 18;
            this.s.Text = "resim";
            // 
            // model
            // 
            this.model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.model.Location = new System.Drawing.Point(135, 154);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(125, 20);
            this.model.TabIndex = 21;
            // 
            // fiyat
            // 
            this.fiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fiyat.Location = new System.Drawing.Point(133, 194);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(125, 20);
            this.fiyat.TabIndex = 22;
            // 
            // renk
            // 
            this.renk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.renk.Location = new System.Drawing.Point(133, 277);
            this.renk.Name = "renk";
            this.renk.Size = new System.Drawing.Size(125, 20);
            this.renk.TabIndex = 23;
            // 
            // yakittipi
            // 
            this.yakittipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.yakittipi.Location = new System.Drawing.Point(343, 79);
            this.yakittipi.Name = "yakittipi";
            this.yakittipi.Size = new System.Drawing.Size(216, 20);
            this.yakittipi.TabIndex = 24;
            // 
            // kasa
            // 
            this.kasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kasa.Location = new System.Drawing.Point(133, 233);
            this.kasa.Name = "kasa";
            this.kasa.Size = new System.Drawing.Size(125, 20);
            this.kasa.TabIndex = 25;
            // 
            // modelyili
            // 
            this.modelyili.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modelyili.Location = new System.Drawing.Point(343, 114);
            this.modelyili.Name = "modelyili";
            this.modelyili.Size = new System.Drawing.Size(216, 20);
            this.modelyili.TabIndex = 26;
            this.modelyili.TextChanged += new System.EventHandler(this.modelyili_TextChanged);
            // 
            // durumu
            // 
            this.durumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.durumu.Location = new System.Drawing.Point(343, 154);
            this.durumu.Name = "durumu";
            this.durumu.Size = new System.Drawing.Size(216, 20);
            this.durumu.TabIndex = 27;
            // 
            // vites
            // 
            this.vites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.vites.Location = new System.Drawing.Point(133, 320);
            this.vites.Name = "vites";
            this.vites.Size = new System.Drawing.Size(125, 20);
            this.vites.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(29, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(566, 41);
            this.label12.TabIndex = 35;
            this.label12.Text = "-------araç galeri programı-------";
            // 
            // resimyükle
            // 
            this.resimyükle.BackColor = System.Drawing.Color.Transparent;
            this.resimyükle.BackgroundImage = global::galari_programı.Properties.Resources.images__4_;
            this.resimyükle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimyükle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resimyükle.Location = new System.Drawing.Point(574, 249);
            this.resimyükle.Name = "resimyükle";
            this.resimyükle.Size = new System.Drawing.Size(51, 48);
            this.resimyükle.TabIndex = 34;
            this.resimyükle.UseVisualStyleBackColor = false;
            this.resimyükle.Click += new System.EventHandler(this.resimyükle_Click);
            // 
            // aekle
            // 
            this.aekle.BackColor = System.Drawing.Color.Transparent;
            this.aekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aekle.BackgroundImage")));
            this.aekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.aekle.Location = new System.Drawing.Point(574, 303);
            this.aekle.Name = "aekle";
            this.aekle.Size = new System.Drawing.Size(51, 52);
            this.aekle.TabIndex = 33;
            this.aekle.UseVisualStyleBackColor = false;
            this.aekle.Click += new System.EventHandler(this.aekle_Click_1);
            // 
            // agüncelle
            // 
            this.agüncelle.BackColor = System.Drawing.Color.Transparent;
            this.agüncelle.BackgroundImage = global::galari_programı.Properties.Resources.images__1_2;
            this.agüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.agüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.agüncelle.Location = new System.Drawing.Point(574, 194);
            this.agüncelle.Name = "agüncelle";
            this.agüncelle.Size = new System.Drawing.Size(51, 49);
            this.agüncelle.TabIndex = 32;
            this.agüncelle.UseVisualStyleBackColor = false;
            this.agüncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // asil
            // 
            this.asil.BackColor = System.Drawing.Color.Transparent;
            this.asil.BackgroundImage = global::galari_programı.Properties.Resources.indir1;
            this.asil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.asil.Location = new System.Drawing.Point(574, 79);
            this.asil.Name = "asil";
            this.asil.Size = new System.Drawing.Size(51, 54);
            this.asil.TabIndex = 31;
            this.asil.UseVisualStyleBackColor = false;
            this.asil.Click += new System.EventHandler(this.button2_Click);
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.Transparent;
            this.ara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ara.BackgroundImage")));
            this.ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ara.Location = new System.Drawing.Point(574, 136);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(51, 55);
            this.ara.TabIndex = 30;
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.aekle_Click);
            // 
            // aresim
            // 
            this.aresim.BackColor = System.Drawing.Color.OrangeRed;
            this.aresim.Location = new System.Drawing.Point(314, 180);
            this.aresim.Name = "aresim";
            this.aresim.Size = new System.Drawing.Size(245, 168);
            this.aresim.TabIndex = 29;
            this.aresim.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sno
            // 
            this.sno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sno.Location = new System.Drawing.Point(133, 73);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(125, 20);
            this.sno.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 51);
            this.label1.TabIndex = 37;
            this.label1.Text = "s_no(silenecek ,\r\naranacak \r\nburaya yazılacak)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 166);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(639, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.resimyükle);
            this.Controls.Add(this.aekle);
            this.Controls.Add(this.agüncelle);
            this.Controls.Add(this.asil);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.aresim);
            this.Controls.Add(this.vites);
            this.Controls.Add(this.durumu);
            this.Controls.Add(this.modelyili);
            this.Controls.Add(this.kasa);
            this.Controls.Add(this.yakittipi);
            this.Controls.Add(this.renk);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.model);
            this.Controls.Add(this.s);
            this.Controls.Add(this.h);
            this.Controls.Add(this.ğ);
            this.Controls.Add(this.e);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.g);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.marka);
            this.Name = "Form1";
            this.Text = "5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label ğ;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.TextBox renk;
        private System.Windows.Forms.TextBox yakittipi;
        private System.Windows.Forms.TextBox kasa;
        private System.Windows.Forms.TextBox modelyili;
        private System.Windows.Forms.TextBox durumu;
        private System.Windows.Forms.TextBox vites;
        private System.Windows.Forms.PictureBox aresim;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button asil;
        private System.Windows.Forms.Button agüncelle;
        private System.Windows.Forms.Button aekle;
        private System.Windows.Forms.Button resimyükle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox sno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

