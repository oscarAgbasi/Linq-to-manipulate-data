/*
  Program: Sample.cs
  Author:  agbasi oscar
  Date:    december 7th, 2018
 
  Purpose: This program demonstrates some of the common capabilities of the Graphics object
           as well as how to properly use them.
*/

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

namespace Lab5b
{
    public partial class Form1 : Form
    {
        String str = "";
        String temp;
        int NumberOfDoctor = 0;


        List<Doctor> doctors = new List<Doctor>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Doctor> doctors = new List<Doctor>();
            List<Companion> companions = new List<Companion>();
            List<Episode> episodes = new List<Episode>();

            // Displays an OpenFileDialog so the user can select a Text.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a Text File";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a .Text file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog1.OpenFile()) != null)
                    {
                        System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);

                        str = sr.ReadToEnd();

                        while ((str = sr.ReadLine()) != null)
                        {
                            String[] entries = str.Split('|');
                            //Condition to group into either "Doctor", "Episode","Companion"
                            if (entries[0] == "E")
                            {

                                episodes.Add(new Episode(entries[1], Convert.ToInt32(entries[2]), Convert.ToInt32(entries[3]), entries[4]));

                            }
                            else if (entries[0] == "C")
                            {

                                companions.Add(new Companion(entries[1], entries[2], Convert.ToInt32(entries[3]), entries[4]));
                            }
                            else if (entries[0] == "D")
                            {
                                doctors.Add(new Doctor(Convert.ToInt32(entries[1]), entries[2], Convert.ToInt32(entries[3]), Convert.ToInt32(entries[4]), Convert.ToInt32(entries[5])));

                            }
                        }

                         var query = (from D in doctors
                                    join C in companions
                                        on D.Ordinal equals C.Doctor
                                    select new { C.Name, C.Actor, C.Debut,C.Doctor,D.Series,D.Age } into first
                                    join E in episodes on first.Debut equals E.Story
                                    select new {first.Actor, E.Title, E.Year,first.Doctor,first.Series,first.Age,first.Name }).ToList();

                        int CurrentYear = 2018;
                        int info = 0;
                        for (int i = 0; i < query.Count; i++)
                        {
                            if (query[i].Doctor == NumberOfDoctor)
                            {

                                if (query[i].Year < CurrentYear)
                                {
                                    CurrentYear = query[i].Year;
                                    info = i;

                                }
                                listBox1.Items.Add(query[i].Name.Trim()+" ("+query[i].Actor.Trim()+")");
                                listBox1.Items.Add("\"" + query[i].Title + "\"" + " (" + query[i].Year+")");
                                listBox1.Items.Add("\r\n");
                                foreach (Doctor x in doctors)
                                {
                                    if (query[i].Doctor== x.Ordinal)
                                    {
                                        textBox2.Text = x.Actor;
                                    }
                                    
                                }

                                textBox3.Text = query[i].Series.ToString();
                                textBox4.Text = query[i].Age.ToString();
                                
                            }
                            
                        }
                        textBox1.Text = CurrentYear.ToString();
                        textBox5.Text = query[info].Title;

                    }
                }
                catch (FileNotFoundException ex) {
                    MessageBox.Show("The file not available", "Problems!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    // Write the error.
                    Console.WriteLine(ex);

                } 
            }

            comboBox1.Visible = true;

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();// exit the application
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                NumberOfDoctor = 1;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                NumberOfDoctor = 2;
            }
            else if (comboBox1.Text == "Third")
            {
                NumberOfDoctor = 3;
            }
            else if (comboBox1.Text == "Fouth")
            {
                NumberOfDoctor = 4;
            }
            else if (comboBox1.Text == "Fifth")
            {
                NumberOfDoctor = 5;
            }
            else if (comboBox1.Text == "Sixth")
            {
                NumberOfDoctor = 6;
            }
            else if (comboBox1.Text == "Seventh")
            {
                NumberOfDoctor = 7;
            }
            else if (comboBox1.Text == "Eigth")
            {
                NumberOfDoctor = 8;
            }
            else if (comboBox1.Text == "Ninth")
            {
                NumberOfDoctor = 9;
            }
            else if (comboBox1.Text == "Tenth")
            {
                NumberOfDoctor = 10;
            }
            else if (comboBox1.Text == "Eleventh")
            {
                NumberOfDoctor = 11;
            }
            else
            {
                NumberOfDoctor = 12;
            }
        }
    }

   
}
