using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k = Microsoft.VisualBasic.Interaction;

namespace MatrisApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int row, column, adet;
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }
        void MatrisWrite(int[,] matris)
        {
            try
            {
                listBox1.Items.Add("*****************************");
                for (int i = 0; i < matris.GetLength(0); i++)
                {
                    string satir = "";
                    for (int j = 0; j < matris.GetLength(1); j++)
                    {
                        satir += matris[i, j] + "\t";
                    }
                    listBox1.Items.Add(satir);
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }

        }

        int[,] MatrisAdd(int rows, int columns)
        {
            int[,] matris = new int[rows, columns];
            try
            {
                int z = 0;
                for (int i = 0; i < matris.GetLength(0); i++)
                {
                    for (int j = 0; j < matris.GetLength(1); j++)
                    {
                        if (i < listBox1.Items.Count)
                        {
                            matris[i, j] = int.Parse(listBox1.Items[z].ToString()); z++;
                        }
                    }
                }
                MessageBox.Show("Matris Add Completed Successful.");
                listBox1.Items.Clear();
            }
            catch (Exception)
            {
                lblAbout.Text = "ALERT!";
            }
            return matris;
        }

        int[,] matrisToplam;
        void MatrisSum(int[,] m1, int[,] m2)
        {
            try
            {
                if (m1.GetLength(0) == m2.GetLength(0) && m1.GetLength(1) == m2.GetLength(1))
                {
                    matrisToplam = new int[m1.GetLength(0), m2.GetLength(1)];
                    for (int i = 0; i < matrisToplam.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrisToplam.GetLength(1); j++)
                        {
                            matrisToplam[i, j] = m1[i, j] + m2[i, j];
                        }
                    }
                    listBox1.Items.Clear();
                    listBox1.Items.Add("SUM OPERATIONS");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Select Matris 1");
                    MatrisWrite(m1);
                    listBox1.Items.Add("Select Matris 2");
                    MatrisWrite(m2);
                    listBox1.Items.Add("MATRIS SUM");
                    MatrisWrite(matrisToplam);

                }
                else
                    listBox1.Items.Add("Matrices Cannot Not Summed");
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }

        }

        int[,] matrisSubtrac;
        void MatrisSubstrac(int[,] m1, int[,] m2)
        {
            try
            {
                if (m1.GetLength(0) == m2.GetLength(0) && m1.GetLength(1) == m2.GetLength(1))
                {
                    matrisSubtrac = new int[m1.GetLength(0), m2.GetLength(1)];
                    for (int i = 0; i < matrisSubtrac.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrisSubtrac.GetLength(1); j++)
                        {
                            matrisSubtrac[i, j] = m1[i, j] - m2[i, j];
                        }
                    }
                    listBox1.Items.Clear();
                    listBox1.Items.Add("SUBSTRAC OPERATIONS");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Select Matris 1");
                    MatrisWrite(m1);
                    listBox1.Items.Add("Select Matris 2");
                    MatrisWrite(m2);
                    listBox1.Items.Add("MATRIS SUBTRAC");
                    MatrisWrite(matrisSubtrac);
                }
                else
                    listBox1.Items.Add("Matrices Cannot Not Substrac");
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }

        }

        int hesapla2x2(int[,] m)
        {
            int det = 0;
            det = (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
            return det;
        }
        int hesapla3x3(int[,] m)
        {
            int det = 0;
            det = ((m[0, 0] * m[1, 1] * m[2, 2]) + (m[1, 0] * m[2, 1] * m[0, 2]) + (m[2, 0] * m[0, 1] * m[1, 2])) - ((m[0, 2] * m[1, 1] * m[2, 0]) + (m[1, 2] * m[2, 1] * m[0, 0]) + (m[2, 2] * m[0, 1] * m[1, 0]));
            return det;
        }
        int hesapla4x4(int[,] m)
        {
            int det = 0;
            int[,] a11 = { { m[1, 1], m[1, 2], m[1, 3] }, { m[2, 1], m[2, 2], m[2, 3] }, { m[3, 1], m[3, 2], m[3, 3] } };
            int[,] a12 = { { m[1, 0], m[1, 2], m[1, 3] }, { m[2, 0], m[2, 2], m[2, 3] }, { m[3, 0], m[3, 2], m[3, 3] } };
            int[,] a13 = { { m[1, 0], m[1, 1], m[1, 3] }, { m[2, 0], m[2, 1], m[2, 3] }, { m[3, 0], m[3, 1], m[3, 3] } };
            int[,] a14 = { { m[1, 0], m[1, 1], m[1, 2] }, { m[2, 0], m[2, 1], m[2, 2] }, { m[3, 0], m[3, 1], m[3, 2] } };
            det = (hesapla3x3(a11) * m[0, 0]) + (hesapla3x3(a12) * -1 * m[0, 1]) + (hesapla3x3(a13) * m[0, 2]) + (hesapla3x3(a14) * -1 * m[0, 3]);
            return det;
        }
        int hesapla5x5(int[,] m)
        {
            int det = 0;
            int[,] a11 = { { m[1, 1], m[1, 2], m[1, 3], m[1, 4] }, { m[2, 1], m[2, 2], m[2, 3], m[2, 4] }, { m[3, 1], m[3, 2], m[3, 3], m[3, 4] }, { m[4, 1], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] a12 = { { m[1, 0], m[1, 2], m[1, 3], m[1, 4] }, { m[2, 0], m[2, 2], m[2, 3], m[2, 4] }, { m[3, 0], m[3, 2], m[3, 3], m[3, 4] }, { m[4, 0], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] a13 = { { m[1, 0], m[1, 1], m[1, 3], m[1, 4] }, { m[2, 0], m[2, 1], m[2, 3], m[2, 4] }, { m[3, 0], m[3, 1], m[3, 3], m[3, 4] }, { m[4, 0], m[4, 1], m[4, 3], m[4, 4] } };
            int[,] a14 = { { m[1, 0], m[1, 1], m[1, 2], m[1, 4] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 4] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 4] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 4] } };
            int[,] a15 = { { m[1, 0], m[1, 1], m[1, 2], m[1, 3] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 3] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 3] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 3] } };
            det = (hesapla4x4(a11) * m[0, 0]) + (hesapla4x4(a12) * -1 * m[0, 1]) + (hesapla4x4(a13) * m[0, 2]) + (hesapla4x4(a14) * -1 * m[0, 3]) + (hesapla4x4(a15) * m[0, 4]);
            return det;
        }
        void Determinant(int[,] m)
        {
            int a = m.GetLength(0);
            int b = m.GetLength(1);
            if (a == b)
            {
                if (a == 1)
                {
                    listBox1.Items.Add("Determint......: " + m[0, 0].ToString());
                    listBox1.Items.Add("");
                }
                if (a == 2)
                {
                    listBox1.Items.Add("Determint......: " + hesapla2x2(m).ToString());
                    listBox1.Items.Add("");
                }
                if (a == 3)
                {
                    listBox1.Items.Add("Determint......: " + hesapla3x3(m).ToString());
                    listBox1.Items.Add("");
                }
                if (a == 4)
                {
                    listBox1.Items.Add("Determint......: " + hesapla4x4(m).ToString());
                    listBox1.Items.Add("");
                }
                if (a == 5)
                {
                    listBox1.Items.Add("Determint......: " + hesapla5x5(m).ToString());
                    listBox1.Items.Add("");
                }
            }
            else
                listBox1.Items.Add("Determinant ERROR!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    adet--;
                    listBox1.Items.Add(textBox1.Text); textBox1.Clear();
                    lblAbout.Text = adet.ToString() + " More Enteres";
                    if (adet == 0)
                    {
                        groupBox2.Enabled = false; groupBox1.Enabled = true; lblAbout.Text = "Completed...";
                    }


                }
                else
                    lblAbout.Text = "ALERT!";
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }

        }


        int[,] matris1;
        private void btnAddMatris1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(listBox1.Items[0].ToString()) >= 0 || int.Parse(listBox1.Items[0].ToString()) < 0)
                {
                    matris1 = MatrisAdd(row, column);
                }
            }
            catch (Exception)
            {

            }

        }
        int[,] matris2;
        private void btnAddMatris2_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(listBox1.Items[0].ToString()) >= 0 || int.Parse(listBox1.Items[0].ToString()) < 0)
                {
                    matris2 = MatrisAdd(row, column);
                }

            }
            catch (Exception)
            {
            }

        }

        int[,] matris3;
        private void btnAddMatris3_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(listBox1.Items[0].ToString()) >= 0 || int.Parse(listBox1.Items[0].ToString()) < 0)
                {
                    matris3 = MatrisAdd(row, column);
                }

            }
            catch (Exception)
            {
            }
        }

        private void btnWriteFirst_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Matris First");
            MatrisWrite(matris1);
            listBox1.Items.Add("-----------------------------");
        }

        private void btnWriteSecond_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Matris Second");
            MatrisWrite(matris2);
            listBox1.Items.Add("-----------------------------");
        }

        private void btnWriteThird_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Matris Third");
            MatrisWrite(matris3);
            listBox1.Items.Add("-----------------------------");
        }
        int[,] MatrisSarch(int number)
        {
            int[,] result;
            if (number == 1)
            {
                result = matris1;
            }
            else if (number == 2)
            {
                result = matris2;
            }
            else
            {
                result = matris3;
            }

            return result;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(k.InputBox("Enter The Number Of Matrices 1"));
                int number2 = int.Parse(k.InputBox("Enter The Number Of Matrices 2"));
                MatrisSum(MatrisSarch(number1), MatrisSarch(number2));
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }

        }

        private void btnSubstrac_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(k.InputBox("Enter The Number Of Matrices 1"));
                int number2 = int.Parse(k.InputBox("Enter The Number Of Matrices 2"));
                MatrisSubstrac(MatrisSarch(number1), MatrisSarch(number2));
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }
        }

        void MatrisMultiply(int[,] m1, int[,] m2)
        {
            try
            {
                int x1 = m1.GetLength(0);
                int y1 = m1.GetLength(1);
                int x2 = m2.GetLength(0);
                int y2 = m2.GetLength(1);
                if (y1 != x2)
                {
                    listBox1.Items.Add("Matrices Cannot Not Multiply"); return;
                }
                int[,] matrisMultiply = new int[x1, y2];
                for (int i = 0; i < x1; i++)
                {
                    for (int j = 0; j < y2; j++)
                    {
                        for (int k = 0; k < y1; k++)
                        {
                            matrisMultiply[i, j] += m1[i, k] * m2[k, j];
                        }
                    }
                }
                listBox1.Items.Clear();
                listBox1.Items.Add("MULTIPLY OPERATIONS");
                listBox1.Items.Add("Matris 1");
                MatrisWrite(m1);
                listBox1.Items.Add("Matris 2");
                MatrisWrite(m2);
                listBox1.Items.Add("Matris Multiply");
                MatrisWrite(matrisMultiply);
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message.ToString());
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = int.Parse(k.InputBox("Enter The Number Of Matrices 1"));
                int number2 = int.Parse(k.InputBox("Enter The Number Of Matrices 1"));
                MatrisMultiply(MatrisSarch(number1), MatrisSarch(number2));
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }

        }

        private void btnDeterminant_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(k.InputBox("Enter The Number Of Determinanat"));
                listBox1.Items.Clear();
                listBox1.Items.Add("Matris " + number.ToString() + "...........");
                Determinant(MatrisSarch(number));
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }
        }

        int[,] Minor2x2(int[,] m)
        {
            int[,] min = { { m[1, 1], m[1, 0] }, { m[0, 1], m[0, 0] } };
            return min;
        }
        int[,] Minor3x3(int[,] m)
        {
            int[,] s11 = { { m[1, 1], m[1, 2] }, { m[2, 1], m[2, 2] } };
            int[,] s12 = { { m[1, 0], m[1, 2] }, { m[2, 0], m[2, 2] } };
            int[,] s13 = { { m[1, 0], m[1, 1] }, { m[2, 0], m[2, 1] } };
            int[,] s21 = { { m[0, 1], m[0, 2] }, { m[2, 1], m[2, 2] } };
            int[,] s22 = { { m[0, 0], m[0, 2] }, { m[2, 0], m[2, 2] } };
            int[,] s23 = { { m[0, 0], m[0, 1] }, { m[2, 0], m[2, 1] } };
            int[,] s31 = { { m[0, 1], m[0, 2] }, { m[1, 1], m[1, 2] } };
            int[,] s32 = { { m[0, 0], m[0, 2] }, { m[1, 0], m[1, 2] } };
            int[,] s33 = { { m[0, 0], m[0, 1] }, { m[1, 0], m[1, 1] } };
            int[,] min = { { hesapla2x2(s11), hesapla2x2(s12), hesapla2x2(s13) }, { hesapla2x2(s21), hesapla2x2(s22), hesapla2x2(s23) }, { hesapla2x2(s31), hesapla2x2(s32), hesapla2x2(s33) } };
            return min;
        }
        int[,] Minor4x4(int[,] m)
        {
            int[,] s11 = { { m[1, 1], m[1, 2], m[1, 3] }, { m[2, 1], m[2, 2], m[2, 3] }, { m[3, 1], m[3, 2], m[3, 3] } };
            int[,] s12 = { { m[1, 0], m[1, 2], m[1, 3] }, { m[2, 0], m[2, 2], m[2, 3] }, { m[3, 0], m[3, 2], m[3, 3] } };
            int[,] s13 = { { m[1, 0], m[1, 1], m[1, 3] }, { m[2, 0], m[2, 1], m[2, 3] }, { m[3, 0], m[3, 1], m[3, 3] } };
            int[,] s14 = { { m[1, 0], m[1, 1], m[1, 2] }, { m[2, 0], m[2, 1], m[2, 2] }, { m[3, 0], m[3, 1], m[3, 2] } };
            int[,] s21 = { { m[0, 1], m[0, 2], m[0, 3] }, { m[2, 1], m[2, 2], m[2, 3] }, { m[3, 1], m[3, 2], m[3, 3] } };
            int[,] s22 = { { m[0, 0], m[0, 2], m[0, 3] }, { m[2, 0], m[2, 2], m[2, 3] }, { m[3, 0], m[3, 2], m[3, 3] } };
            int[,] s23 = { { m[0, 0], m[0, 1], m[0, 3] }, { m[2, 0], m[2, 1], m[2, 3] }, { m[3, 0], m[3, 1], m[3, 3] } };
            int[,] s24 = { { m[0, 0], m[0, 1], m[0, 2] }, { m[2, 0], m[2, 1], m[2, 2] }, { m[3, 0], m[3, 1], m[3, 2] } };
            int[,] s31 = { { m[0, 1], m[0, 2], m[0, 3] }, { m[1, 1], m[1, 2], m[1, 3] }, { m[3, 1], m[3, 2], m[3, 3] } };
            int[,] s32 = { { m[0, 0], m[0, 2], m[0, 3] }, { m[1, 0], m[1, 2], m[1, 3] }, { m[3, 0], m[3, 2], m[3, 3] } };
            int[,] s33 = { { m[0, 0], m[0, 1], m[0, 3] }, { m[1, 0], m[1, 1], m[1, 3] }, { m[3, 0], m[3, 1], m[3, 3] } };
            int[,] s34 = { { m[0, 0], m[0, 1], m[0, 2] }, { m[1, 0], m[1, 1], m[1, 2] }, { m[3, 0], m[3, 1], m[3, 2] } };
            int[,] s41 = { { m[0, 1], m[0, 2], m[0, 3] }, { m[1, 1], m[1, 2], m[1, 3] }, { m[2, 1], m[2, 2], m[2, 3] } };
            int[,] s42 = { { m[0, 0], m[0, 2], m[0, 3] }, { m[1, 0], m[1, 2], m[1, 3] }, { m[2, 0], m[2, 2], m[2, 3] } };
            int[,] s43 = { { m[0, 0], m[0, 1], m[0, 3] }, { m[1, 0], m[1, 1], m[1, 3] }, { m[2, 0], m[2, 1], m[2, 3] } };
            int[,] s44 = { { m[0, 0], m[0, 1], m[0, 2] }, { m[1, 0], m[1, 1], m[1, 2] }, { m[2, 0], m[2, 1], m[2, 2] } };
            int[,] min = { { hesapla3x3(s11), hesapla3x3(s12), hesapla3x3(s13), hesapla3x3(s14) }, { hesapla3x3(s21), hesapla3x3(s22), hesapla3x3(s23), hesapla3x3(s24) }, { hesapla3x3(s31), hesapla3x3(s32), hesapla3x3(s33), hesapla3x3(s34) }, { hesapla3x3(s41), hesapla3x3(s42), hesapla3x3(s43), hesapla3x3(s44) } };
            return min;
        }
        int[,] Minor5x5(int[,] m)
        {
            int[,] s11 = { { m[1, 1], m[1, 2], m[1, 3], m[1, 4] }, { m[2, 1], m[2, 2], m[2, 3], m[2, 4] }, { m[3, 1], m[3, 2], m[3, 3], m[3, 4] }, { m[4, 1], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] s12 = { { m[1, 0], m[1, 2], m[1, 3], m[1, 4] }, { m[2, 0], m[2, 2], m[2, 3], m[2, 4] }, { m[3, 0], m[3, 2], m[3, 3], m[3, 4] }, { m[4, 0], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] s13 = { { m[1, 0], m[1, 1], m[1, 3], m[1, 4] }, { m[2, 0], m[2, 1], m[2, 3], m[2, 4] }, { m[3, 0], m[3, 1], m[3, 3], m[3, 4] }, { m[4, 0], m[4, 1], m[4, 3], m[4, 4] } };
            int[,] s14 = { { m[1, 0], m[1, 1], m[1, 2], m[1, 4] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 4] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 4] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 4] } };
            int[,] s15 = { { m[1, 0], m[1, 1], m[1, 2], m[1, 3] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 3] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 3] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 3] } };

            int[,] s21 = { { m[0, 1], m[0, 2], m[0, 3], m[0, 4] }, { m[2, 1], m[2, 2], m[2, 3], m[2, 4] }, { m[3, 1], m[3, 2], m[3, 3], m[3, 4] }, { m[4, 1], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] s22 = { { m[0, 0], m[0, 2], m[0, 3], m[0, 4] }, { m[2, 0], m[2, 2], m[2, 3], m[2, 4] }, { m[3, 0], m[3, 2], m[3, 3], m[3, 4] }, { m[4, 0], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] s23 = { { m[0, 0], m[0, 1], m[0, 3], m[0, 4] }, { m[2, 0], m[2, 1], m[2, 3], m[2, 4] }, { m[3, 0], m[3, 1], m[3, 3], m[3, 4] }, { m[4, 0], m[4, 1], m[4, 3], m[4, 4] } };
            int[,] s24 = { { m[0, 0], m[0, 1], m[0, 2], m[0, 4] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 4] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 4] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 4] } };
            int[,] s25 = { { m[0, 0], m[0, 1], m[0, 2], m[0, 3] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 3] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 3] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 3] } };

            int[,] s31 = { { m[0, 1], m[0, 2], m[0, 3], m[0, 4] }, { m[1, 1], m[1, 2], m[1, 3], m[1, 4] }, { m[3, 1], m[3, 2], m[3, 3], m[3, 4] }, { m[4, 1], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] s32 = { { m[0, 0], m[0, 2], m[0, 3], m[0, 4] }, { m[1, 0], m[1, 2], m[1, 3], m[1, 4] }, { m[3, 0], m[3, 2], m[3, 3], m[3, 4] }, { m[4, 0], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] s33 = { { m[0, 0], m[0, 1], m[0, 3], m[0, 4] }, { m[1, 0], m[1, 1], m[1, 3], m[1, 4] }, { m[3, 0], m[3, 1], m[3, 3], m[3, 4] }, { m[4, 0], m[4, 1], m[4, 3], m[4, 4] } };
            int[,] s34 = { { m[0, 0], m[0, 1], m[0, 2], m[0, 4] }, { m[1, 0], m[1, 1], m[1, 2], m[1, 4] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 4] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 4] } };
            int[,] s35 = { { m[0, 0], m[0, 1], m[0, 2], m[0, 3] }, { m[1, 0], m[1, 1], m[1, 2], m[1, 3] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 3] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 3] } };

            int[,] s41 = { { m[0, 1], m[0, 2], m[0, 3], m[0, 4] }, { m[1, 1], m[1, 2], m[1, 3], m[1, 4] }, { m[2, 1], m[2, 2], m[2, 3], m[2, 4] }, { m[4, 1], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] s42 = { { m[0, 0], m[0, 2], m[0, 3], m[0, 4] }, { m[1, 0], m[1, 2], m[1, 3], m[1, 4] }, { m[2, 0], m[2, 2], m[2, 3], m[2, 4] }, { m[4, 0], m[4, 2], m[4, 3], m[4, 4] } };
            int[,] s43 = { { m[0, 0], m[0, 1], m[0, 3], m[0, 4] }, { m[1, 0], m[1, 1], m[1, 3], m[1, 4] }, { m[2, 0], m[2, 1], m[2, 3], m[2, 4] }, { m[4, 0], m[4, 1], m[4, 3], m[4, 4] } };
            int[,] s44 = { { m[0, 0], m[0, 1], m[0, 2], m[0, 4] }, { m[1, 0], m[1, 1], m[1, 2], m[1, 4] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 4] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 4] } };
            int[,] s45 = { { m[0, 0], m[0, 1], m[0, 2], m[0, 3] }, { m[1, 0], m[1, 1], m[1, 2], m[1, 3] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 3] }, { m[4, 0], m[4, 1], m[4, 2], m[4, 3] } };

            int[,] s51 = { { m[0, 1], m[0, 2], m[0, 3], m[0, 4] }, { m[1, 1], m[1, 2], m[1, 3], m[1, 4] }, { m[2, 1], m[2, 2], m[2, 3], m[2, 4] }, { m[3, 1], m[3, 2], m[3, 3], m[3, 4] } };
            int[,] s52 = { { m[0, 0], m[0, 2], m[0, 3], m[0, 4] }, { m[1, 0], m[1, 2], m[1, 3], m[1, 4] }, { m[2, 0], m[2, 2], m[2, 3], m[2, 4] }, { m[3, 0], m[3, 2], m[3, 3], m[3, 4] } };
            int[,] s53 = { { m[0, 0], m[0, 1], m[0, 3], m[0, 4] }, { m[1, 0], m[1, 1], m[1, 3], m[1, 4] }, { m[2, 0], m[2, 1], m[2, 3], m[2, 4] }, { m[3, 0], m[3, 1], m[3, 3], m[3, 4] } };
            int[,] s54 = { { m[0, 0], m[0, 1], m[0, 2], m[0, 4] }, { m[1, 0], m[1, 1], m[1, 2], m[1, 4] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 4] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 4] } };
            int[,] s55 = { { m[0, 0], m[0, 1], m[0, 2], m[0, 3] }, { m[1, 0], m[1, 1], m[1, 2], m[1, 3] }, { m[2, 0], m[2, 1], m[2, 2], m[2, 3] }, { m[3, 0], m[3, 1], m[3, 2], m[3, 3] } };

            int[,] min = { { hesapla4x4(s11), hesapla4x4(s12), hesapla4x4(s13), hesapla4x4(s14), hesapla4x4(s15) }, {hesapla4x4(s21),hesapla4x4(s22),hesapla4x4(s23),hesapla4x4(s24),hesapla4x4(s25)},
                           {hesapla4x4(s31),hesapla4x4(s32),hesapla4x4(s33),hesapla4x4(s34),hesapla4x4(s35)}, {hesapla4x4(s41),hesapla4x4(s42),hesapla4x4(s43),hesapla4x4(s44),hesapla4x4(s45)},
                           {hesapla4x4(s51),hesapla4x4(s52),hesapla4x4(s53),hesapla4x4(s54),hesapla4x4(s55) } };
            return min;
        }
        void Minor(int[,] m)
        {
            int a = m.GetLength(0);
            int b = m.GetLength(1);
            if (a == b)
            {
                if (a == 2)
                {
                    MatrisWrite(m);
                    listBox1.Items.Add("MINOR............");
                    MatrisWrite(Minor2x2(m));
                }
                if (a == 3)
                {
                    MatrisWrite(m);
                    listBox1.Items.Add("MINOR............");
                    MatrisWrite(Minor3x3(m));
                }
                if (a == 4)
                {
                    MatrisWrite(m);
                    listBox1.Items.Add("MINOR............");
                    MatrisWrite(Minor4x4(m));
                }
                if (a == 5)
                {
                    MatrisWrite(m);
                    listBox1.Items.Add("MINOR............");
                    MatrisWrite(Minor5x5(m));
                }
            }
            else
            {
                listBox1.Items.Add("Minor ERROR!");
            }
        }
        private void btnMinor_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(k.InputBox("Enter The Number Of Matris"));
                listBox1.Items.Clear();
                listBox1.Items.Add("Matris " + number.ToString() + "...........");
                Minor(MatrisSarch(number));
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }
        }

        void MatrisMultiplyParamater(int[,] m, int number)
        {
            int[,] snc = new int[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    snc[i, j] = number * m[i, j];
                }
            }
            listBox1.Items.Add("Select Matris..........");
            MatrisWrite(m);
            listBox1.Items.Add("Matris Multiply Parameter.......");
            listBox1.Items.Add("Matris X " + number.ToString());
            MatrisWrite(snc);
        }
        private void btnMultiplyParameter_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(k.InputBox("Enter The Number Of Matris"));
                int paraMater = int.Parse(k.InputBox("Enter Number ....."));
                listBox1.Items.Clear();
                MatrisMultiplyParamater(MatrisSarch(number), paraMater);
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(ex.Message.ToString());
            }
        }
        int[,] MatrisCopy(int[,] m)
        {
            int[,] copy = new int[m.GetLength(0), m.GetLength(1)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    copy[i, j] = m[i, j];
                }
            }
            return copy;
        }
        void MatrisTranspoze(int[,] m)
        {
            int[,] aktar = new int[m.GetLength(0), m.GetLength(1)];
            aktar = MatrisCopy(m);
            
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = i; j < m.GetLength(1); j++)
                {
                    int dv = aktar[i, j];
                    aktar[i, j] = aktar[j, i];
                    aktar[j, i] = dv;
                }
            }

            listBox1.Items.Add("Select Matris..........");
            MatrisWrite(m);
            listBox1.Items.Add("Matris Transpoze.........");
            MatrisWrite(aktar);
        }
        private void btnTranspoze_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(k.InputBox("Enter The Number Of Matris"));
                listBox1.Items.Clear();
                MatrisTranspoze(MatrisSarch(number));
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        int[,] MatrisKofaktorConventer(int[,] m)
        {
            int a = m.GetLength(0);
            int b = m.GetLength(1);
            int[,] mConventer = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        mConventer[i, j] = m[i, j];
                    }
                    else
                    {
                        mConventer[i, j] = m[i, j] * -1;
                    }
                }
            }
            return mConventer;
        }
        void MatrisKofaktor(int[,] m)
        {
            int a = m.GetLength(0);
            int b = m.GetLength(1);
            int[,] minorMatris = new int[a, b];
            if (a == b)
            {
                listBox1.Items.Add("Select Matris.........");
                MatrisWrite(m);
                listBox1.Items.Add("KOFAKTOR..............");
                if (a==1)
                {
                    minorMatris=MatrisKofaktorConventer(m);
                }
                if (a==2)
                {
                    minorMatris = MatrisCopy(MatrisKofaktorConventer(Minor2x2(m)));
                }
                if (a==3)
                {
                    minorMatris = MatrisCopy(MatrisKofaktorConventer(Minor3x3(m)));
                }
                if (a==4)
                {
                    minorMatris = MatrisCopy(MatrisKofaktorConventer(Minor4x4(m)));
                }
                if (a==5)
                {
                    minorMatris = MatrisCopy(MatrisKofaktorConventer(Minor5x5(m)));
                }
                MatrisWrite(minorMatris);
            }
            else
            {
                listBox1.Items.Add("Kofaktor ERROR!");
            }
        }
        private void btnKofaktor_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(k.InputBox("Enter The Number Of Matris"));
                listBox1.Items.Clear();
                MatrisKofaktor(MatrisSarch(number));
            }
            catch (Exception ex)
            {
                listBox1.Items.Clear();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-';
        }

        private void btnRank_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                row = int.Parse(nx.Value.ToString());
                column = int.Parse(ny.Value.ToString());
                adet = row * column;
                lblAbout.Text = adet.ToString() + " More Enteres";
                listBox1.Items.Clear();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message.ToString());
            }

        }
        

    }
}
