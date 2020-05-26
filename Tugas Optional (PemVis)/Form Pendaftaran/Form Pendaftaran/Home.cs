using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace Form_Pendaftaran
{
    public partial class Home : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-JF1CBKCQ;Initial Catalog=form_mahasiswa;Integrated Security=True");
        public Home()
        {
            InitializeComponent();
        }
        string Jenis_kelamin;
        string imglocation = "";
        SqlCommand cmd;

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length); 
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Form](NIM,Nama,Tempat_lahir,Tanggal_lahir,No_telepon,Jurusan,Jenis_kelamin,Alamat,Foto) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+dateTimePicker1.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+Jenis_kelamin+"','"+textBox6.Text+"',@images)";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.ImageLocation = null;
            tampilkandata();
            MessageBox.Show("Data Telah Berhasil Di Input");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Jenis_kelamin = "Pria";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Jenis_kelamin = "Wanita";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }
        public void tampilkandata()
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Form]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            tampilkandata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Form] where NIM ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            textBox1.Text = "";
            tampilkandata();
            MessageBox.Show("Data Berhasil Di Hapus");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream); ;
            images = brs.ReadBytes((int)stream.Length);
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Form] set NIM ='"+this.textBox1.Text+"',Nama ='"+this.textBox2.Text+"',Tempat_lahir ='"+this.textBox3.Text+"',Tanggal_lahir ='"+this.dateTimePicker1.Text+"',No_telepon ='"+this.textBox4.Text+"',Jurusan ='"+this.textBox5.Text+"',Jenis_kelamin ='"+Jenis_kelamin+"',Alamat ='"+this.textBox6.Text+"',Foto=@images where NIM ='"+this.textBox1.Text+"'";
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            koneksi.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.ImageLocation = null;
            tampilkandata();
            MessageBox.Show("Data Telah Berhasil Di Update");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Form] where NIM ='" + textBox7.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
            textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.ImageLocation = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
