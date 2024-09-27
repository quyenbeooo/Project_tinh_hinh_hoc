using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Project_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataListBox();
            SetupDataGridView();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            SetupDataGridView();
        }

        private void DataListBox()
        {
            string[] NameList = {
                "Hình Cầu", "Hình Thoi", "Hình Tròn", "Hình Nón", "Hình Trụ",
                "Hình Xoắn", "Hình Tứ Giác","Hình Thang", "Hình tam giác 1",
                "Hình tam giác 2", "Hình xuyên","Hình lăng trụ tam giác", "Hình tứ diện","Hình vành khăn",
                "Hình quạt 1","Hình quạt 2","Hình nón cụt","Hình quạt cầu","Hình đa giác nội tiếp","Hình chòm cầu 1",
                "Hình chòm cầu 2","Hình chóp đều","Hình chóp cụt đều","Hình cổ móng","Hình đới cầu"
            };
            listBox1.Items.AddRange(NameList);
        }
        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[0].Name = "Biến Số";
            dataGridView1.Columns[1].Name = "Giá Trị";

            dataGridView1.Columns[1].DefaultCellStyle.NullValue = "1";
            dataGridView1.AllowUserToAddRows = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) 
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                dataGridView1.Rows.Clear();
                
                string imageFolder = Application.StartupPath + @"\..\..\image\";
                switch (selectedItem)
                {
                    case "Hình Cầu":
                        dataGridView1.Rows.Add("R", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-cau.jpg");
                        textBox1.Text = "3/4*3,14159*R^3";
                        break;

                    case "Hình Thoi":
                        dataGridView1.Rows.Add("d1", "1");
                        dataGridView1.Rows.Add("d2", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-thoi.jpg");
                        textBox1.Text = "0,5*d1*d2";
                        break;

                    case "Hình Tròn":
                        dataGridView1.Rows.Add("R", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-tron.jpg");
                        textBox1.Text = "3,14159*R^2";
                        break;
                    case "Hình Nón":
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("h", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-non.jpg");
                        textBox1.Text = " 1/3*3,14159*R^2*h";
                        break;
                    case "Hình Trụ":
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("h", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-tru.png");
                        textBox1.Text = "3,14159*R^2*h";
                        break;
                    case "Hình Xoắn":
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("r", "1");
                        dataGridView1.Rows.Add("d2", "1");
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("d1", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-xoan.png");
                        textBox1.Text = "(3,14159*(R^2-r^2)*d2*h)/d1";
                        break;
                    case "Hình Tứ Giác":
                        dataGridView1.Rows.Add("d1", "1");
                        dataGridView1.Rows.Add("d2", "1");
                        dataGridView1.Rows.Add("a", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-tu-giac.png");
                        textBox1.Text = " 0,5*d1*d2*Sin(a*3,14159/180)";
                        break;
                    case "Hình Thang":
                        dataGridView1.Rows.Add("a", "1");
                        dataGridView1.Rows.Add("b", "1");
                        dataGridView1.Rows.Add("h", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-thang.png");
                        textBox1.Text = " 0,5*(a+b)*h";
                        break;
                    case "Hình tam giác 1":
                        dataGridView1.Rows.Add("a", "1");
                        dataGridView1.Rows.Add("h", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-tam-giac1.png");
                        textBox1.Text = "0,5*a*h";
                        break;
                    case "Hình tam giác 2":
                        dataGridView1.Rows.Add("a", "1");
                        dataGridView1.Rows.Add("b", "1");
                        dataGridView1.Rows.Add("c", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-tam-giac2.png");
                        textBox1.Text = "Sqrt((a+b+c)/2*((a+b+c)/2-a)*((a+b+c)/2-b)*((a+b+c)/2-c))";
                        break;
                    case "Hình xuyên":
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("r", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-xuyen.png");
                        textBox1.Text = "2*3,14159^2*((R+r)/2)*((R-r)/2)^2";
                        break;
                    case "Hình tứ diện":
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("a", "1");
                        dataGridView1.Rows.Add("b", "1");
                        dataGridView1.Rows.Add("c", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-tu-dien.png");
                        textBox1.Text = "1/3*h*Sqrt(((a+b+c)/2)*((a+b+c)/2-a)*((a+b+c)/2-b)*((a+b+c)/2-c))";
                        break;
                    case "Hình lăng trụ tam giác":
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("a", "1");
                        dataGridView1.Rows.Add("b", "1");
                        dataGridView1.Rows.Add("c", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-lang-tru-tam-giac.png");
                        textBox1.Text = "h*Sqrt(((a+b+c)/2)*((a+b+c)/2-a)*((a+b+c)/2-b)*((a+b+c)/2-c))";
                        break;
                    case "Hình vành khăn":
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("r", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-vanh-khan.png");
                        textBox1.Text = " 3,14159*(R^2-r^2)";
                        break;
                    case "Hình quạt 1":
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("a", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-quat1.png");
                        textBox1.Text = "0,5*R^2*(a*3,14159/180)";
                        break;
                    case "Hình quạt 2":
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("d1", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-quat2.png");
                        textBox1.Text = "R^2*Atan(d1/Sqrt(4*R^2-d1^2))";
                        break;
                    case "Hình nón cụt":
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("r", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-not-cut.png");
                        textBox1.Text = " 1/3*3,14159*h*(R^2+r^2+R*r)";
                        break;
                    case "Hình quạt cầu":
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("h", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-quat-cau.png");
                        textBox1.Text = " 2/3*3,14159*R^2*h";
                        break;
                    case "Hình đa giác nội tiếp":
                        dataGridView1.Rows.Add("n", "1");
                        dataGridView1.Rows.Add("R", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-da-giac-noi-tiep.png");
                        textBox1.Text = "0,5*n*R^2*Sin(2*3,14159/n)";
                        break;
                    case "Hình chòm cầu 1":
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("r", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-chom-cau1.png");
                        textBox1.Text = " h*3,14159/6*(h^2+3*r^2)";
                        break;
                    case "Hình chòm cầu 2":
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("R", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-chom-cau2.png");
                        textBox1.Text = " 3,14159*h^2*(R-h/3)";
                        break;
                    case "Hình chóp đều":
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("n", "1");
                        dataGridView1.Rows.Add("a", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-chop-deu.png");
                        textBox1.Text = "1/3*h*1/4*n*a^2*(1/Tan(3,14159/n))";
                        break;
                    case "Hình chóp cụt đều":
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("n", "1");
                        dataGridView1.Rows.Add("a1", "1");
                        dataGridView1.Rows.Add("a", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-chop-cut-deu.png");
                        textBox1.Text = "1/3*h*(1/4*n*a1^2*(1/Tan(3,14159/n))+1/4*n*a^2*(1/Tan(3,14159/n))+Sqrt(1/4*n*a1^2*(1/Tan(3,14159/n))*1/4*n*a^2*(1/Tan(3,14159/n))))";
                        break;
                    case "Hình cổ móng":
                        dataGridView1.Rows.Add("a1", "1");
                        dataGridView1.Rows.Add("b1", "1");
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("a", "1");
                        dataGridView1.Rows.Add("b", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-co-mong.png");
                        textBox1.Text = "a1*b1*h + ((a-a1)/2)*b1*h + ((b-b1)/2)*a1*h + 4*(((a-a1)/2)*((b-b1)/2)*h)/3";
                        break;
                    case "Hình đới cầu":
                        dataGridView1.Rows.Add("h", "1");
                        dataGridView1.Rows.Add("R", "1");
                        dataGridView1.Rows.Add("r", "1");
                        pictureBox1.Image = Image.FromFile(imageFolder + "hinh-doi-cau.png");
                        textBox1.Text = "(3,14159*h^3)/6+0,5*3,14159*h*(R^2+r^2)";
                        break;
                    default:
                        pictureBox1.Image = null;
                        break;
                }

                UpdateCT();
            }
        }

        private void UpdateCT()
        {
            try
            {
                string view = textBox1.Text;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string RowOne = dataGridView1.Rows[i].Cells[0].Value?.ToString() ?? "";
                    string RowTwo = dataGridView1.Rows[i].Cells[1].Value?.ToString() ?? "";

                    if (!string.IsNullOrEmpty(RowOne))
                    {
                        view = view.Replace(RowOne, RowTwo);
                    }
                }
                textBox3.Text = view; 
            }
            catch {}
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCT();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateCT();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void MSV_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình Cầu")
            {
                if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows[0].Cells[1].Value != null)
                {
                    double R;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R))
                    {
                        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);

                        textBox2.Text = volume.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Giá trị R không hợp lệ, vui lòng nhập số hợp lệ.");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình Thoi")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double d1, d2;

                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out d1) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out d2))
                    {
                        double area = 0.5 * d1 * d2;

                        textBox2.Text = area.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Giá trị d1 hoặc d2 không hợp lệ, vui lòng nhập số hợp lệ.");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình Tròn")
            {
                if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows[0].Cells[1].Value != null)
                {
                    double R;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R))
                    {
                        double Hinhtron = Math.PI * Math.Pow(R, 2);

                        textBox2.Text = Hinhtron.ToString("N2");
                    }

                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình Nón")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                     dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double R, h;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out h))
                    {
                        double Hinhnon = (1.0 / 3.0) * Math.PI * Math.Pow(R, 2) * h;

                        textBox2.Text = Hinhnon.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình Trụ")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double R, h;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out h))
                    {
                        double Hinhtru = Math.PI * Math.Pow(R, 2) * h;

                        textBox2.Text = Hinhtru.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình Xoắn")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null &&
                    dataGridView1.Rows[3].Cells[1].Value != null &&
                    dataGridView1.Rows[4].Cells[1].Value != null)
                {
                    double R, r, d2, h, d1;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out r) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out d2) &&
                        double.TryParse(dataGridView1.Rows[3].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[4].Cells[1].Value.ToString(), out d1))

                    {
                        double HinhXoan = (Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2)) * d2 * h) / d1;

                        textBox2.Text = HinhXoan.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình Tứ Giác")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null)
                {
                    double d1, d2, a;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out d1) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out d2) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out a))
                    {
                        double hinhtugiac = (1.0 / 2.0) * d1 * d2 * Math.Sin(a * Math.PI / 180);

                        textBox2.Text = hinhtugiac.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình Thang")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null)
                {
                    double a, b, h;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out a) &&
                        double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out b) &&
                        double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h))
                    {
                        double hinhthang = (1.0 / 2.0) * (a + b) * h;

                        textBox2.Text = hinhthang.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình tam giác 1")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double a, h;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out a) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out h))
                    {
                        double hinhtamgiac1 = (1.0 / 2.0) * a * h;

                        textBox2.Text = hinhtamgiac1.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình tam giác 2")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null)
                {
                    double a, b, c;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out a) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out b) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out c))
                    {
                        double s = (a + b + c) / 2.0;

                        double hinhtamgiac2 = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                        textBox2.Text = hinhtamgiac2.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình xuyên")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double R, r;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out r))
                    {
                        double hinhxuyen = 2 * Math.Pow(3.14159, 2) * ((R + r) / 2) * Math.Pow((R - r) / 2, 2);

                        textBox2.Text = hinhxuyen.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình lăng trụ tam giác")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null &&
                    dataGridView1.Rows[3].Cells[1].Value != null)
                {
                    double h, a, b, c;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out a) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out b) &&
                        double.TryParse(dataGridView1.Rows[3].Cells[1].Value.ToString(), out c))
                    {
                        double p = (a + b + c) / 2;

                        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                        double langtrutamgiac = s * h;

                        textBox2.Text = langtrutamgiac.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình tứ diện")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null &&
                    dataGridView1.Rows[3].Cells[1].Value != null)
                {
                    double h, a, b, c;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out a) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out b) &&
                        double.TryParse(dataGridView1.Rows[3].Cells[1].Value.ToString(), out c))
                    {
                        double p = (a + b + c) / 2;

                        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                        double hinhtudien = (1.0 / 3.0) * s * h;

                        textBox2.Text = hinhtudien.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình vành khăn")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double R, r;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out r))
                    {


                        double hinhvanhkhan = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));

                        textBox2.Text = hinhvanhkhan.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình quạt 1")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double R, a;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out a))
                    {


                        double hinhquat1 = 0.5 * Math.Pow(R, 2) * (a * 3.14159 / 180);

                        textBox2.Text = hinhquat1.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình quạt 2")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double R, d1;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out d1))
                    {


                        double hinhquat1 = Math.Pow(R, 2) * Math.Atan(d1 / Math.Sqrt(4 * Math.Pow(R, 2) - Math.Pow(d1, 2)));

                        textBox2.Text = hinhquat1.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình nón cụt")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null)
                {
                    double h, R, r;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out r))
                    {


                        double hinhnoncut = (1.0 / 3.0) * Math.PI * h * (Math.Pow(R, 2) + Math.Pow(r, 2) + R * r);

                        textBox2.Text = hinhnoncut.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình quạt cầu")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double R, h;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h))
                    {


                        double hinhquatcau = (2.0 / 3.0) * Math.PI * Math.Pow(R, 2) * h;

                        textBox2.Text = hinhquatcau.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình đa giác nội tiếp")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double n, R;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out n) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out R))
                    {


                        double hinhdagiacnoitiep = 0.5 * n * Math.Pow(R, 2) * Math.Sin((2 * Math.PI) / n);

                        textBox2.Text = hinhdagiacnoitiep.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình chòm cầu 1")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double h, r;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out r))
                    {


                        double hinhchomcau1 = Math.PI * h / 6 * (Math.Pow(h, 2) + 3 * Math.Pow(r, 2));

                        textBox2.Text = hinhchomcau1.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình chòm cầu 2")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null)
                {
                    double h, R;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out R))
                    {


                        double hinhchomcau1 = Math.PI * Math.Pow(h, 2) * (R - h / 3);

                        textBox2.Text = hinhchomcau1.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình chóp đều")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null)
                {
                    double h, n, a;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out n) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out a))
                    {
                        double hinhchopdeu = (1.0 / 3) * h * (1.0 / 4) * n * Math.Pow(a, 2) * (1.0 / Math.Tan(Math.PI / n));

                        textBox2.Text = hinhchopdeu.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình chóp cụt đều")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null &&
                    dataGridView1.Rows[3].Cells[1].Value != null)
                {
                    double h, n, a1, a;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out n) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out a1) &&
                        double.TryParse(dataGridView1.Rows[3].Cells[1].Value.ToString(), out a))
                    {
                        // Tính phần diện tích các đáy và phần trung gian
                        double term1 = (1.0 / 4) * n * Math.Pow(a1, 2) * (1.0 / Math.Tan(Math.PI / n));
                        double term2 = (1.0 / 4) * n * Math.Pow(a, 2) * (1.0 / Math.Tan(Math.PI / n));
                        double term3 = Math.Sqrt(term1 * term2);

                        double hinhchopcutdeu = (1.0 / 3) * h * (term1 + term2 + term3);

                        textBox2.Text = hinhchopcutdeu.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình cổ móng")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null &&
                    dataGridView1.Rows[3].Cells[1].Value != null &&
                    dataGridView1.Rows[4].Cells[1].Value != null)
                {
                    double a1, b1, h, a, b;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out a1) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out b1) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[3].Cells[1].Value.ToString(), out a) &&
                        double.TryParse(dataGridView1.Rows[4].Cells[1].Value.ToString(), out b))
                    {

                        // Tính các phần thể tích
                        double term1 = a1 * b1 * h;
                        double term2 = ((a - a1) / 2) * b1 * h;
                        double term3 = ((b - b1) / 2) * a1 * h;
                        double term4 = (4.0 / 3) * ((a - a1) / 2) * ((b - b1) / 2) * h;

                        double hinhcomong = term1 + term2 + term3 + term4;

                        textBox2.Text = hinhcomong.ToString("N2");
                    }
                }
            }

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.ToString() == "Hình đới cầu")
            {
                if (dataGridView1.Rows.Count > 0 &&
                    dataGridView1.Rows[0].Cells[1].Value != null &&
                    dataGridView1.Rows[1].Cells[1].Value != null &&
                    dataGridView1.Rows[2].Cells[1].Value != null)
                {
                    double h, R, r;
                    if (double.TryParse(dataGridView1.Rows[0].Cells[1].Value.ToString(), out h) &&
                        double.TryParse(dataGridView1.Rows[1].Cells[1].Value.ToString(), out R) &&
                        double.TryParse(dataGridView1.Rows[2].Cells[1].Value.ToString(), out r))
                    {

                        // Tính các phần của thể tích
                        double term1 = (3.14159 * Math.Pow(h, 3)) / 6;
                        double term2 = 0.5 * 3.14159 * h * (Math.Pow(R, 2) + Math.Pow(r, 2));

                        double hinhdoicau = term1 + term2;

                        textBox2.Text = hinhdoicau.ToString("N2");
                    }
                }
            }
        }
    }
}
