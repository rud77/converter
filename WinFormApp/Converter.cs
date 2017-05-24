using FixerLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Converter : Form
    {
        #region Fields
        const int daysCount = 3;
        const string dateFormat = "yyyy-MM-dd";
        FixerClient fixer = new FixerClient();
        #endregion

        #region Constructor
        public Converter()
        {
            InitializeComponent();
        }
        #endregion

        #region Execute
        private int RepeatDaysCount()
        {
            string date = fixer.GetData().Date;
            int shift = 0;
            while (true)
            {
                if (date != DateTime.Now.AddDays(-shift).ToString(dateFormat))
                    ++shift;
                else
                    return shift;
            }
        }

        private CurrencyState CalculateTrend(IList<float> rates)
        {
            int counter = 0;

            for (int i = 0; i < rates.Count - 1; i++)
            {
                if (rates[i] > rates[i + 1])
                    ++counter;
                else if (rates[i] < rates[i + 1])
                    --counter;
            }

            if (rates.Count - 1 == counter)
                return CurrencyState.Increasing;
            else if (rates.Count - 1 == -counter)
                return CurrencyState.Decreasing;
            else
                return CurrencyState.Unstable;
        }

        private void Execute()
        {
            try
            {
                table.Rows.Clear();

                Rate choosedRate;
                Enum.TryParse<Rate>(currencyList.SelectedItem.ToString(), out choosedRate);

                List<float> rates = new List<float>(daysCount);
                Exchange[] response = new Exchange[daysCount];

                #region Getting response
                int shift = RepeatDaysCount();

                for (int i = 0; i < daysCount; i++)
                {
                    DateTime date = DateTime.Now.AddDays((-i) - shift);
                    response[i] = fixer.GetData(date, Rate.RUB, choosedRate);
                }
                #endregion

                #region Binding data
                foreach (Exchange data in response)
                {
                    foreach (float r in data.Rates.Values)
                    {
                        table.Rows.Add(data.Date, r);
                        rates.Add(r);
                    }
                }

                state.Text = CalculateTrend(rates).ToString();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Event handlers
        private void OnLoadForm(object sender, EventArgs e)
        {
            currencyList.DataSource = Enum.GetNames(typeof(Rate));
            Execute();
        }

        private void OnSelectCurrency(object sender, EventArgs e)
        {
            Execute();
        }
        #endregion
    }
}