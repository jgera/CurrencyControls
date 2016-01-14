using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace CurrencyTextBox
{
    public partial class CurrencyCombobox : ComboBox
    {


        readonly CultureInfo _ci = CultureInfo.InstalledUICulture;
        private readonly string _allowedCharacterSet;
        private readonly char _decimalSeparator;

        public double Value
        {
            get { return double.Parse(TypedText()); }
            set
            {
                Text = String.Format("{0:0.00}", value);
                double amount;
                Text = Double.TryParse(Text, NumberStyles.Currency, null, out amount) ? amount.ToString("C") : 0.ToString("C");
            }
        }

        private string TypedText()
        {
            var sonuc = string.Empty;
            return Text.Trim().Where(ch => _allowedCharacterSet.Contains(ch)).Aggregate(sonuc, (current, ch) => current + ch);
        }


        public CurrencyCombobox()
        {
            var nf = new CultureInfo(_ci.Name, false).NumberFormat;
            _decimalSeparator = nf.CurrencyDecimalSeparator.ToCharArray()[0];
            _allowedCharacterSet = string.Format("0123456789{0}", _decimalSeparator);
            
            InitializeComponent();


        }

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
