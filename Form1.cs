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

            // Crea un nuevo paciente y agrega la hora actual como tiempo de registro
            Paciente nuevoPaciente = new Paciente(nombre, enfermedad, tipoSangre, DateTime.Now);
            pacientes.Add(nuevoPaciente);

            // Ordena la lista de pacientes por tiempo de registro
            pacientes = pacientes.OrderBy(p => p.TiempoRegistro).ToList();

            // Actualiza el ListBox con la lista de pacientes
            ActualizarListBoxPacientes();
        }
        private void ActualizarListBoxPacientes()
        {
            // Limpia el ListBox
            LBListaPacientes.Items.Clear();

            // Agrega cada paciente al ListBox
            foreach (var paciente in pacientes)
            {
                LBListaPacientes.Items.Add($"Nombre: {paciente.Nombre}, Enfermedad: {paciente.Enfermedad}, Tipo de Sangre: {paciente.TipoSangre}, Tiempo de Registro: {paciente.TiempoRegistro}");
            }
        }
    }

    public class Paciente
    {
        public string Nombre { get; }
        public string Enfermedad { get; }
        public string TipoSangre { get; }
        public DateTime TiempoRegistro { get; }

        public Paciente(string nombre, string enfermedad, string tipoSangre, DateTime tiempoRegistro)
        {
            
            Nombre = nombre;
            Enfermedad = enfermedad;
            TipoSangre = tipoSangre;
            TiempoRegistro = tiempoRegistro;
        }
    }
}
    

