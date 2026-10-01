using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrusCurso.Logica
{
    public class Bases
    {
        public static void DiseñoDtv(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.White;
            Listado.BorderStyle = BorderStyle.None;
            Listado.EnableHeadersVisualStyles = false;
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Listado.RowHeadersVisible = false;
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(0, 70, 160);
            cabecera.ForeColor = Color.White;
            cabecera.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;

        }

        public static void Decimales(TextBox CajaTexto, KeyPressEventArgs e)
        {
            char separadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                bool yaTieneSeparador = CajaTexto.Text.Contains(".") || CajaTexto.Text.Contains(",");
                bool esSeparadorValido = e.KeyChar == separadorDecimal || e.KeyChar == '.' || e.KeyChar == ',';
                int posicionSeparador = CajaTexto.SelectionStart;
                int decimales = 0;

                if (CajaTexto.Text.Contains("."))
                    posicionSeparador = CajaTexto.Text.IndexOf('.');
                else if (CajaTexto.Text.Contains(","))
                    posicionSeparador = CajaTexto.Text.IndexOf(',');

                if (posicionSeparador >= 0)
                    decimales = CajaTexto.Text.Length - posicionSeparador - 1;

                e.Handled = !esSeparadorValido || yaTieneSeparador || decimales >= 2;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void DiseñoDtvEliminar(ref DataGridView Listado)
        {
            foreach(DataGridViewRow row in Listado.Rows)
            {
                string estado;
                estado = row.Cells["Estado"].Value.ToString();
                if (estado == "Eliminado")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 20, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 128);
                }
            }
        }

        public enum DateInterval
        {
            Day,
            DayOfYear,
            Hour,
            Minute,
            Month,
            Quarter,
            Second,
            Weekday,
            WeekOfYear,
            Year
        }    
        public static long DateDiff(DateInterval intervalType, DateTime dateOne, DateTime dateTwo)  
        {
            switch (intervalType)
            {
                case DateInterval.Day:
                case DateInterval.DayOfYear:
                    TimeSpan spanForDays = dateTwo - dateOne;
                    return (long)spanForDays.TotalDays;
                case DateInterval.Hour:
                    TimeSpan spanForHours = dateTwo - dateOne;
                    return (long)spanForHours.TotalHours;
                case DateInterval.Minute:
                    TimeSpan spanForMinute = dateTwo - dateOne;
                    return (long)spanForMinute.TotalMinutes;
                case DateInterval.Month :
                    return ((dateTwo.Year - dateOne.Year) * 12) + (dateTwo.Month - dateOne.Month);
                case DateInterval.Quarter:
                    long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    long dateTwoQuarter = (long)Math.Ceiling(dateTwo.Month / 3.0);
                    return (4 * (dateTwo.Year - dateOne.Year)) + dateTwoQuarter - dateOneQuarter;
                case DateInterval.Second:
                    TimeSpan spanForSecond = dateTwo - dateOne;
                    return (long)spanForSecond.TotalSeconds;
                case DateInterval.Weekday:
                    TimeSpan spanForWeekdays = dateTwo - dateOne;
                    return (long)(spanForWeekdays.TotalDays / 7.0);
                case DateInterval.WeekOfYear:
                    DateTime dateOneModified = dateOne;
                    DateTime dateTwoModified = dateTwo;
                    while (dateTwoModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateTwoModified = dateTwoModified.AddDays(-1);
                    }
                    while (dateOneModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateOneModified = dateOneModified.AddDays(-1);
                    }
                    TimeSpan spanForWeekOfYear = dateTwoModified - dateOneModified;
                    return (long)(spanForWeekOfYear.TotalDays / 7.0);
                case DateInterval.Year:
                    return dateTwo.Year - dateOne.Year;
                default:
                    return 0;

            }
        }
    }
}
