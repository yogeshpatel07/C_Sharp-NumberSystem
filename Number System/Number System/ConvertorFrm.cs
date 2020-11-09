using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_System
{
    public partial class ConvertorFrm : Form
    {
        static NumValidate Nd = new NumValidate();

        public ConvertorFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFrom.Text = "Binary";
            cmbTo.Text = "Binary";
            txtInput.Text = "";
            txtOutput.Text = "";
        }

        private void cmbFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            if(cmbFrom.Text.Equals("Binary"))
            {
                txtInput.MaxLength = 63;
            }
            else if (cmbFrom.Text.Equals("Decimal"))
            {
                txtInput.MaxLength =18;
            }
            else if (cmbFrom.Text.Equals("Octal"))
            {
                txtInput.MaxLength = 21;
            }
            else if (cmbFrom.Text.Equals("Hexa-Decimal"))
            {
                txtInput.MaxLength = 16;
            }
            else
            {
                txtInput.MaxLength = 20;
            }
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            string inType = cmbFrom.Text;
            string input = txtInput.Text;
            if (Nd.isValid(input, inType))
            {
                convert();
               
            }
            else
            {
                txtOutput.Text="Not a valid "+inType+" Number.";
            }
        }

        public void convert()
        {
            string inType = cmbFrom.Text;
            string outType = cmbTo.Text;
            if (inType.Equals("Binary"))
            {
                if (outType.Equals("Binary"))
                {
                    txtOutput.Text=Convert.BinToBin(txtInput.Text);
                }
                else if (outType.Equals("Decimal"))
                {
                    txtOutput.Text = Convert.BinToDec(txtInput.Text);
                }
                else if (outType.Equals("Octal"))
                {
                    txtOutput.Text = Convert.BinToOct(txtInput.Text);
                }
                else if (outType.Equals("Hexa-Decimal"))
                {
                    txtOutput.Text = Convert.BinToHexa(txtInput.Text);
                }
                else
                {
                    txtOutput.Text="wrong-outType";
                }

            }
            else if (inType.Equals("Octal"))
            {
                if (outType.Equals("Binary"))
                {
                    txtOutput.Text = Convert.OctToBin(txtInput.Text);
                }
                else if (outType.Equals("Decimal"))
                {
                    txtOutput.Text = Convert.OctToDec(txtInput.Text);
                }
                else if (outType.Equals("Octal"))
                {
                    txtOutput.Text = Convert.OctToOct(txtInput.Text);
                }
                else if (outType.Equals("Hexa-Decimal"))
                {
                    txtOutput.Text = Convert.OctToHexa(txtInput.Text);
                }
                else
                {
                    txtOutput.Text = "wrong-outType";
                }


            }
            else if (inType.Equals("Decimal"))
            {
                if (outType.Equals("Binary"))
                {
                    txtOutput.Text = Convert.DecToBin(txtInput.Text);
                }
                else if (outType.Equals("Decimal"))
                {
                    txtOutput.Text = Convert.DecToDec(txtInput.Text);
                }
                else if (outType.Equals("Octal"))
                {
                    txtOutput.Text = Convert.DecToOct(txtInput.Text);
                }
                else if (outType.Equals("Hexa-Decimal"))
                {
                    txtOutput.Text = Convert.DecToHexa(txtInput.Text);
                }
                else
                {
                    txtOutput.Text = "wrong-outType";
                }

            }
            else if (inType.Equals("Hexa-Decimal"))
            {
                if (outType.Equals("Binary"))
                {
                    txtOutput.Text = Convert.HexaToBin(txtInput.Text);
                }
                else if (outType.Equals("Decimal"))
                {
                    txtOutput.Text = Convert.HexaToDec(txtInput.Text);
                }
                else if (outType.Equals("Octal"))
                {
                    txtOutput.Text = Convert.HexaToOct(txtInput.Text);
                }
                else if (outType.Equals("Hexa-Decimal"))
                {
                    txtOutput.Text = Convert.HexaToHexa(txtInput.Text);
                }
                else
                {
                    txtOutput.Text = "wrong-outType";
                }


            }
            else
            {
                txtOutput.Text = "wrong-outType";
            }

        }

        private void cmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inType = cmbFrom.Text;
            string input = txtInput.Text;
            if (Nd.isValid(input, inType))
            {
                convert();

            }
            else
            {
                txtOutput.Text = "Not a valid " + inType + " Number.";
            }
        }
    }
}
