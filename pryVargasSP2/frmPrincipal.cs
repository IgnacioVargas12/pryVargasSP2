namespace pryVargasSP2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Declaración variables
        double CostoFinal = 0;
        double CostoDiario = 0;
        double CantidadPersonas = 0;
        double CostoAdicional = 0;
        int Indice = 0;
        string auxCocina = "";
        string auxHeladera = "";
        string auxTelevisor = "";
        string auxEfectivo = "";

        //Declaración de struct
        public struct Datos 
        {
            public string TipoCabaña;
            public double CostoFinal;
            public int CantidadDias;
            public double CantidadPersonas;
            public string FormaDePago;
            public string Nombre;
            public double Telefono;
            public string Adicionales;
        }

        //Declaración array
        public Datos[] vecDatos = new Datos[20];

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void cmbCabaña_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCabaña.SelectedIndex == 0)
            {
                nudPersonas.Maximum = 4;
            }
            else
            {
                nudPersonas.Maximum = 8;
            }
        }

        private void btnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
            {
                cmbTarjeta.Enabled = true;
                cmbTarjeta.SelectedIndex = 0;
            }
            else
            {
                cmbTarjeta.Enabled = false;
                cmbTarjeta.SelectedIndex = -1;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtTelefono.Enabled = true;
            }
            else
            {
                txtTelefono.Enabled = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbCabaña.SelectedIndex == 0)
            {
                CostoDiario = 20;
                CantidadPersonas = Convert.ToInt32(nudPersonas.Value);
                CalcularAdicional();
                if (optEfectivo.Checked == true)
                {
                    CostoFinal = (CostoDiario + (CantidadPersonas * 1) + CostoAdicional) * Convert.ToInt32(nudDias.Value);
                    auxEfectivo = "Efectivo";
                }
                if (optTarjeta.Checked == true)
                {
                    if (cmbTarjeta.SelectedIndex == 0)
                    {
                        CostoFinal = ((CostoDiario + (CantidadPersonas * 1) + CostoAdicional) * Convert.ToInt32(nudDias.Value)) * 1.1;
                    }
                    else
                    {
                        CostoFinal = ((CostoDiario + (CantidadPersonas * 1) + CostoAdicional) * Convert.ToInt32(nudDias.Value)) * 1.2;
                    }

                }
                MessageBox.Show("El precio final es " + "$" + CostoFinal, "Precio final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cmbCabaña.SelectedIndex == 1)
            {
                CostoDiario = 34;
                CantidadPersonas = Convert.ToInt32(nudPersonas.Value);
                CalcularAdicional();
                if (optEfectivo.Checked == true)
                {
                    CostoFinal = (CostoDiario + (CantidadPersonas * 1) + CostoAdicional) * Convert.ToInt32(nudDias.Value);
                }
                if (optTarjeta.Checked == true)
                {
                    if (cmbTarjeta.SelectedIndex == 0)
                    {
                        CostoFinal = ((CostoDiario + (CantidadPersonas * 1) + CostoAdicional) * Convert.ToInt32(nudDias.Value)) * 1.1;
                    }
                    else
                    {
                        CostoFinal = ((CostoDiario + (CantidadPersonas * 1) + CostoAdicional) * Convert.ToInt32(nudDias.Value)) * 1.2;
                    }

                }
                MessageBox.Show("El precio final es " + "$" + CostoFinal, "Precio final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Indice < 20)
            {
                //Grabamos los datos en el array
                vecDatos[Indice].TipoCabaña = cmbCabaña.Text;
                vecDatos[Indice].CantidadPersonas = CantidadPersonas;
                vecDatos[Indice].CantidadDias = Convert.ToInt32(nudDias.Value);
                vecDatos[Indice].Adicionales = auxCocina + " " + auxHeladera + " " + auxTelevisor;
                vecDatos[Indice].FormaDePago = auxEfectivo + " " + cmbTarjeta.Text;
                vecDatos[Indice].CostoFinal = CostoFinal;
                vecDatos[Indice].Nombre = txtNombre.Text;
                vecDatos[Indice].Telefono = Convert.ToDouble(txtTelefono.Text);
                Indice++;
            }
            else
            {
                MessageBox.Show("El array se encuentra lleno", "Array lleno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAceptar.Enabled = false;
            }

                //Limpiamos controles y variables
                Inicio();
        }

        private void CalcularAdicional()
        {
            if (chkCocina.Checked == true)
            {
                CostoAdicional += 1;
                auxCocina = "Cocina";
            }
            if (chkHeladera.Checked == true)
            {
                CostoAdicional += 1.50;
                auxHeladera = "Heladera";
            }
            if (chkTelevisor.Checked == true)
            {
                CostoAdicional += 2;
                auxTelevisor = "Televisor";
            }
        }

        private void Inicio()
        {
            //Deshabilitamos el cmbTarjeta
            cmbTarjeta.Enabled = false;

            //Seleccionamos desde el inicio la cabaña A
            cmbCabaña.SelectedIndex = 0;

            //Seleccionamos desde el inicio la opción efectivo
            optEfectivo.Checked = true;

            //Dejamos el focus en cmbCabaña
            cmbCabaña.Focus();

            //Limpiamos controles
            nudDias.Value = 1;
            nudPersonas.Value = 1;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            chkCocina.Checked = false;

            //Limpiamos las variables
            CostoFinal = 0;
            CostoDiario = 0;
            CantidadPersonas = 0;
            CostoAdicional = 0;
            auxTelevisor = "";
            auxHeladera = "";
            auxCocina = "";
            auxEfectivo = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiamos controles
            nudDias.Value = 1;
            nudPersonas.Value = 1;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            chkCocina.Checked = false;

            //Limpiamos las variables
            CostoFinal = 0;
            CostoDiario = 0;
            CantidadPersonas = 0;
            CostoAdicional = 0;
        }
    }
}
