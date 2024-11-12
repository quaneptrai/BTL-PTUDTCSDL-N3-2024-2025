using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Data.SqlClient;
using Microsoft.SqlServer;
namespace StudentManagement
{
    public partial class Lapbaocao : Form
    {
        public Lapbaocao(string username)
        {
            InitializeComponent();
            TXTten.Text = username;
        }

        private void Lapbaocao_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=btlserver.database.windows.net;Initial Catalog=BTL;Persist Security Info=True;User ID=DangQuan;Password=585810Qu@n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = TXTten.Text; 
            string filePath = @"C:\Users\HACOM\Documents\TEst.docx"; 
            Word.Application wordApp = new Word.Application();
            Word.Document doc = null;
            try
            {   
                doc = wordApp.Documents.Open(filePath);
                wordApp.Visible = true; // Optional: Make Word visible 
                string ten = TXTten.Text;
                Word.Find findObject = wordApp.Selection.Find;
                findObject.Text = "x"; // Text to find
                findObject.Replacement.Text = ten; // New text from TextBox

                // Execute the replacement
                object replaceAll = Word.WdReplace.wdReplaceAll;
                findObject.Execute(Replace: ref replaceAll);
                // Save changes
                doc.Save();
                MessageBox.Show("Text added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the document and quit the application
                doc.Close();
                wordApp.Quit();
            }
        }
    }
}
