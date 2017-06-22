using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pregled
{
    public partial class Form1 : Form
    {
        private Patient selectedPatient;
        private MeasureType measureType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MeasureType type = new MeasureType();
            type.Name = "Еритроцити";
            type.Min = 4;
            type.Max = 7;
            cbMeasureType.Items.Add(type);
            type = new MeasureType();
            type.Name = "Леукоцити";
            type.Min = 2000;
            type.Max = 16000;
            cbMeasureType.Items.Add(type);
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            if (patientForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lbPatients.Items.Add(patientForm.Patient);
            }
        }

        private void btnAddMeasure_Click(object sender, EventArgs e)
        {
            Measurement m = new Measurement();
            m.Type = cbMeasureType.SelectedItem as MeasureType;
            m.Value = nudMeasureValue.Value;
            selectedPatient.Measurements.Add(m);
            addMeasures();
        }

        private void lbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPatient = lbPatients.SelectedItem as Patient;
            setAddMeasureEnabled();
            addMeasures();
        }
        void setAddMeasureEnabled()
        {
            btnAddMeasure.Enabled = measureType != null && selectedPatient != null;
        }

        private void cbMeasureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            measureType = cbMeasureType.SelectedItem as MeasureType;
            if (measureType != null)
            {
                nudMeasureValue.Minimum = measureType.Min;
                nudMeasureValue.Maximum = measureType.Max;
            }
            setAddMeasureEnabled();
        }

        void addMeasures()
        {
            lbMeasures.Items.Clear();
            if (selectedPatient != null)
            {
                foreach (Measurement m in selectedPatient.Measurements)
                {
                    lbMeasures.Items.Add(m);
                }
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избиршете овој пациент?", "Избриши пациент", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    lbPatients.Items.RemoveAt(lbPatients.SelectedIndex);
                    addMeasures();
                    setAddMeasureEnabled();
                }
            }
        }


    }
}
