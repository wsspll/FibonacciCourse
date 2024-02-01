using Fibonacci.Forms;
using Fibonacci.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fibonacci
{
    public partial class FibonacciForm : Form
    {
        public FibonacciForm()
        {
            InitializeComponent();
        }

        // Построение графика на основе последовательности Фибоначчи.
        private void PlotChart(int[] sequence)
        {
            chart.Legends.Clear();
            chart.Series.Clear();
            Series series = new Series("Fibonacci");
            series.ChartType = SeriesChartType.Line;

            for (int i = 0; i < sequence.Length; i++)
            {
                series.Points.AddXY(i + 1, sequence[i]);
            }

            chart.Series.Add(series);
        }

        // Обработка события генерации последовательности и построения графика.
        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var seed = Array.ConvertAll(seedTextBox.Text.Trim().Split(), int.Parse);
                
                var n = int.Parse(nTextBox.Text.Trim());
                var j = int.Parse(jTextBox.Text.Trim());
                var k = int.Parse(kTextBox.Text.Trim());

                var fibonacciSequence = FibonacciHelper.GenerateFibonacciSequence(seed, n, j, k);
                fibonacciedArrayTextbox.Text = string.Join(" ", fibonacciSequence);
                PlotChart(fibonacciSequence);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveChartButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить график как";
                saveFileDialog.FileName = "FibonacciChart"; // Имя файла по умолчанию

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Сохранение графика в выбранном месте
                    chart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            openAuthForm();
        }

        private void openAuthForm()
        {
            Hide();
            var authForm = new AuthForm();
            authForm.Closed += (s, args) => Close();
            authForm.Show();
        }
    }
}
