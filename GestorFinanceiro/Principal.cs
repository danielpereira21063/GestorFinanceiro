using System.Data;

namespace GestorFinanceiro
{
    public partial class Principal : Form
    {
        private DBContext DbContext;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            DbContext = new DBContext();

            try
            {
                DbContext.Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (DbContext.Connection.State == ConnectionState.Open)
                {
                    DbContext.Connection.Close();
                }
            }
        }
    }
}