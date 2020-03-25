using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms_Rudnev
{
    public partial class Form2 : Form
    {
        TreeView treeview;
        Panel panel;
        Button btn, btn2, btn3, btn4, btn5;
        public int n;
        public int m=15;
        CheckBox check1,check2,check3;
        RadioButton rb1,rb2,rb3,rb4,rb5,rb6,rb7;
        PictureBox pbox1, pbox2;
        ListBox lBox;
        RichTextBox rtbox;
        
        public Form2()
        {
            this.Text = "Форма с разными элементами управления";
            this.Size = new Size(800,800);
            treeview = new TreeView();
            treeview.Width = 200;
            treeview.BackColor = Color.LightBlue;
            treeview.Dock = DockStyle.Left;
            treeview.BorderStyle = BorderStyle.Fixed3D;
            TreeNode tn = new TreeNode("Элементы Управления");
            
            tn.Expand();
            tn.Nodes.Add(new TreeNode("Label-Надпись"));
            tn.Nodes.Add(new TreeNode("Button-Кнопка"));
            tn.Nodes.Add(new TreeNode("CheckBox-Флажок"));
            tn.Nodes.Add(new TreeNode("RadioButton-Переключатель"));
            tn.Nodes.Add(new TreeNode("TabControl-Вкладки"));
            tn.Nodes.Add(new TreeNode("Listbox-Список"));
            tn.Nodes.Add(new TreeNode("RichTextBox-Текст"));
            tn.Nodes.Add(new TreeNode("Clear-Очистить"));

            Width = 1200;
 
            treeview.Nodes.Add(tn);
            treeview.AfterSelect += Treeview_AfterSelect;

            panel = new Panel();
            panel.Dock = DockStyle.Right;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Width = this.Width - treeview.Width;
            panel.BackColor = Color.Gray;

            Controls.Add(treeview);
            Controls.Add(panel);
        }

        private void Treeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text== "Label-Надпись")
            {
                Label label = new Label();
                label.Text = "Это метка.\n Вторая строка метки";
                n = label.Text.Length * 10;
                label.Width = n;
                label.Font = new Font("Arial",20);
                m = label.Font.Height;
                label.Height = m*2;
                label.Location = new Point(panel.Width / 2,10);
                label.ForeColor = Color.Navy;
                label.BackColor = Color.AntiqueWhite;
                
                panel.Controls.Add(label);
               
            }
            else if(e.Node.Text=="Button-Кнопка")
            {

                Button btn = new Button();
                btn.Text = "Нажми на кнопку";
                btn.Location = new Point(10,m*2+13);
                btn.ForeColor = Color.Navy;
                btn.BackColor = Color.AntiqueWhite;
                btn.Width = 160;
                btn.Height = 60;
                btn.Click += Btn_Click;
                
                panel.Controls.Add(btn);
            }
            else if (e.Node.Text == "CheckBox-Флажок")
            {
                check1 = new CheckBox();
                check1.Text = "Сварщик";
                check1.Location = new Point(20, m * 2 + 83);
                check1.ForeColor = Color.Navy;
                check1.Font = new Font("Arial", 16);

                check1.Height = 200;
                check1.Width = 300;

                check2 = new CheckBox();
                check2.Text = "Повар";
                check2.Location = new Point(20, m * 2 + 283);
                check2.ForeColor = Color.Navy;
                check2.Font = new Font("Arial", 16);
                check2.Height = 200;
                check2.Width = 300;

                check3 = new CheckBox();
                check3.Font = new Font("Arial", 16);
                check3.Text= "Программист";
                check3.Location = new Point(20, m * 2 + 483);
                check3.ForeColor = Color.Navy;

                
                check3.Height = 200;
                check3.Width = 300;
                

                panel.Controls.Add(check1);
                panel.Controls.Add(check2);
                panel.Controls.Add(check3);
                check1.Click += Check1_Click;
                check2.Click += Check2_Click;
                check3.Click += Check3_Click;
            }
            else if (e.Node.Text== "RadioButton-Переключатель")
            {

                rb1 = new RadioButton();
                rb1.Text = "1";
                rb1.Height = 40;
                rb1.ForeColor = Color.NavajoWhite;
                rb1.Font = new Font("Arial", 16);
                rb1.Location = new Point(400,m*2+53);


                rb2 = new RadioButton();
                rb2.Text = "2";
                rb2.Height = 40;
                rb2.ForeColor = Color.NavajoWhite;
                rb2.Font = new Font("Arial", 16);
                rb2.Location = new Point(400,m*2+93);

                rb3 = new RadioButton();
                rb3.Text = "3";
                rb3.Height = 40;
                rb3.ForeColor = Color.NavajoWhite;
                rb3.Font = new Font("Arial", 16);
                rb3.Location = new Point(400, m * 2 + 133);

                

                panel.Controls.Add(rb1);
                panel.Controls.Add(rb2);
                panel.Controls.Add(rb3);
                rb1.Click += Rb1_Click;
                rb2.Click += Rb2_Click;
                rb3.Click += Rb3_Click;
            }
            else if (e.Node.Text == "TabControl-Вкладки")
            {
               
                TabControl tc = new TabControl();
                tc.Size = new Size(500, 400);
                tc.Location= new Point(450,300);
                TabPage tp1= new TabPage("Собака");
                pbox1 = new PictureBox();
               
                pbox1.Size = new Size(500,300);
                pbox1.SizeMode = PictureBoxSizeMode.StretchImage;


                TabPage tp2 = new TabPage("Будка");
                pbox2 = new PictureBox();
                pbox2.Size = new Size(500, 300);
                pbox2.SizeMode = PictureBoxSizeMode.StretchImage;


                rb4 = new RadioButton();
                rb4.Text = "Овчарка";
                rb4.Height = 40;
                rb4.Width = 160;
                rb4.ForeColor = Color.Black;
                rb4.Font = new Font("Arial", 16);
                rb4.Location = new Point(350, m * 2 + 270);

                rb5 = new RadioButton();
                rb5.Text = "Лабрадор";
                rb5.Height = 40;
                rb5.Width = 160;
                rb5.ForeColor = Color.Black;
                rb5.Font = new Font("Arial", 16);
                rb5.Location = new Point(350, m * 2 + 300);


                rb6 = new RadioButton();
                rb6.Text = "Обычная Будка";
                rb6.Height = 40;
                rb6.Width = 260;
                rb6.ForeColor = Color.Black;
                rb6.Font = new Font("Arial", 16);
                rb6.Location = new Point(300, m * 2 + 270);

                rb7 = new RadioButton();
                rb7.Text = "Будка получше";
                rb7.Height = 40;
                rb7.Width = 260;
                rb7.ForeColor = Color.Black;
                rb7.Font = new Font("Arial", 16);
                rb7.Location = new Point(300, m * 2 + 300);

                tp1.Controls.Add(rb4);
                tp1.Controls.Add(rb5);

                tp2.Controls.Add(rb6);
                tp2.Controls.Add(rb7);

                tp1.Controls.Add(pbox1);
                tc.TabPages.Add(tp1);


                tp2.Controls.Add(pbox2);
                tc.TabPages.Add(tp2);

                panel.Controls.Add(tc);
                rb4.Click += Rb4_Click;
                rb5.Click += Rb5_Click;
                rb6.Click += Rb6_Click;
                rb7.Click += Rb7_Click;



            }
            else if(e.Node.Text== "Clear-Очистить")
            {
                panel.Controls.Clear();
                treeview.BackColor = Color.LightBlue;
                panel.BackColor = Color.Gray;
            }
            else if (e.Node.Text == "Listbox-Список")
            {
                Button btn4 = new Button();
                btn4.Text = "Конвертировать";
                btn4.Location = new Point(500, 190);
                btn4.ForeColor = Color.Navy;
                btn4.BackColor = Color.AntiqueWhite;
                btn4.Width = 100;
                btn4.Height = 40;
                btn4.Click += Btn4_Click;



                lBox = new ListBox();
                lBox.Width = 100;

                lBox.Items.Add("Желтый");
                lBox.Items.Add("Зеленый");
                lBox.Items.Add("Красный");
                lBox.Items.Add("Синий");
                lBox.Items.Add("Серый");
                lBox.Location = new Point(500,88);

                lBox.DoubleClick += LBox_DoubleClick;

                panel.Controls.Add(lBox);
                panel.Controls.Add(btn4);
                lBox.SelectedIndexChanged += new EventHandler ( LBox_SelectedIndexChanged);
            }
            else if(e.Node.Text== "RichTextBox-Текст")
            {
                Button btn2 = new Button();
                btn2.Text = "Сохранить";
                btn2.Location = new Point(720,90);
                btn2.ForeColor = Color.Navy;
                btn2.BackColor = Color.AntiqueWhite;
                btn2.Width = 80;
                btn2.Height = 30;
                btn2.Click += Btn2_Click;

                Button btn3 = new Button();
                btn3.Text = "Открыть";
                btn3.Location = new Point(720, 122);
                btn3.ForeColor = Color.Navy;
                btn3.BackColor = Color.AntiqueWhite;
                btn3.Width = 80;
                btn3.Height = 30;
                btn3.Click += Btn3_Click;

                Button btn5 = new Button();
                btn5.Text = "Очистить";
                btn5.Location = new Point(720, 152);
                btn5.ForeColor = Color.Navy;
                btn5.BackColor = Color.AntiqueWhite;
                btn5.Width = 80;
                btn5.Height = 30;
                btn5.Click += Btn5_Click;
        
                rtbox = new RichTextBox();
                rtbox.LoadFile("..//..//images/TextFile1.txt",RichTextBoxStreamType.PlainText);

                rtbox.WordWrap = true;
                rtbox.BorderStyle = BorderStyle.Fixed3D;

                rtbox.Size = new Size(100, 100);
                rtbox.Location = new Point(610, 90);

                
                panel.Controls.Add(rtbox);
                panel.Controls.Add(btn2);
                panel.Controls.Add(btn3);
                panel.Controls.Add(btn5);
            }
        }

        private void LBox_DoubleClick(object sender, EventArgs e)
        {
            rtbox.Text = lBox.SelectedItem.ToString();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            rtbox.Clear();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            rtbox.Clear();
            for (int i=0;i<lBox.Items.Count;i++)
            {
                rtbox.Text = rtbox.Text + "\n" + lBox.Items[i];
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {   
            
            rtbox.LoadFile("..//..//images/TextFile1.txt", RichTextBoxStreamType.PlainText);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            rtbox.SaveFile("..//..//images/TextFile1.txt", RichTextBoxStreamType.PlainText);
            File.WriteAllText(@"C:/Users/opilane/source/repos/WindowsForms_Rudnev/images/TextFile1.txt", rtbox.Text, Encoding.UTF8);
        }

        private void LBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lBox.SelectedItems.ToString())
            {
                case ("Желтый"):treeview.BackColor = Color.Yellow;break;
                case ("Зеленый"): treeview.BackColor = Color.Green; break;
                case ("Красный"): treeview.BackColor = Color.Red; break;
                case ("Синий"): treeview.BackColor = Color.Blue; break;
                case ("Серый"): treeview.BackColor = Color.Gray; break;
            }
            if (lBox.SelectedIndex==0)
            {
              
                lBox.BackColor = Color.Yellow;
                treeview.BackColor = Color.Yellow;
                
            }
            if (lBox.SelectedIndex == 1)
            {
            
                lBox.BackColor = Color.Green;
                treeview.BackColor = Color.Green;
            }
            if (lBox.SelectedIndex == 2)
            {
    
                lBox.BackColor = Color.Red;
                treeview.BackColor = Color.Red;
            }
            if (lBox.SelectedIndex == 3)
            {

                lBox.BackColor = Color.Blue;
                treeview.BackColor = Color.Blue;
            }
            if (lBox.SelectedIndex == 4)
            {

                lBox.BackColor = Color.Gray;
                treeview.BackColor = Color.Gray;
            }

        }

        private void Rb7_Click(object sender, EventArgs e)
        {
            pbox2.Image = new Bitmap("..//..//images//budka.jpg");
        }

        private void Rb6_Click(object sender, EventArgs e)
        {
            pbox2.Image = new Bitmap("..//..//images//budka2.jpg");
        }

        private void Rb5_Click(object sender, EventArgs e)
        {
            pbox1.Image = new Bitmap("..//..//images//labrador.jpg");
        }

        private void Rb4_Click(object sender, EventArgs e)
        {
            pbox1.Image = new Bitmap("..//..//images//ovcharka.jpg");
        }


        private void Check3_Click(object sender, EventArgs e)
        {
            if (check1.Checked && check2.Checked && check3.Checked == true)
            {
                check1.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check3.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            if (check1.Checked && check3.Checked == true)
            {
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.dengi;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            else if (check1.Checked && check3.Checked == false)
            {
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.gray;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            if (check3.Checked && check2.Checked == true)
            {
                check1.Image = global::WindowsForms_Rudnev.Properties.Resources.eda;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";
            }


            if (check3.Checked)
            {
                treeview.Font = new Font("Times New roman", 10);
                check3.Text = "";
                check3.Image = global::WindowsForms_Rudnev.Properties.Resources.prog1;
                treeview.BackColor = Color.Red;
                treeview.ForeColor = Color.LightGreen;
                check3.Font = new Font("Times New roman", 22);

            }
            else
            {
                check3.Text = "Программист";
                treeview.BackColor = Color.Green;
                treeview.ForeColor = Color.LightCyan;
                check3.Image = global::WindowsForms_Rudnev.Properties.Resources.gray;
                treeview.Font = new Font("Times New roman", 12);
                check3.Font = new Font("Times New roman", 20);
            }
        }

        private void Check2_Click(object sender, EventArgs e)
        {
            if (check1.Checked && check2.Checked && check3.Checked == true)
            {
                check1.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check3.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            if (check1.Checked && check3.Checked == true)
            {
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.dengi;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            else if (check1.Checked && check3.Checked == false)
            {
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.gray;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            if (check3.Checked && check2.Checked == true)
            {
                check1.Image = global::WindowsForms_Rudnev.Properties.Resources.eda;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";
            }

            if (check2.Checked)
            {
                treeview.Font = new Font("Times New roman", 10);
                check2.Text = "";
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.pov;
                treeview.BackColor = Color.DarkOrange;
                treeview.ForeColor = Color.Orange;
                check2.Font = new Font("Times New roman", 22);
            }
            else
            {
                check2.Text = "Повар";
                treeview.BackColor = Color.LightGray;
                treeview.ForeColor = Color.DarkSlateGray;
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.gray;
                treeview.Font = new Font("Times New roman", 12);
                check2.Font = new Font("Times New roman", 20);
            }
        }

        private void Check1_Click(object sender, EventArgs e)
        {
            if (check1.Checked && check2.Checked && check3.Checked == true)
            {
                check1.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check3.Image = global::WindowsForms_Rudnev.Properties.Resources.morzh;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            if (check1.Checked && check3.Checked == true)
            {
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.dengi;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            else if (check1.Checked && check3.Checked == false)
            {
                check2.Image = global::WindowsForms_Rudnev.Properties.Resources.gray;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";

            }
            if (check3.Checked && check2.Checked == true)
            {
                check1.Image = global::WindowsForms_Rudnev.Properties.Resources.eda;
                check1.Text = "";
                check2.Text = "";
                check3.Text = "";
            }



            if (check1.Checked)
            {
                treeview.Font = new Font("Times New roman", 10);
                check1.Text = "";
                check1.Image = global::WindowsForms_Rudnev.Properties.Resources.svar;
                treeview.BackColor = Color.Navy;
                treeview.ForeColor = Color.LightBlue;
                check1.Font = new Font("Times New roman", 22);
            }
            else
            {
                check1.Text = "Сварщик";
                treeview.BackColor = Color.LightPink;
                treeview.ForeColor = Color.DarkMagenta;
                check1.Image = global::WindowsForms_Rudnev.Properties.Resources.gray;
                treeview.Font = new Font("Times New roman", 12);
                check1.Font = new Font("Times New roman", 20);
            }
        }

        private void Rb3_Click(object sender, EventArgs e)
        {
            rb1.Font = new Font("Arial", 10);
            rb2.Font = new Font("Arial", 10);
            rb3.Font = new Font("Arial", 10);
            rb1.ForeColor = Color.Navy;
            rb2.ForeColor = Color.Blue;
            rb3.ForeColor = Color.LightBlue;
            treeview.ForeColor = Color.Navy;
        }

        private void Rb2_Click(object sender, EventArgs e)
        {
            rb1.Font = new Font("Times New roman", 15);
            rb2.Font = new Font("Times New roman", 15);
            rb3.Font = new Font("Times New roman", 15);
            rb1.ForeColor = Color.Red;
            rb2.ForeColor = Color.DarkRed;
            rb3.ForeColor = Color.OrangeRed;
            treeview.ForeColor = Color.DarkRed;
        }

        private void Rb1_Click(object sender, EventArgs e)
        {
            rb1.Font = new Font("Arial", 20);
            rb2.Font = new Font("Arial", 20);
            rb3.Font = new Font("Arial", 20);
            rb1.ForeColor = Color.Green;
            rb3.ForeColor = Color.LightGreen;
            rb2.ForeColor = Color.DarkSeaGreen;
            treeview.ForeColor = Color.DarkOliveGreen;

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
        }
    }
}