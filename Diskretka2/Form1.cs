using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diskretka2
{
    public partial class Form1 : Form
    {

        int size;
        List<int[,]> matrix = new List<int[,]>();

        public Form1()
        {
            InitializeComponent();
        }

        private int get_int(TextBox box, ref bool isValid, bool binary)
        {
            int number = 0;
            try
            {
                number = Int32.Parse(box.Text);
                if (binary)
                {
                    if(number != 1 && number != 0)
                    {
                        isValid = false;
                        box.BackColor = Color.LightPink;
                    }
                    else
                    {
                        isValid = true;
                        box.BackColor = Color.White;
                    }
                }
                else
                {
                    isValid = true;
                    box.BackColor = Color.White;
                }
                
            }
            catch(System.FormatException)
            {
                isValid = false;
                box.BackColor = Color.LightPink;
            }
            return number;
        }

        private void warshall(ref List<int[,]> matrix, int size)
        {
            int[,] newMatrix = new int[size, size];

            for (int iteration = 0; iteration < size; iteration++)
            {
                newMatrix = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i == j || matrix[iteration][i, j] == 1)
                        {
                            newMatrix[i,j] = matrix[iteration][i, j];
                        }
                        else if (matrix[iteration][iteration, j] == 1 && matrix[iteration][i, iteration] == 1)
                        {
                            newMatrix[i, j] = 1;
                        }
                    }
                }
                matrix.Add(newMatrix);
            }
        }

        private void buttonRazmer_Click(object sender, EventArgs e)
        {
            matrix.Clear();
            matrixSelector.Items.Clear();
            groupBox4.Controls.Clear();

            bool isValid = false;
            size = get_int(textBoxRazmer, ref isValid, false);
            int posX = 200  - 33 * size / 2;
            int posY = 20;

            if (isValid)
            {
                groupBox2.Controls.Clear();
                for(int i = 0; i < size; i++)
                {
                    posX = 200 - 33 * size / 2;
                    for(int j = 0; j < size; j++)
                    {
                        TextBox m = new TextBox();
                        m.Location = new Point(posX, posY);
                        m.Size = new Size(30, 27);
                        m.MaxLength = 1;
                        groupBox2.Controls.Add(m);
                        posX += 33;
                    }
                    posY += 30;
                }
            }  
        }

        private void buttonRezultat_Click(object sender, EventArgs e)
        {
            groupBox4.Controls.Clear();
            matrixSelector.Items.Clear();

            var matrix_box = groupBox2.Controls.OfType<TextBox>();

            int[,] initial_matrix = new int[size, size];

            int id = 0;
            bool isValid = false;
            foreach (TextBox box in matrix_box)
            {
                int value = get_int(box, ref isValid, true);
                if(isValid)
                {
                    initial_matrix[id / size, id % size] = value;
                }
                id++;
            }

            if(isValid)
            {
                matrix.Add(initial_matrix);
                warshall(ref matrix, size);

                for(int i = 0; i < size; i++)
                {
                    matrixSelector.Items.Add("A" + (i + 1).ToString());
                }
            }

        }

        private void matrixSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = matrixSelector.SelectedIndex + 1;

            groupBox4.Controls.Clear();
            int posX = 200 - 33 * size / 2;
            int posY = 20;
            for (int i = 0; i < size; i++)
            {
                posX = 200 - 33 * size / 2;
                for (int j = 0; j < size; j++)
                {
                    TextBox m = new TextBox();
                    m.Location = new Point(posX, posY);
                    m.Size = new Size(30, 27);
                    m.MaxLength = 1;
                    m.Text = matrix[id][i, j].ToString();
                    m.ReadOnly = true;
                    if (matrix[id][i, j] != matrix[id - 1][i, j])
                    {
                        m.BackColor = Color.LightGreen;
                    }
                    groupBox4.Controls.Add(m);
                    posX += 33;
                }
                posY += 30;
            }
        }
    }
}
