﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            
            var values=db.Guide.ToList();
            dataGridView1.DataSource= values;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guide guide=new Guide();
            guide.GuideName=txtName.Text;
            guide.GuideSurname=txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var removevalue=db.Guide.Find(id);
            db.Guide.Remove(removevalue);
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatevalue = db.Guide.Find(id);
            updatevalue.GuideName = txtName.Text;
            updatevalue.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Başarıyla Güncellendi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btngetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
