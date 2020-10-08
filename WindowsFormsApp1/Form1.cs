using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// A basic Calculator
    /// </summary>


    public partial class CalculatorForm : Form
    {
        #region Constructor

        /// <summary>
        /// Default Contructor
        /// </summary>

        Queue<string> numbers;
        bool OpFlag;

        public CalculatorForm()
        {
            InitializeComponent();
            numbers = new Queue<string>();
            OpFlag = false;
        }

        #endregion Constructor

        #region Clearing

        private void CEButton_Click(object sender, EventArgs e)
        {
            this.CalcResults.Text = "0";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.CalcResults.Text = "0";
            numbers.Clear();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (!this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = this.CalcResults.Text.Remove(this.CalcResults.Text.Length - 1, 1);
            }

            if(this.CalcResults.Text.Length == 0)
            {
                this.CalcResults.Text = "0";
            }
        }

        #endregion Clearing

        #region Operators

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                numbers.Enqueue(this.CalcResults.Text + "/");
                OpFlag = true;
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                numbers.Enqueue(this.CalcResults.Text + "*");
                OpFlag = true;
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                numbers.Enqueue(this.CalcResults.Text + "-");
                OpFlag = true;
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if(numbers.Count == 0)
            {
                numbers.Enqueue(this.CalcResults.Text + "+");
                OpFlag = true;
            }
            
            
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {

        }

        #endregion Operators

        #region Digits

        private void NineButton_Click(object sender, EventArgs e)
        {
            if(this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "9";
            }
            else if(!OpFlag)
            {
                this.CalcResults.Text +="9";
            }else if (OpFlag)
            {
                this.CalcResults.Text = "9";
                OpFlag = false;
            }
            
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "8";
            }
            else if (!OpFlag)
            {
                this.CalcResults.Text += "8";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "8";
                OpFlag = false;
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "7";
            }
            else if (!OpFlag)
            {
                this.CalcResults.Text += "7";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "7";
                OpFlag = false;
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "6";
            }
            else if (!OpFlag)
            {
                this.CalcResults.Text += "6";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "6";
                OpFlag = false;
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "5";
            }
            else if (!OpFlag)
            {
                this.CalcResults.Text += "5";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "5";
                OpFlag = false;
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "4";
            }
            else if (!OpFlag)
            {
                this.CalcResults.Text += "4";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "4";
                OpFlag = false;
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "3";
            }
            else if (!OpFlag)
            {
                this.CalcResults.Text += "3";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "3";
                OpFlag = false;
            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "2";
            }
            else if (!OpFlag)
            {
                this.CalcResults.Text += "2";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "2";
                OpFlag = false;
            }
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text = "1";
            }
            else if (!OpFlag)
            {
                this.CalcResults.Text += "1";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "1";
                OpFlag = false;
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (!this.CalcResults.Text.Equals("0"))
            {
                this.CalcResults.Text += "0";
            }
            else if (OpFlag)
            {
                this.CalcResults.Text = "0";
                OpFlag = false;
            }

        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!this.CalcResults.Text.Contains("."))
            {
                this.CalcResults.Text += ".";
            }
            
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (!this.CalcResults.Text.Contains("-"))
            {
                this.CalcResults.Text = "-" + this.CalcResults.Text;
            }else if (this.CalcResults.Text.Contains("-"))
            {
                this.CalcResults.Text = this.CalcResults.Text.Substring(1);
            }

        }

        #endregion Digits
    }
}
