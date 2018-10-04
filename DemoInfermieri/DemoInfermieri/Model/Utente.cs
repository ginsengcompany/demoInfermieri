using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInfermieri.Model
{
    public class Utente
    {
        private string username, password, nome, cognome;
        private DateTime? datadinascita;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name should not be empty")]
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }
        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
        }
        public string Cognome
        {
            get { return cognome; }
            set
            {
                cognome = value;
            }
        }
        public DateTime? DataDiNascita
        {
            get { return datadinascita; }
            set
            {
                datadinascita = value;
            }
        }
    }
}
