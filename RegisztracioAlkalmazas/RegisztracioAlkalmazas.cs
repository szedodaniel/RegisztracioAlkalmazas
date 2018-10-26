using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class RegisztracioAlkalmazas : Form
    {

        private bool hiba;
        private string tartalom;
        private string tartalom1;
        private string tartalom2;
        private string tartalom3;     
        private DateTime szulDatum;

        public RegisztracioAlkalmazas()
        {
            InitializeComponent();
            
            
                mentesButton.Click += (sender, e) =>
                {
                    hiba = false;



                        if (!DateTime.TryParse(this.szuldatTextBox.Text, out szulDatum))
                    {
                        MessageBox.Show("Nem megfelelő születési dátum!");
                        hiba = true;

                    }
                    else
                    {
                        tartalom3 = szulDatum.ToString("yyyy-MM-dd");
                    }
                   
                    

                    if (hobbiListBox.SelectedIndex == -1)
                    {
                        hiba = true;
                        MessageBox.Show("Nem választottál hobbit");
                    }
                    else
                    {

                        tartalom1 = hobbiListBox.SelectedItem.ToString();
                        
                    }


                    if (hiba != true)
                    {
                        Mentes();
                    }
                    

                };
            
           
            betoltButton.Click += (sender, e) =>
            {
                Megnyitas();
            };
        }
        
        private void Mentes()
        {
            
            tartalom = hobbiListBox.Items.ToString();
            
            tartalom2 = nevTextBox.Text;
            hiba = false;



           
           

            saveFileDialog.FileName = "";
            var eredmeny = saveFileDialog.ShowDialog(this);
        
                if (eredmeny == DialogResult.OK)
                {
                    string fileNev = saveFileDialog.FileName;

                    string hobbik = "";


                    foreach (string hobbi in hobbiListBox.Items)
                    {
                        hobbik = hobbik + hobbi + Environment.NewLine;
                    }
                    hobbik = Environment.NewLine + hobbik;



                    if (FradioButton.Checked == true)
                    {
                        File.WriteAllText(fileNev, "Név: \n" + tartalom2 + "\nSzületési Dátum:\n" + tartalom3 + "\nNem:\nFérfi\nKedvenc hobbi:\n" + tartalom1 + "\nHobbik:" + hobbik);
                        //File.WriteAllText(fileNev, tartalom2  +"\n"+ tartalom3+"\n" + tartalom1 + "\nferfi\nHobbik:" + hobbik);
                    }
                    else
                    {
                       
                        File.WriteAllText(fileNev, "Név: \n" + tartalom2 + "\nSzületési Dátum:\n" + tartalom3 + "\nNem:\nNő\nKedvenc hobbi:\n" + tartalom1 + "\nHobbik:" + hobbik);
                    //File.WriteAllText(fileNev, tartalom2 + "\n" + tartalom3 + "\n" + tartalom1 + "\nno\nHobbik:" + hobbik);

                }







                    // MessageBox.Show("Sikeres mentés");
                }
            
            
        }
        private void Megnyitas()
        {
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
               
                string[] sor = System.IO.File.ReadAllLines(openFileDialog.FileName);
               
                
                
                nevTextBox.Text = sor[1];
                szuldatTextBox.Text = sor[3];
                //ujHobbiTextBox.Text = sor[3];
                
                if (sor[5] == "Férfi")
                {
                    FradioButton.Checked = true;
                }
                else if(sor[5] == "Nő")
                {
                    NradioButton.Checked = true;
                }
                else
                {
                    MessageBox.Show("Hiba a radiobutton feltöltésekor");
                }
                hobbiListBox.Items.Clear();

                for (int i = 9; i < sor.Length; i++)
                {
                    if (sor[i] != null)
                    {
                        hobbiListBox.Items.Add(sor[i]);
                    }
                }
                hobbiListBox.SelectedItem = sor[7];



            }
           
        }


        private void HozzaAdButton_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrWhiteSpace(ujHobbiTextBox.Text))
            {
                
                MessageBox.Show("Üres az új hobbi mező");
            }
            else
            {
               
                hobbiListBox.Items.Add(ujHobbiTextBox.Text);
                ujHobbiTextBox.Clear();
            }
           
        }

    }
}
