using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabColasPrioridad
{
    public partial class Form1 : Form
    {
        private List<Paciente> pacientes = new List<Paciente>();

        public Form1()
        {
            InitializeComponent();
            CBEnfermedades.Items.Add("Fiebre alta");
            CBEnfermedades.Items.Add("Fractura expuesta");
            CBEnfermedades.Items.Add("Intoxicación");
            CBEnfermedades.Items.Add("Dolor de oído");
            CBEnfermedades.Items.Add("Problema cardiaco");
        }

        private void BTsiguiente_Click(object sender, EventArgs e)
        {
            if (pacientes.Count > 0)
            {
                Paciente siguientePaciente = pacientes.OrderBy(p => p.Prioridad).First();

                MessageBox.Show($"Siguiente paciente a atender:\n\nNombre: {siguientePaciente.Nombre}\nEnfermedad: {siguientePaciente.Enfermedad}\nTipo de Sangre: {siguientePaciente.TipoSangre}\nPrioridad: {siguientePaciente.Prioridad}");

                pacientes.Remove(siguientePaciente);

                ActualizarListaPacientes();
            }
            else
            {
                MessageBox.Show("No hay pacientes en la lista.");
            }
        }

        private void BTorden_Click(object sender, EventArgs e)
        {
            LBListaPacientes.Items.Clear();

            foreach (var paciente in pacientes.OrderBy(p => p.Prioridad))
            {
                LBListaPacientes.Items.Add($"Nombre: {paciente.Nombre}, Enfermedad: {paciente.Enfermedad}, Tipo de Sangre: {paciente.TipoSangre}, Tiempo de Registro: {paciente.TiempoRegistro}, Prioridad: {paciente.Prioridad}");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = TBnombre.Text;
            string enfermedad = CBEnfermedades.SelectedItem.ToString();
            string tipoSangre = TBSangre.Text;

            int prioridad = AsignarPrioridad(enfermedad);

            Paciente nuevoPaciente = new Paciente(nombre, enfermedad, tipoSangre, DateTime.Now, prioridad);
            pacientes.Add(nuevoPaciente);

            ActualizarListaPacientes();
        }

        private int AsignarPrioridad(string enfermedad)
        {
            switch (enfermedad)
            {
                case "Fiebre alta":
                    return 3;
                case "Fractura expuesta":
                case "Intoxicación":
                case "Dolor de oído":
                    return 2;
                case "Problema cardiaco":
                    return 1;
                default:
                    return 3; 
            }
        }
        private void ActualizarListaPacientes()
        {
            LBListaPacientes.Items.Clear();

            foreach (var paciente in pacientes.OrderBy(p => p.TiempoRegistro))
            {
                LBListaPacientes.Items.Add($"Nombre: {paciente.Nombre}, Enfermedad: {paciente.Enfermedad}, Tipo de Sangre: {paciente.TipoSangre}, Tiempo de Registro: {paciente.TiempoRegistro}, Prioridad: {paciente.Prioridad}");
            }
        }

        private void btnOrdenOriginal_Click(object sender, EventArgs e)
        {
            ActualizarListaPacientes();
        }
    }

    public class Paciente
    {
        public string Nombre { get; }
        public string Enfermedad { get; }
        public string TipoSangre { get; }
        public DateTime TiempoRegistro { get; }
        public int Prioridad { get; }

        public Paciente(string nombre, string enfermedad, string tipoSangre, DateTime tiempoRegistro, int prioridad)
        {
            Nombre = nombre;
            Enfermedad = enfermedad;
            TipoSangre = tipoSangre;
            TiempoRegistro = tiempoRegistro;
            Prioridad = prioridad;
        }
    }
}
    

