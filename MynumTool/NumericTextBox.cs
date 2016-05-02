using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MynumTool
{
    // カスタムコントロール
    public partial class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        // Textboxに入力制限をかける
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // 半角数字のみ許可を想定
            // TODO: 判定がかなり雑
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'z') || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        // 指定桁の数字のみ許可する
        public bool isValidText(int length)
        {
            uint parsedValue = 0;
            bool isNaturalNumber = uint.TryParse(base.Text, out parsedValue);
            if (!isNaturalNumber) return false;

            if (base.Text.Length != length) return false;

            return true;
        }
    }
}
