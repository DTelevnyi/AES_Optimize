using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AesDemoApplication
{
    public partial class Form1 : Form
    {
        Byte[] key;
        Byte[] vector;
        Byte[] output;
        Byte[] input;
        uint padding;
        Stopwatch st;
        public Form1()
        {
            InitializeComponent();
            st = new Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void genKey_Click(object sender, EventArgs e)
        {
            Guid gui = new Guid();
            keyTextBox.Text = gui.ToString(); 
        }

        private void genVector_Click(object sender, EventArgs e)
        {
            Guid gui = new Guid();
            vectorTextBox.Text = gui.ToString();
            key = System.Text.Encoding.Unicode.GetBytes(keyTextBox.Text);
            vector = System.Text.Encoding.Unicode.GetBytes(vectorTextBox.Text);

        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            key = System.Text.Encoding.Unicode.GetBytes(keyTextBox.Text);
        }

        private void vectorTextBox_TextChanged(object sender, EventArgs e)
        {
            vector = System.Text.Encoding.Unicode.GetBytes(vectorTextBox.Text);
        }
        private bool CheckKey()
        {
            return key.Length == 16 || key.Length == 24 || key.Length == 32;
        }
        private bool CheckVector()
        {
            return vector.Length == 16;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            input = null;
            GC.Collect();
            openFileDialog.ShowDialog();
            textBox1.Text = openFileDialog.FileName;
            try
            {
                input = File.ReadAllBytes(openFileDialog.FileName);
            }
            catch
            {
                MessageBox.Show("Choose file");
            }
        }

        private void ciphButton_Click(object sender, EventArgs e)
        {
            if (CheckKey())
            {
                using (AesTransformWrapper.AesTransformWrap wr = new AesTransformWrapper.AesTransformWrap((uint)input.Length, key, (uint)key.Length, true))
                {
                    st.Start();
                    if (ECBradioButton.Checked)
                    {
                        output = new byte[input.Length + wr.GetPaddingSize()];
                        wr.ECBEncrypt(input, output);
                        st.Stop();
                    }
                    else if(CBCradioButton.Checked)
                    {
                        if (CheckVector())
                        {
                            output = new byte[input.Length + wr.GetPaddingSize()];
                            wr.AesCBCEncrypt(input, output, vector);
                            st.Stop();
                        }
                    }
                    else if(CFBradioButton.Checked)
                    {
                        if(CheckVector())
                        {
                            output = new byte[input.Length + wr.GetPaddingSize()];
                            wr.AesCFBEncrypt(input, output, vector);
                            st.Stop();
                        }
                    }
                    else if(OFBRadioButton.Checked)
                    {
                        if (CheckVector())
                        {
                            output = new byte[input.Length + wr.GetPaddingSize()];
                            wr.AesOFBEncrypt(input, output, vector);
                            st.Stop();
                        }
                    }

                    time.Text = st.ElapsedMilliseconds.ToString();
                }
            }
        }

        private void invCipher_Click(object sender, EventArgs e)
        {
             if (CheckKey())
            {
                using (AesTransformWrapper.AesTransformWrap wr = new AesTransformWrapper.AesTransformWrap((uint)input.Length, key, (uint)key.Length, false))
                {
                    st.Restart();
                    if (ECBradioButton.Checked)
                    {
                        output = new byte[input.Length];
                       padding = wr.ECBDecrypt(input, output);
                        st.Stop();
                        output = output.Take(output.Length - (int)padding).ToArray();
                        GC.Collect();
                    }
                    else if(CBCradioButton.Checked)
                    {
                        if (CheckVector())
                        {
                            output = new byte[input.Length];
                            padding = wr.AesCBCDecrypt(input, output, vector);
                            st.Stop();
                            output = output.Take(output.Length - (int)padding).ToArray();
                            GC.Collect();
                        }
                    }
                    else if(CFBradioButton.Checked)
                    {
                        if(CheckVector())
                        {
                            output = new byte[input.Length];
                            padding = wr.AesCFBDecrypt(input, output, vector);
                            st.Stop();
                            output = output.Take(output.Length - (int)padding).ToArray();
                        }
                        GC.Collect();
                    }
                    else if(OFBRadioButton.Checked)
                    {
                        if (CheckVector())
                        {
                            output = new byte[input.Length];
                            padding = wr.AesOFBDecrypt(input, output, vector);
                            st.Stop();
                            output = output.Take(output.Length - (int)padding).ToArray();
                        }
                        GC.Collect();
                    }
                    time.Text = st.ElapsedMilliseconds.ToString();
                }
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            try
            {
                File.WriteAllBytes(saveFileDialog.FileName, output);
                output = null;
                GC.Collect();
            }
            catch
            {
                MessageBox.Show("Something is not right");
            }
        }
    }
}
