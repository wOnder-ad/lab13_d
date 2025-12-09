using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SkladProject
{
    /// <summary>
    /// Універсальна форма для редагування таблиць-довідників.
    /// Зміни вносяться безпосередньо в переданий DataTable.
    /// </summary>
    public class FEditDict : Form
    {
        private DataGridView dgv;
        private DataTable sourceTable;

        public FEditDict(DataTable dt, string title)
        {
            this.Text = "Редагування: " + title;
            this.Size = new Size(300, 400);
            sourceTable = dt;

            dgv = new DataGridView();
            dgv.Parent = this;
            dgv.Dock = DockStyle.Fill;
            dgv.DataSource = sourceTable;

            // Кнопка закриття (збереження відбувається автоматично через прив'язку даних)
            Button btnClose = new Button() { Text = "Закрити", Dock = DockStyle.Bottom, Height = 30 };
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
            this.Controls.Add(dgv);
        }
    }
}