using Microsoft.Data.SqlClient;

namespace KaktuszGUI
{
    public partial class MainForm : Form
    {
        private static string connStr = 
            @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=novenytermesztes;";

        private static string[] nehezsegek = { "könnyû", "mérsékelt", "nehéz" };

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            tbxSzures.TextChanged += TbxSzures_TextChanged;
            dgvAdatok.CellClick += DgvAdatok_CellClick;
        }

        private void DgvAdatok_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            _ = MessageBox.Show(
                caption: "TUDOMÁNYOS NÉV:",
                text: $"{dgvAdatok[2, e.RowIndex].Value}");
        }

        private void TbxSzures_TextChanged(object? sender, EventArgs e)
        {
            dgvAdatok.Rows.Clear();
            using SqlConnection conn = new(connStr);
            conn.Open();
            SqlCommand cmd = new(
                $"SELECT * FROM kaktuszok " +
                $"WHERE nev LIKE '%{tbxSzures.Text}%';",
                conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dgvAdatok.Rows.Add(
                    rdr[0], rdr[1], rdr[2],
                    nehezsegek[rdr.GetInt32(3) - 1],
                    $"{rdr[4]} ml/h", $"{rdr[5]} lm");
            }
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            using SqlConnection conn = new(connStr);
            conn.Open();
            SqlCommand cmd = new("SELECT * FROM kaktuszok;", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dgvAdatok.Rows.Add(
                    rdr[0],
                    rdr[1],
                    rdr[2],
                    nehezsegek[rdr.GetInt32(3) - 1],
                    $"{rdr[4]} ml/h",
                    $"{rdr[5]} lm");
            }
        }
    }
}
