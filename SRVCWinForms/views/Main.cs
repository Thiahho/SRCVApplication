using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using SRVCWebApi.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRVCWinForms.views
{
    public partial class Main : Form
    {
        List<Usuario>usuarios = new List<Usuario>();

        private string tipoUsuario;
        public Main(string tipo)
        {
            this.tipoUsuario = tipo;
            InitializeComponent();
            
        }

      
    }
}
