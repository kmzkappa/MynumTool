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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (ntxtCalc1.isValidText(4) && ntxtCalc2.isValidText(4) && ntxtCalc3.isValidText(3))
            {
                string checkDigit = Mynumber.CalcCheckDigit(ntxtCalc1.Text + ntxtCalc2.Text + ntxtCalc3.Text);
                statusbar.ForeColor = System.Drawing.Color.Black;
                statusbar.Text = "チェックデジットの計算が完了しました。";
                txtCalcResult.Text = checkDigit;
            }
            else
            {
                statusbar.ForeColor = System.Drawing.Color.Red;
                statusbar.Text = "個人番号は11桁の数値を入力してください。";
                txtCalcResult.Text = "";
            }


        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool isValidNumber = false;
            if(ntxtCheck1.isValidText(4) && ntxtCheck2.isValidText(4) && ntxtCheck3.isValidText(4))
            {
                isValidNumber = Mynumber.IsValid(ntxtCheck1.Text + ntxtCheck2.Text + ntxtCheck3.Text);
                statusbar.ForeColor = System.Drawing.Color.Black;
                statusbar.Text = "個人番号の確認が完了しました。";
                string resultText = isValidNumber ? "有効" : "無効";
                MessageBox.Show("入力された個人番号は " + resultText + " です。");
            }
            else
            {
                statusbar.ForeColor = System.Drawing.Color.Red;
                statusbar.Text = "個人番号は12桁の数値を入力してください。";
                txtCalcResult.Text = "";
            }

        }
        

        // TODO: 以下カスタムコントロールでどうにかしたい
        private void ntxtCalc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((NumericTextBox)sender).TextLength == 3 && e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9)
            {
                ntxtCalc2.Focus();
            }
        }

        private void ntxtCalc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((NumericTextBox)sender).TextLength == 1 && e.KeyChar == (char)Keys.Back)
            {
                ntxtCalc1.Focus();
            }
            else if(((NumericTextBox)sender).TextLength == 3 && e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9)
            {
                ntxtCalc3.Focus();
            }
        }

        private void ntxtCalc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((NumericTextBox)sender).TextLength == 1 && e.KeyChar == (char)Keys.Back)
            {
                ntxtCalc2.Focus();
            }
            else if (((NumericTextBox)sender).TextLength == 3 && e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9)
            {
                btnCalc.Focus();
            }
        }

        private void ntxtCheck1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((NumericTextBox)sender).TextLength == 3 && e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9)
            {
                ntxtCheck2.Focus();
            }
        }

        private void ntxtCheck2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((NumericTextBox)sender).TextLength == 1 && e.KeyChar == (char)Keys.Back)
            {
                ntxtCheck1.Focus();
            }
            else if (((NumericTextBox)sender).TextLength == 3 && e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9)
            {
                ntxtCheck3.Focus();
            }
        }

        private void ntxtCheck3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((NumericTextBox)sender).TextLength == 1 && e.KeyChar == (char)Keys.Back)
            {
                ntxtCheck2.Focus();
            }
            else if (((NumericTextBox)sender).TextLength == 3 && e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9)
            {
                btnCheck.Focus();
            }
        }

        private void btnCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                ntxtCalc3.Focus();
            }
        }

        private void btnCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                ntxtCheck3.Focus();
            }
        }
    }
}
