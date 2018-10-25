﻿using System;
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

        public RegisztracioAlkalmazas()
        {
            InitializeComponent();
          /*  mentesButton.Click += (sender, e) =>
            {
                Mentes();
            };
            betoltButton.Click += (sender, e) =>
            {
                Megnyitas();
            };*/
        }
        private void RegisztracioAlkalmazas_Load(object sender, EventArgs e)
        {
           
           
        }
        private void Mentes()
        {
            string tartalom = hobbiListBox.Items.ToString();
            string tartalom1 = hobbiListBox.SelectedItem.ToString();
            string tartalom2 = nevTextBox.Text;
            string tartalom3 = szuldatTextBox.Text;
            string tartalom4 = NradioButton.Text;
            string tartalom5 = FradioButton.Text;
            

            saveFileDialog.FileName = "";
            var eredmeny = saveFileDialog.ShowDialog(this);

            if (eredmeny == DialogResult.OK)
            {
                string fileNev = saveFileDialog.FileName;
                /*
                using(var file = File.CreateText(fileNev))
                {
                    file.Write(tartalom);
                }*/

                /*string itemString = "";
                foreach (string item in hobbiListBox.Items)
                {
                    itemString += item.ToString();
                }

                File.WriteAllText(fileNev, itemString);*/
                string hobbik = "";

                // assume the li is a string - will fail if not
                foreach (string hobbi in hobbiListBox.Items)
                {
                    hobbik = hobbik + hobbi + Environment.NewLine;
                }
                hobbik = Environment.NewLine + hobbik;
                if (FradioButton.Checked == true)
                {
                    File.WriteAllText(fileNev, "Név: " + tartalom2 + "\nNem: Férfi\nSzületési Dátum: " + tartalom3 + "\nKedvenc hobbi: " + tartalom1 + "\n" + hobbik);
                }
                else
                {
                    File.WriteAllText(fileNev, "Név: " + tartalom2 + "\nNem: Nő\nSzületési Dátum: " + tartalom3 + "\nKedvenc hobbi: " + tartalom1 + "\n" + hobbik);

                }

               





                MessageBox.Show("Sikeres mentés");
            }
        }
        private void Megnyitas()
        {
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                hobbiListBox.Text = File.ReadAllText(openFileDialog.FileName);
                MessageBox.Show(hobbiListBox.Text);
            }
           
        }

        
       

        private void HozzaAdButton_Click(object sender, EventArgs e)
        {
            // ujHobbiTextBox.Text += hobbiListBox;
            if(ujHobbiTextBox.Text != null)
            {
                string[] kedvencHobbik = System.Text.RegularExpressions.Regex.Split(ujHobbiTextBox.Text, "\r\n");
                hobbiListBox.Items.AddRange(kedvencHobbik);
                ujHobbiTextBox.Clear();
            }
           
        }

        private void mentesButton_Click(object sender, EventArgs e)
        {
            Mentes();
        }

        private void betoltButton_Click(object sender, EventArgs e)
        {
            Megnyitas();
        }

        
    }
}