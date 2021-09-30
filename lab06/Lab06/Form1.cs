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

namespace Lab06
{
    public partial class ManPerson : Form
    {
        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();

        public ManPerson()
        {
            InitializeComponent();
        }

        private void ManPerson_Load(object sender, EventArgs e)
        {
            String str = "Server=DESKTOP-LMO2I3Q\\LOCAL;Database=School;Integrated Security=true";
            con = new SqlConnection(str);
            con.Open();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            ds = new DataSet();
            adapter.Fill(ds, "Person");
            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertPerson", con);
            
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            DataRow fila = tablePerson.NewRow();
            fila["FirstName"] = txtFirstName.Text;
            fila["LastName"] = txtLastName.Text;

            if (txtHireDate.Checked == true)
                fila["HireDate"] = txtHireDate.Text;

            if (txtEnrollmentDate.Checked == true)
                fila["EnrollmentDate"] = txtEnrollmentDate.Text;

            tablePerson.Rows.Add(fila);
            adapter.Update(tablePerson);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string sp = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            
            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID='" + txtPersonID.Text + "'");
            fila[0]["FirstName"] = txtFirstName.Text;
            fila[0]["LastName"] = txtLastName.Text;
            if (txtHireDate.Checked == true)
                fila[0]["HireDate"] = txtHireDate.Text;
            if (txtEnrollmentDate.Checked == true)
                fila[0]["EnrollmentDate"] = txtEnrollmentDate.Text;

            adapter.Update(tablePerson);
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                String hireDate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hireDate))
                    txtHireDate.Checked = false;
                else
                    txtHireDate.Text = hireDate;

                String enrollmentDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(enrollmentDate))
                    txtEnrollmentDate.Checked = false;
                else
                    txtEnrollmentDate.Text = enrollmentDate;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sp = "DeletePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.Parameters.Add("@PersonID", SqlDbType.Int).SourceColumn = "PersonID";

            //cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID=" + txtPersonID.Text + "");
            
            tablePerson.Rows.Remove(fila[0]);
            adapter.Update(tablePerson);
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            String sp = "BuscarPersonaCodigo";
            SqlCommand cmd = new SqlCommand(sp, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@PersonID", txtPersonID.Text);

            ds = new DataSet();
            adapter.Fill(ds, "Person");
            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();

        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            String sp = "BuscarPersonaNombre";
            SqlCommand cmd = new SqlCommand(sp, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);

            ds = new DataSet();
            adapter.Fill(ds, "Person");
            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            String sp = "BuscarPersonaApellido";
            SqlCommand cmd = new SqlCommand(sp, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);

            ds = new DataSet();
            adapter.Fill(ds, "Person");
            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
        }

        private void btnBuscarContrato_Click(object sender, EventArgs e)
        {
            String sp = "BuscarPersonaContrato";
            SqlCommand cmd = new SqlCommand(sp, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@HireDate", Convert.ToDateTime(txtHireDate.Text));


            ds = new DataSet();
            adapter.Fill(ds, "Person");
            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
        }

        private void btnBuscarInscripcion_Click(object sender, EventArgs e)
        {
            String sp = "BuscarPersonaInscripcion";
            SqlCommand cmd = new SqlCommand(sp, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@EnrollmentDate", Convert.ToDateTime(txtEnrollmentDate.Text));

            ds = new DataSet();
            adapter.Fill(ds, "Person");
            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
        }
    }
}
