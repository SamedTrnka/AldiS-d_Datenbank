using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace XML_Schreiben_SamedTrnka_
{
    public partial class AldiForm : Form
    {
        private Dictionary<string, int> mitarbeiter = new Dictionary<string, int>();
        
        public AldiForm()
        {
            InitializeComponent();

        }

 
        private void Clear()
        {
            tbxFilialenNr.Text = "";
            tbxMitarbeiterNr.Text = "";
            tbxNachname.Text = "";
            tbxVertrag.Text = "";
            tbxVorname.Text = "";
            rbtnMan.Checked = false;
            rbtnWoman.Checked = false;
            rbtnOthers.Checked = false;
            foreach (int i in clbxPosition.CheckedIndices)
            {
                clbxPosition.SetItemCheckState(i, CheckState.Unchecked);
            }
        }


        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            mitarbeiter.Clear();
            mitarbeiter.Add("Verkaufsleiter", 0);
            mitarbeiter.Add("Regionalverkaufsleiter", 1);
            mitarbeiter.Add("Filialverantwortlicher", 2);  
            mitarbeiter.Add("Mitarbeiter", 3);
            mitarbeiter.Add("Aushilfe", 4);
            MySqlConnection connection = null;
            MySqlCommand command = null;
            String connectiondata = "SERVER=localhost;" +           /*Eine Verbindung zur Datenbank wird mit den angegebenen Server- und Login-Informationen (SERVER, DATABASE, UID und PASSWORD) hergestellt.*/
                                      "DATABASE=mitarbeiter_aldisued;" + //<-- Name der Database in MyPHPAdmin
                                         "UID=HHBK;" +
                                             "PASSWORD=hhbk;";
            // am HHBK: UID=root PASSWORD=hhbbk
            connection = new MySqlConnection(connectiondata);
            connection.Open();                                      //Mit dem Befehl "connection.Open()" wird die Verbindung geöffnet.
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM aldi_sued WHERE mitarbeiternr=@id"; //Ein neues Command-Objekt wird mit "connection.CreateCommand()" erstellt und sein CommandText wird auf "SELECT name FROM t_klasse" festgelegt.
            command.Parameters.AddWithValue("@id", tbxMitarbeiterNr.Text);
            MySqlDataReader dr = command.ExecuteReader();           //Die Ausführung des Befehls liefert einen MySqlDataReader, der eine Liste aller Namen aus der Tabelle "t_klasse" zurückgibt.
            if (dr.Read())
            {
                tbxFilialenNr.Text = dr.GetInt32(1).ToString();     // Entgegennahme der Filialennummer...
                tbxVorname.Text = dr.GetString(2);                  // Entgegennahme des Vornames...
                tbxNachname.Text = dr.GetString(3);                 // Entgegennahme des Nachnames..

                if (dr.GetString(4) == "w")
                {rbtnWoman.Checked = true; }                        // Entgegennahme des Geschlechts...
                else {rbtnMan.Checked = true;}

                clbxPosition.SetItemChecked(mitarbeiter[dr.GetString(5)], true); // Entgegennahme der Position...

                tbxVertrag.Text = dr.GetString(6);                  // Entgegennahme des Vertrags...

            }

            command.Connection.Close();                             //Schließt die Verbindung....

            
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
