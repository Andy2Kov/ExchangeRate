using ExchangeRate.CBR;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ExchangeRate
{
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
            dtCource.DateTime = DateTime.Now; // Текущая дата
            GetExcahngeRate();
        }

        /// <summary>
        /// Заполнение gridCurrency курсами валют
        /// </summary>
        /// <returns></returns>
        private DataTable GetExcahngeRate()
        {
            try
            {
                var client = new DailyInfoSoapClient();
                DataSet response = client.GetCursOnDate(dtCource.DateTime); // Загрузка данных из сервиса ЦБ на дату
                DataTable rateTable = response.Tables["ValuteCursOnDate"]; // Таблица с данными из сервиса ЦБ
                rateTable.Select().ToList<DataRow>()
                    .ForEach(r => { r["Vname"] = r["Vname"].ToString().Trim(); }); // Убираем пробелы в конце строки

                gridCurrency.DataSource = rateTable; // Источник данных грида

                // Наименования колонок
                gridViewCurrency.Columns["Vname"].Caption = "Наименование валюты";
                gridViewCurrency.Columns["Vnom"].Caption = "Номинал";
                gridViewCurrency.Columns["Vcurs"].Caption = "Курс";
                gridViewCurrency.Columns["Vcode"].Caption = "ISO Цифровой код валюты";
                gridViewCurrency.Columns["VchCode"].Caption = "ISO Символьный код валюты";

                gridViewCurrency.BestFitColumns(); // Автоширина колонок по макс.длинне значения
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка получения курсов валют. " + ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Обновление данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetExcahngeRate();
        }

    }
}