using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SkladProject
{
    /// <summary>
    /// Клас керування даними складу. Відповідає за зберігання таблиць,
    /// операції з файлами та розрахунок статистики.
    /// </summary>
    public class TSklad
    {
        // Основна таблиця даних та її представлення (View)
        public DataTable TabSklad = new DataTable();
        public DataView SkladView;

        // Таблиці-довідники для випадаючих списків
        public DataTable DovGrupa = new DataTable();
        public DataTable DovPostachalnyk = new DataTable();
        public DataTable DovOdVymiru = new DataTable();
        public DataTable DovValuta = new DataTable();

        // Поточні критерії фільтрації та сортування
        public string FiltrCriteria = "";
        public string SortCriteria = "";

        public TSklad()
        {
            // Ініціалізація структури основної таблиці
            TabSklad.TableName = "SkladData";

            TabSklad.Columns.Add(new DataColumn("N_pp", typeof(int)));
            TabSklad.Columns.Add(new DataColumn("SkladID", typeof(string))); // Ідентифікатор складу для фільтрації
            TabSklad.Columns.Add(new DataColumn("Grupa", typeof(string)));
            TabSklad.Columns.Add(new DataColumn("Nazva", typeof(string)));
            TabSklad.Columns.Add(new DataColumn("Vyrobnyk", typeof(string)));
            TabSklad.Columns.Add(new DataColumn("Postachalnyk", typeof(string)));
            TabSklad.Columns.Add(new DataColumn("OdVymiru", typeof(string)));
            TabSklad.Columns.Add(new DataColumn("Cina", typeof(decimal)));
            TabSklad.Columns.Add(new DataColumn("Valuta", typeof(string)));
            TabSklad.Columns.Add(new DataColumn("Kilkist", typeof(int)));
            TabSklad.Columns.Add(new DataColumn("Vartist", typeof(decimal)));
            TabSklad.Columns.Add(new DataColumn("Date", typeof(DateTime)));

            SkladView = new DataView(TabSklad);

            // Заповнення довідників початковими даними
            InitDictionary(DovGrupa, "Grupa", new string[] { "Книги", "Електроніка", "Меблі" });
            InitDictionary(DovPostachalnyk, "Postachalnyk", new string[] { "ТзОВ 'Інтерсервіс'", "ПП 'ПостачЗбут'", "Global Trade" });
            InitDictionary(DovOdVymiru, "OdVymiru", new string[] { "шт.", "кг", "л", "ящик" });
            InitDictionary(DovValuta, "Valuta", new string[] { "грн.", "дол.", "євро" });
        }

        // Допоміжний метод для ініціалізації простого довідника (одна колонка)
        private void InitDictionary(DataTable dt, string colName, string[] initialData)
        {
            dt.Columns.Add(new DataColumn(colName, typeof(string)));
            foreach (var item in initialData)
            {
                dt.Rows.Add(item);
            }
        }

        // Додавання нового запису в основну таблицю
        public void AddRow(string sklad, string gr, string naz, string vyr, string post, string od, decimal cina, string val, int kilk)
        {
            DataRow r = TabSklad.NewRow();
            r["N_pp"] = TabSklad.Rows.Count + 1;
            r["SkladID"] = sklad;
            r["Grupa"] = gr;
            r["Nazva"] = naz;
            r["Vyrobnyk"] = vyr;
            r["Postachalnyk"] = post;
            r["OdVymiru"] = od;
            r["Cina"] = cina;
            r["Valuta"] = val;
            r["Kilkist"] = kilk;
            r["Vartist"] = cina * kilk;
            r["Date"] = DateTime.Now;
            TabSklad.Rows.Add(r);
        }

        // Серіалізація даних у XML файл
        public void SaveToFile(string fileName)
        {
            try
            {
                // WriteSchema важливий, щоб зберегти структуру колонок (типи даних)
                TabSklad.WriteXml(fileName, XmlWriteMode.WriteSchema);
                MessageBox.Show("Дані успішно збережено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка запису: " + ex.Message);
            }
        }

        // Завантаження з вказаного файлу
        public void LoadFromFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    TabSklad.Clear(); // Очищаємо поточні дані перед завантаженням
                    TabSklad.ReadXml(fileName);
                    MessageBox.Show("Дані завантажено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка читання: " + ex.Message);
            }
        }

        // Застосування фільтру до DataView
        public void ApplyFilter(string criteria)
        {
            try
            {
                SkladView.RowFilter = criteria;
                FiltrCriteria = criteria;
            }
            catch { MessageBox.Show("Невірний формат фільтру!"); }
        }

        // Застосування сортування до DataView
        public void ApplySort(string criteria)
        {
            try
            {
                SkladView.Sort = criteria;
                SortCriteria = criteria;
            }
            catch { MessageBox.Show("Невірний формат сортування!"); }
        }

        // Групування товарів по групах та підрахунок сумарної вартості
        // з конвертацією валют у гривню
        public DataTable GetSums()
        {
            DataTable dtSum = new DataTable();
            dtSum.Columns.Add("Grupa", typeof(string));
            dtSum.Columns.Add("TotalVartist (грн)", typeof(decimal));

            // Фіксовані курси валют для розрахунку
            decimal rateUSD = 41.5m;
            decimal rateEUR = 44.0m;

            var query = from row in TabSklad.AsEnumerable()
                        group row by row.Field<string>("Grupa") into grp
                        select new
                        {
                            Group = grp.Key,
                            Sum = grp.Sum(r =>
                            {
                                decimal vartist = r.Field<decimal>("Vartist");
                                string valuta = r.Field<string>("Valuta");

                                if (valuta == "дол.") return vartist * rateUSD;
                                if (valuta == "євро") return vartist * rateEUR;
                                return vartist;
                            })
                        };

            foreach (var item in query)
            {
                dtSum.Rows.Add(item.Group, item.Sum);
            }
            return dtSum;
        }
    }
}