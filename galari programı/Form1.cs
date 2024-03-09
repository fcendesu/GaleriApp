using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace galari_programı
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=galari.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }




        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from arac", baglanti);
            adtr.Fill(ds, "arac");
            dataGridView1.DataSource = ds.Tables["arac"];
            adtr.Dispose();
            baglanti.Close();
        }
        //kayıt sil
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete from arac where s_no=" + sno.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                ds.Clear();
                listele();
            }
        }
        
           
            
        

        //arac güncelle
        private void button3_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update arac set marka='" + marka.Text + "', model='" + model.Text + "', fiyat='" + fiyat.Text + "', kasa='" + kasa.Text + "', renk='" + renk.Text + "', vites='" + vites.Text + "', y_tipi='" + yakittipi.Text + "', m_yili='" + modelyili.Text + "', durumu='" + durumu.Text + "', resim='" + aresim.ImageLocation + "' where s_no=" + sno.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Clear();
            listele();
        }
            
        
    

        
        //acces teki kayıtları data gridewiew e atar
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();




        }
        //kayıt ara
        private void aekle_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=galari.accdb");
            adtr = new OleDbDataAdapter("SElect *from arac where s_no like '" + sno.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adtr.Fill(ds, "arac");
            dataGridView1.DataSource = ds.Tables["arac"];
            baglanti.Close();
        }
        //resim ekle
        private void resimyükle_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                aresim.ImageLocation = openFileDialog1.FileName;
                label2.Text = openFileDialog1.FileName;
                aresim.ImageLocation = openFileDialog1.FileName;
            }
        }


        //kayıt ekle
        private void aekle_Click_1(object sender, EventArgs e)
        {
            aresim.Text = aresim.ImageLocation;
            if (sno.Text != "" && marka.Text != "" && model.Text != "" && fiyat.Text != "" && kasa.Text != "" && renk.Text != "" && vites.Text != "" && yakittipi.Text != "" && modelyili.Text != "" && durumu.Text != "" && aresim.ImageLocation != "")
            {
                komut.Connection = baglanti;
                komut.CommandText = "Insert Into arac (s_no,marka,model,fiyat,kasa,renk,vites,y_tipi,m_yili,durumu,resim) Values ('" + sno.Text + "','" + marka.Text + "','" + model.Text + "','" + fiyat.Text + "','" + kasa.Text + "','" + renk.Text + "','" + vites.Text + "','" + yakittipi.Text + "','" + modelyili.Text + "','" + durumu.Text + "','" + aresim.ImageLocation + "')";
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Tamamlandı!");
                ds.Clear();
                listele();
            }
            else
            {
                MessageBox.Show("Boş alan geçmeyiniz!");
            }
        }
        //data gridwiew den texboxlara atar
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void modelyili_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            sno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kasa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            renk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            vites.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            yakittipi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            modelyili.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            durumu.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            aresim.ImageLocation = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

    }
}
          
            
        
        
    
            
        
    

            
        
    
    
        
    

    


