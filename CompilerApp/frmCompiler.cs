using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerApp
{
    public partial class mainForm : Form
    {
        string loc;
        string name = "";
        string type;
        
        public mainForm()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();
            string str = string.Empty;
            for (int i = 0; i < 50000; i++)
            {
                str += i.ToString();
            }
            t.Abort();
        }
        void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "C++ Compiler";
            frm.Icon = Properties.Resources.app;
            frm.ShowIcon = true;
            frm.ShowInTaskbar = true;
            Application.Run(frm);
        }
        void hiding()
        {
            l1.Hide();
            l2.Hide();
            l3.Hide();
            l4.Hide();
            l5.Hide();
            l6.Hide();
            l7.Hide();
            l8.Hide();
            l9.Hide();
            p1.Hide();
            p2.Hide();
            p3.Hide();
            p4.Hide();
            p5.Hide();
            p6.Hide();
            p7.Hide();
            p8.Hide();
            p9.Hide();
            lblComments.Hide();
            lblBlocks.Hide();
            lblErrors.Hide();
            lblIdentifier.Hide();
            lblKeywords.Hide();
            lblLiterals.Hide();
            lblNumbers.Hide();
            lblOperators.Hide();
            lbltotal.Hide();
        }

        void showing()
        {
            l1.Show();
            l2.Show();
            l3.Show();
            l4.Show();
            l5.Show();
            l6.Show();
            l7.Show();
            l8.Show();
            l9.Show();
            p1.Show();
            p2.Show();
            p3.Show();
            p4.Show();
            p5.Show();
            p6.Show();
            p7.Show();
            p8.Show();
            p9.Show();
            lblComments.Show();
            lblBlocks.Show();
            lblErrors.Show();
            lblIdentifier.Show();
            lblKeywords.Show();
            lblLiterals.Show();
            lblNumbers.Show();
            lblOperators.Show();
            lbltotal.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            ofd.Title = "Add .txt sample code";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                btnAnalyze.Enabled = true;
                dataGridMain.Rows.Clear();
                loc = ofd.FileName;
                var text = System.IO.File.ReadAllText(loc);
                txtShowCode.Text = text;
                txtShowCode.Show();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            btnAnalyze.Enabled = false;
            dataGridMain.Hide();
            txtShowCode.Hide();
            hiding();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtShowCode.Clear();
            dataGridMain.Rows.Clear();
            dataGridMain.Hide();
            txtShowCode.Hide();
            btnAnalyze.Enabled = false;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            dataGridMain.Show();
            txtShowCode.Show();
            int satr = 0;
            int sutun = 0;
            int state = 0;
            int BlockNo = 0;
            int row = 0;
            int max = 0;
            int min = 0;
            showing();
            dataGridMain.Rows.Clear();
            var lines = System.IO.File.ReadAllLines(loc);
            foreach (var line in lines)
            {
                string tokens = line;
                int tab = 0;
                for (int col = 0; col < tokens.Length; col++)
                {
                    switch (state)
                    {
                        case 0:
                            if (tokens[col] == ' ' || tokens[col] == '\t')
                            {
                                if (tokens[col] == '\t')
                                {
                                    tab += 7;
                                }
                                state = 0;
                            }
                            else if (tokens[col] == '/' && tokens[col + 1] == '*')
                            {
                                state = 1;
                                satr = row;
                                sutun = tab + col;
                                type = "Comment";
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == '/' && tokens[col + 1] == '/')
                            {
                                for (int i = col; i < tokens.Length; i++)
                                {
                                    name += tokens[i];
                                }
                                satr = row;
                                sutun = tab + col;
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, "Comment");
                                name = "";
                                col = tokens.Length - 1;
                                state = 0;
                            }
                            else if (tokens[col] == '.')
                            {
                                sutun = tab + col;
                                satr = row;
                                type = "Member OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, tokens[col].ToString(), type);
                                name = "";
                                state = 0;
                            }
                            else if (tokens[col] == '{' || tokens[col] == '}')
                            {
                                sutun = tab + col;
                                satr = row;
                                if (tokens[col] == '{')
                                {
                                    BlockNo = ++max;
                                    type = "Begin Block";
                                    dataGridMain.Rows.Add(satr, sutun, BlockNo, tokens[col].ToString(), type + " " + BlockNo.ToString());
                                }
                                else
                                {
                                    type = "End Block";
                                    dataGridMain.Rows.Add(satr, sutun, BlockNo, tokens[col].ToString(), type + " " + BlockNo.ToString());
                                    min = min + 1;
                                    BlockNo = (max) - min;
                                    if (BlockNo == 0)
                                    {
                                        min = 0;
                                    }
                                }
                                name = "";
                                state = 0;
                            }
                            else if (('a' <= tokens[col] && tokens[col] <= 'z') || ('A' <= tokens[col] && tokens[col] <= 'Z') || tokens[col] == '_')
                            {
                                state = 5;
                                name += tokens[col].ToString();
                                sutun = tab + col;
                                satr = row;
                            }
                            else if ('0' <= tokens[col] && tokens[col] <= '9')
                            {
                                state = 7;
                                sutun = tab + col;
                                satr = row;
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == '"')
                            {
                                state = 12;
                                sutun = tab + col;
                                satr = row;
                                type = "Literal";
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == '=')
                            {
                                state = 14;
                                sutun = tab + col;
                                satr = row;
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == '<' || tokens[col] == '>')
                            {
                                state = 15;
                                sutun = tab + col;
                                satr = row;
                                type = "Comparison OP";
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == ':' || tokens[col] == ';' || tokens[col] == ',')
                            {
                                sutun = tab + col;
                                satr = row;
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, tokens[col].ToString(), "Delimiter OP");
                            }
                            else if (tokens[col] == '-' || tokens[col] == '.')
                            {
                                state = 16;
                                sutun = tab + col;
                                satr = row;
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == '+' || tokens[col] == '*' || tokens[col] == '/' || tokens[col] == '%')
                            {
                                state = 17;
                                sutun = tab + col;
                                satr = row;
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == '(' || tokens[col] == ')')
                            {
                                sutun = tab + col;
                                satr = row;
                                if (tokens[col] == '(')
                                {
                                    type = "Begin Parenthese";
                                }
                                else
                                {
                                    type = "End Parenthese";
                                }
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, tokens[col].ToString(), type);
                                name = "";
                                state = 0;
                            }
                            else if (tokens[col] == '[' || tokens[col] == ']')
                            {
                                sutun = tab + col;
                                satr = row;
                                if (tokens[col] == '[')
                                {
                                    type = "Begin Bracket";
                                }
                                else
                                {
                                    type = "End Bracket";
                                }
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, tokens[col].ToString(), type);
                                name = "";
                                state = 0;
                            }
                            else if (tokens[col] == '&' || tokens[col] == '|' || tokens[col] == '^' || tokens[col] == '~')
                            {
                                state = 18;
                                satr = row;
                                sutun = tab + col;
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == '!')
                            {
                                state = 19;
                                satr = row;
                                sutun = tab + col;
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col].ToString() == "'")
                            {
                                state = 13;
                                satr = row;
                                sutun = tab + col;
                                name += tokens[col].ToString();

                            }
                            else
                            {
                                satr = row;
                                sutun = tab + col;
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, tokens[col].ToString(), "illegal");
                                name = "";
                                state = 0;
                            }
                            break;
                        case 1:
                            if (tokens[col] == '*')
                            {
                                state = 2;
                                name += tokens[col].ToString();
                            }
                            break;
                        case 2:
                            if (tokens[col] == '*')
                            {
                                state = 3;
                                name += tokens[col].ToString();
                            }
                            else
                            {
                                state = 2;
                                name += tokens[col].ToString();
                            }
                            break;
                        case 3:
                            if (tokens[col] == '*')
                            {
                                state = 3;
                                name += tokens[col].ToString();
                            }
                            else if (tokens[col] == '/')
                            {
                                state = 4;
                                name += tokens[col].ToString();
                                col--;
                            }
                            else
                            {
                                state = 2;
                                name += tokens[col].ToString();
                            }
                            break;
                        case 4:
                            dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            name = "";
                            state = 0;
                            break;
                        case 5:
                            if (('a' <= tokens[col] && tokens[col] <= 'z') || ('A' <= tokens[col] && tokens[col] <= 'Z') || tokens[col] == '_' || ('0' <= tokens[col] && tokens[col] <= '9'))
                            {
                                state = 5;
                                name += tokens[col].ToString();
                            }
                            else
                            {
                                state = 6;
                                col -= 2;
                            }
                            break;
                        case 6:
                            var keys = System.IO.File.ReadAllLines("keyword.txt");
                            bool flag = true;
                            foreach (var key in keys)
                            {
                                if (name == key)
                                {
                                    type = "Keyword";
                                    flag = false;
                                }
                            }
                            if (flag)
                            {
                                type = "Identifier";
                            }
                            dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            name = "";
                            state = 0;
                            break;
                        case 7:
                            if ('0' <= tokens[col] && tokens[col] <= '9')
                            {
                                state = 7;
                                name += tokens[col];
                            }
                            else if (tokens[col] == '.')
                            {
                                state = 9;
                                name += tokens[col];
                            }
                            else
                            {
                                state = 8;
                                col -= 2;
                            }
                            break;
                        case 8:
                            dataGridMain.Rows.Add(satr, sutun, BlockNo, name, "Integer");
                            name = "";
                            state = 0;
                            break;
                        case 9:
                            if ('0' <= tokens[col] && tokens[col] <= '9')
                            {
                                state = 10;
                                name += tokens[col].ToString();
                            }
                            break;
                        case 10:
                            if ('0' <= tokens[col] && tokens[col] <= '9')
                            {
                                state = 10;
                                name += tokens[col].ToString();
                            }
                            else
                            {
                                state = 11;
                                col -= 2;
                            }
                            break;
                        case 11:
                            dataGridMain.Rows.Add(satr, sutun, BlockNo, name, "Real");
                            name = "";
                            state = 0;
                            break;
                        case 12:
                            if (tokens[col] == '"')
                            {
                                name += tokens[col].ToString();
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                                name = "";
                                state = 0;
                            }
                            else
                            {
                                state = 12;
                                name += tokens[col].ToString();
                            }
                            break;
                        case 13:
                            if (tokens[col].ToString() == "'")
                            {
                                name += tokens[col].ToString();
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, "Literal");
                                name = "";
                                state = 0;
                            }
                            else
                            {
                                state = 13;
                                name += tokens[col].ToString();
                            }
                            break;
                        case 14:
                            if (tokens[col] == '=')
                            {
                                name += tokens[col].ToString();
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, "Comparison OP");
                            }
                            else
                            {
                                col--;
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, "Assignment OP");
                            }
                            name = "";
                            state = 0;
                            break;
                        case 15:
                            if (tokens[col] == '=')
                            {
                                name += tokens[col].ToString();
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            }
                            else if (name == "<" && tokens[col] == '<')
                            {
                                name += tokens[col].ToString();
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, "Bitwise OP");
                            }
                            else if (name == ">" && tokens[col] == '>')
                            {
                                name += tokens[col].ToString();
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, "Bitwise OP");
                            }
                            else
                            {
                                col--;
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            }
                            name = "";
                            state = 0;
                            break;
                        case 16:
                            if (tokens[col] == '-')
                            {
                                name += tokens[col].ToString();
                                type = "Decrement OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            }
                            else if (tokens[col] == '>')
                            {
                                name += tokens[col].ToString();
                                type = "Member OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            }
                            else if (tokens[col] == '=')
                            {
                                name += tokens[col].ToString();
                                type = "Assignment OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            }
                            else
                            {
                                type = "Arithmetic OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                                col--;
                            }
                            name = "";
                            state = 0;
                            break;
                        case 17:
                            if (tokens[col] == '=')
                            {
                                name += tokens[col].ToString();
                                type = "Assignment OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            }
                            else if (name == "+" && tokens[col] == '+')
                            {
                                name += tokens[col].ToString();
                                type = "Increment OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            }
                            else if (name == "*")
                            {
                                type = "Arithmetic OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                                col--;
                            }
                            else
                            {
                                type = "Arithmetic OP";
                                dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                                col--;
                            }
                            name = "";
                            state = 0;
                            break;
                        case 18:
                            if (name == "&" && tokens[col] == '&')
                            {
                                name += tokens[col].ToString();
                                type = "Logical OP";
                            }
                            else if (name == "|" && tokens[col] == '|')
                            {
                                name += tokens[col].ToString();
                                type = "Logical OP";
                            }
                            else if (tokens[col] == '=')
                            {
                                name += tokens[col].ToString();
                                type = "Assingment OP";
                            }
                            else
                            {
                                col--;
                                type = "Bitwise OP";

                            }
                            dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            name = "";
                            state = 0;
                            break;
                        case 19:
                            if (tokens[col] == '=')
                            {
                                name += tokens[col].ToString();
                                type = "Comparison OP";
                            }
                            else
                            {
                                col--;
                                type = "Logical OP";
                            }
                            dataGridMain.Rows.Add(satr, sutun, BlockNo, name, type);
                            name = "";
                            state = 0;
                            break;
                    }

                }

                row++;
            }
            for (int rows = 0; rows < dataGridMain.Rows.Count - 1; rows++)
            {
                string value = dataGridMain.Rows[rows].Cells[3].Value.ToString();
                if (value == "#")
                {
                    string next = dataGridMain.Rows[rows + 1].Cells[3].Value.ToString();
                    if (next == "include" || next == "define")
                    {
                        dataGridMain.Rows[rows].Cells[4].Value = "Operator";
                    }
                }
                else if (value == "*")
                {
                    string next = dataGridMain.Rows[rows - 1].Cells[4].Value.ToString();
                    if (next == "Keyword")
                    {
                        dataGridMain.Rows[rows].Cells[4].Value = "Pointer OP";
                    }
                }
                else if (value == ">>" || value == "<<")
                {
                    string next = dataGridMain.Rows[rows - 1].Cells[3].Value.ToString();
                    if (next == "cout" || next == "cin")
                    {
                        dataGridMain.Rows[rows].Cells[4].Value = "I/O OP";
                    }
                }
            }
            int keyword = 0;
            int id = 0;
            int num = 0;
            int literal = 0;
            int illegal = 0;
            int oper = 0;
            int token = 0;
            int comment = 0;
            for (int rows = 0; rows < dataGridMain.Rows.Count - 1; rows++)
            {
                string name = dataGridMain.Rows[rows].Cells[3].Value.ToString();
                string type = dataGridMain.Rows[rows].Cells[4].Value.ToString();
                if (type == "Keyword")
                {
                    keyword++;
                }
                else if (type == "Identifier")
                {
                    id++;
                }
                else if (type == "Real" || type == "Integer")
                {
                    num++;
                }
                else if (type == "Literal")
                {
                    literal++;
                }
                else if (type == "illegal")
                {
                    illegal++;
                }
                else if (type == "Comment")
                {
                    comment++;
                }
                else
                {
                    oper++;
                }
                token++;
            }
            lblKeywords.Text = keyword.ToString();
            lblIdentifier.Text = id.ToString();
            lblErrors.Text = illegal.ToString();
            lblBlocks.Text = max.ToString();
            lblLiterals.Text = literal.ToString();
            lblNumbers.Text = num.ToString();
            lblOperators.Text = (oper - (max * 2)).ToString();
            lbltotal.Text = token.ToString();
            lblComments.Text = comment.ToString();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }
    }
}
