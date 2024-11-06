
using PSPProyecto.Data;
using PSPProyecto.Data.Entities;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PSPProyecto
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            bttCancel.Enabled = false;
            bttSave.Enabled = false;
            using (DataContext dataContext = new DataContext())
            {
                employeeBindingSource.DataSource = dataContext.Employees.ToList();
            }
            grpPersonalData.Enabled = false;
            Employee employee = employeeBindingSource.Current as Employee;
            if (employee != null && employee.Photo != null)
            {
                pctPhoto.Image = Image.FromFile(employee.Photo);
            }
            else
            {
                pctPhoto.Image = null;
            }
        }

        private void grdEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employee = employeeBindingSource.Current as Employee;
            if (employee != null && employee.Photo != null)
            {
                pctPhoto.Image = Image.FromFile(employee.Photo);
            }
            else
            {
                pctPhoto.Image = null;
            }
        }

        private void bttINew_Click(object sender, EventArgs e)
        {
            pctPhoto.Image = null;
            grpPersonalData.Enabled = true;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttINew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            grdEmployees.Enabled = false;
            employeeBindingSource.Add(new Employee());
            employeeBindingSource.MoveLast();
            txtName.Focus();
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            grpPersonalData.Enabled = true;
            bttSave.Enabled = true;
            bttCancel.Enabled = true;
            bttINew.Enabled = false;
            bttUpdate.Enabled = false;
            bttDelete.Enabled = false;
            grdEmployees.Enabled = false;
            txtName.Focus();
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            grpPersonalData.Enabled = false;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttINew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            grdEmployees.Enabled = true;
            employeeBindingSource.ResetBindings(false);
            frmEmployee_Load(sender, e);
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            grpPersonalData.Enabled = false;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttINew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            grdEmployees.Enabled = true;
            if (MessageBox.Show(this,
                "¿Quieres eliminar el registro?",
                "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DataContext dc = new DataContext())
                {
                    Employee employee = employeeBindingSource.Current as Employee;
                    if (employee != null)
                    {
                        if (dc.Entry<Employee>(employee).State == EntityState.Detached)
                        {
                            dc.Set<Employee>().Attach(employee);
                        }
                        dc.Entry<Employee>(employee).State = EntityState.Deleted;
                        dc.SaveChanges();
                        employeeBindingSource.RemoveCurrent();
                        MessageBox.Show(this, "Registro eliminado");
                        pctPhoto.Image = null;
                    }
                }
            }
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            grpPersonalData.Enabled = false;
            bttSave.Enabled = false;
            bttCancel.Enabled = false;
            bttINew.Enabled = true;
            bttUpdate.Enabled = true;
            bttDelete.Enabled = true;
            grdEmployees.Enabled = true;

            using (DataContext dc = new DataContext())
            {
                Employee employee = employeeBindingSource.Current as Employee;
                if(employee!=null)
                {
                    if (dc.Entry<Employee>(employee).State == EntityState.Detached)
                    {
                        dc.Set<Employee>().Attach(employee);
                    }
                    if (employee.Id == 0)
                    {
                        dc.Entry<Employee>(employee).State = EntityState.Added;
                    }
                    else
                    {
                        dc.Entry<Employee>(employee).State = EntityState.Modified;
                    }
                    dc.SaveChanges();
                    MessageBox.Show(this, "Registro salvado");
                    grdEmployees.Refresh();
                }
            }
        }

        private void bttLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg|PNG|*.png|ALL|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctPhoto.Image = Image.FromFile(ofd.FileName);
                    Employee employee = employeeBindingSource.Current as Employee;
                    if (employee != null)
                    {
                        employee.Photo = ofd.FileName;
                    }
                }
            }
        }

        private void frmEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
