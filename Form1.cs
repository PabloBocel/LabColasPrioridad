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

        }

        private void BTorden_Click(object sender, EventArgs e)
        {
            // Limpia el ListBox
            LBListaPacientes.Items.Clear();

            // Agrega cada paciente ordenado por prioridad al ListBox
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
            // Captura el nombre, enfermedad y tipo de sangre del formulario
            string nombre = TBnombre.Text;
            string enfermedad = CBEnfermedades.SelectedItem.ToString();
            string tipoSangre = TBSangre.Text;

            // Asigna prioridad según la enfermedad
            int prioridad = AsignarPrioridad(enfermedad);

            // Crea un nuevo paciente y agrega la hora actual como tiempo de registro
            Paciente nuevoPaciente = new Paciente(nombre, enfermedad, tipoSangre, DateTime.Now, prioridad);
            pacientes.Add(nuevoPaciente);

            // Actualiza la lista de pacientes en el ListBox
            ActualizarListaPacientes();
        }

        private int AsignarPrioridad(string enfermedad)
        {
            // Asigna prioridad según la enfermedad
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
                    return 3; // Por defecto, si no se reconoce la enfermedad, se asigna la menor prioridad
            }
        }
        private void ActualizarListaPacientes()
        {
            // Limpia el ListBox
            LBListaPacientes.Items.Clear();

            // Agrega cada paciente ordenado por registro al ListBox
            foreach (var paciente in pacientes.OrderBy(p => p.TiempoRegistro))
            {
                LBListaPacientes.Items.Add($"Nombre: {paciente.Nombre}, Enfermedad: {paciente.Enfermedad}, Tipo de Sangre: {paciente.TipoSangre}, Tiempo de Registro: {paciente.TiempoRegistro}, Prioridad: {paciente.Prioridad}");
            }
        }

        private void btnOrdenOriginal_Click(object sender, EventArgs e)
        {
            // Actualiza la lista de pacientes ordenada por registro
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
    

