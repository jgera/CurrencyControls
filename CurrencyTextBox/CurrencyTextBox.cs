/*
 * Author: emarti, Murat Özdemir
 * Date: 5 Feb 2014, v1.0 
 * Updated: 7 feb 2014, v1.1 (Thanks to johannesnestler from CodeProject.com)
 */
using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace CurrencyTextBox
{
    public partial class CurrencyTextBox : TextBox
    {
        readonly CultureInfo _ci = CultureInfo.InstalledUICulture;
        private readonly string _allowedCharacterSet;
        private readonly char _decimalSeparator;

        public double Value
        {
            get { return double.Parse(TypedText()); }
            set { Text = String.Format("{0:0.00}", value);
                double amount;
                Text = Double.TryParse(Text, NumberStyles.Currency, null, out amount) ? amount.ToString("C") : 0.ToString("C");
            }
        }

        public CurrencyTextBox()
        {
            var nf = new CultureInfo(_ci.Name, false).NumberFormat;
            _decimalSeparator = nf.CurrencyDecimalSeparator.ToCharArray()[0];
            _allowedCharacterSet = string.Format("0123456789{0}", _decimalSeparator);
            Text = "0.0";
            InitializeComponent();

            
        }

        /// <summary>
        /// Return Currency Text with No Formatting
        /// </summary>
        public string TextNoFormatting
        {
            get { return TypedText(); }
        }

        protected override void OnLeave(EventArgs e)
        {
            double amount;
            Text = Double.TryParse(Text, NumberStyles.Currency, null, out amount) ? amount.ToString("C") : 0.ToString("C");
            base.OnLeave(e);
        }

        private string TypedText()
        {
            var sonuc = string.Empty;
            return Text.Trim().Where(ch => _allowedCharacterSet.Contains(ch)).Aggregate(sonuc, (current, ch) => current + ch);
        }

        protected override void OnEnter(EventArgs e)
        {
            Text = TypedText();
            base.OnEnter(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != _decimalSeparator && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
