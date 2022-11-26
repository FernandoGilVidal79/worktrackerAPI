﻿using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class CreacionUsuarios : Form
    {

        private bool edicion = false;
        private readonly IForm _form;

        public CreacionUsuarios (IForm form)
        {
            _form = form;
            InitializeComponent();
        }

        private void CreacionUsuarios_Load(object sender, EventArgs e)
        {
            ActivarCampos(false);
            CargarTipoUsuarios();
            ActivarBotones(true);
        }

        private void ActivarCampos(bool status)
        {
            txtNumEmpleado.Enabled      = !status;
            txtNombre.Enabled           = status;
            txtApellido1.Enabled        = status;
            txtApellido2.Enabled        = status;
            txtContrasena.Enabled       = status;
            txtDepartamento.Enabled     = status;
            txtEmail.Enabled            = status;
            txtTelefono.Enabled         = status;
            txtNumVacaciones.Enabled    = status;
            cmbStatus.Enabled           = status;
            cmbTipoUsuario.Enabled      = status;
        }

        private void ActivarBotones(bool status)
        {
            btnAnular.Enabled = !status;
            btnGuardar.Enabled = !status;
            btnConsultar.Enabled = status;      
            btnNuevo.Enabled = status;
        }
        
        private void LimpiarCampos()
        {
            txtApellido1.Text       = "";
            txtApellido2.Text       = "";
            txtContrasena.Text      = "";
            txtDepartamento.Text    = "";
            txtDepartamento.Text    = "";
            txtEmail.Text           = "";
            txtNombre.Text          = "";
            txtNumEmpleado.Text     = "";
            txtNumVacaciones.Text   = "";
            txtTelefono.Text        = "";

        }

        private void CargarTipoUsuarios()
        {
            var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
            var userTypes = apiclient.ApiUserGetUserTypesGet();
            
            cmbTipoUsuario.DisplayMember = "Description";
            cmbTipoUsuario.ValueMember = "IdUserType";
            cmbTipoUsuario.DataSource = userTypes;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
          
            if (txtNumEmpleado.Text != string.Empty)
            {
                var users = apiclient.ApiUserGetUserByIdIdGet(txtNumEmpleado.Text);
                var user = users.FirstOrDefault();
                if (user != null)
                {
                    this.txtNumEmpleado.Text   = user.IdUser.ToString();
                    cmbTipoUsuario.SelectedValue = (int)user.UserTypeId;
                    this.txtNombre.Text        = user.UserName;
                    this.txtEmail.Text         = user.Email;
                    this.txtApellido1.Text     = user.SurName1;
                    this.txtApellido2.Text     = user.SurName2;
                    this.txtTelefono.Text      = user.Phone.ToString();
                    this.txtNumVacaciones.Text = user.NHollidays.ToString();
                    this.txtContrasena.Text    = user.Password; /// TODO Encrptada¿?¿?¿?
                    this.txtDepartamento.Text  = user.Phone.ToString();
                    SetStatusCombo((bool)user.Status);
                    _form.EnviarEstado("Mostrando Usuario  id: " + user.IdUser.ToString());
                    edicion = true;
                    ActivarCampos(true);
                    ActivarBotones(false);
                }
                else
                {
                    _form.EnviarEstado("Usuario no encontrado");
                }
            }
            else
            {
                _form.EnviarEstado("Falta el Id Usuario");
            }

        }

        private void SetStatusCombo(bool value)
        {
            if (value == true)
            {
                cmbStatus.SelectedItem = "Y";
            }
            else
            {
                cmbStatus.SelectedItem = "N";
            }
        }

        private bool ComboStatusValor()
        {
            if ((string)cmbStatus.SelectedItem == "Y")
            {
                return true;
            }

            else if((string)cmbStatus.SelectedItem == "N")
            {
                return false;
            }

            return false;
            //throw new Exception("No se ha seleccionado un valor");
        }
      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ComboStatusValor();
            try
            {
                var user = new Users
                {
                    Department = txtDepartamento.Text,
                    UserTypeId = (int?)cmbTipoUsuario.SelectedValue,
                    UserName = txtNombre.Text,
                    SurName1 = txtApellido1.Text,
                    SurName2 = txtApellido2.Text,
                    Status = ComboStatusValor(),
                    Phone = Int32.Parse(txtTelefono.Text),
                    NHollidays = Int32.Parse(txtNumVacaciones.Text),
                    Email = txtEmail.Text,
                    Password = txtContrasena.Text
                };

                var apiclient = new UserApi("http://worktracker-001-site1.atempurl.com/");
                if (edicion)
                {
                    user.IdUser = Int32.Parse(txtNumEmpleado.Text);
                    apiclient.ApiUserUpdateUserPost(user);
                    _form.MensajeBox("Usuario modificado correctamente");
                }
                else
                {
                    apiclient.ApiUserCreateUserPut(user);
                    LimpiarCampos();
                    _form.MensajeBox("Usuario Creado correctamente");


                }

                _form.EnviarEstado("Guardado correctamente");
            }
            catch (Exception ex)
            {
                _form.EnviarEstado("Error al guardar el usuario");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarCampos(true);
            ActivarBotones(false);
            LimpiarCampos();
            edicion = false;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ActivarCampos(false);
            ActivarBotones(true);
            edicion = false;
        }

        private void ValidationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}