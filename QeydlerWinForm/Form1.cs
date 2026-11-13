using System;
using System.IO;
using System.Windows.Forms;

namespace QeydlerWinForms
{
    public partial class Form1 : Form
    {
        string filePath = "qeydler.txt";

        public Form1()
        {
            InitializeComponent();
            QeydleriEkranaYukle(); 

        }

        
        private void btnYeniQeyd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtQeyd.Text))
                {
                    MessageBox.Show("Zəhmət olmasa qeyd daxil edin!");
                    return;
                }

                
                string setir = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {txtQeyd.Text}";

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(setir);
                }

                MessageBox.Show("Qeyd uğurla əlavə olundu!");
                txtQeyd.Clear();
                QeydleriEkranaYukle(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xəta baş verdi: {ex.Message}");
            }
        }

       
        private void QeydleriEkranaYukle()
        {
            listBoxQeydler.Items.Clear();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBoxQeydler.Items.Add(line);
                    }
                }
            }
        }

      
        private void btnAxtar_Click(object sender, EventArgs e)
        {
            try
            {
                string acarSoz = txtAcarSoz.Text.Trim();
                if (string.IsNullOrEmpty(acarSoz))
                {
                    QeydleriEkranaYukle();
                    return;
                }

                if (File.Exists(filePath))
                {
                    listBoxQeydler.Items.Clear();
                    bool tapildi = false;

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            

                            if (line.ToLower().Contains(acarSoz.ToLower()))
                            {
                                listBoxQeydler.Items.Add(line);
                                tapildi = true;
                            }
                        }
                    }

                    if (!tapildi)
                    {
                        MessageBox.Show("Uyğun qeyd tapılmadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Fayl hələ mövcud deyil.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xəta baş verdi: {ex.Message}");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
               
                DialogResult cavab = MessageBox.Show("Bütün qeydlər silinsin?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cavab == DialogResult.Yes)
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        listBoxQeydler.Items.Clear();
                        MessageBox.Show("Bütün qeydlər silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Silinəcək fayl yoxdur.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xəta baş verdi: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxQeydler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}