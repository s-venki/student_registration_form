using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace studentregistration
{
    public partial class Mainform : Form
    {

        public Point mouseLocation;

        List<Control> shadowControls = new List<Control>();
        Bitmap shadowBmp = null;

        public string radiobuttonval = "";
        public string radiobuttonva = "";
        public Mainform()
        {
            InitializeComponent();
            shadowControls.Add(body);
            this.Refresh();
           
        }
        DataTable dt= new DataTable();

       
        private static void DrawShadowSmooth(GraphicsPath gp, int intensity, int radius, Bitmap dest)
        {
            using (Graphics g = Graphics.FromImage(dest))
            {
                g.Clear(Color.Transparent);
                g.CompositingMode = CompositingMode.SourceCopy;
                double alpha = 0;
                double astep = 0;
                double astepstep = (double)intensity / radius / (radius / 2D);
                for (int thickness = radius; thickness > 0; thickness--)
                {
                    using (Pen p = new Pen(Color.FromArgb((int)alpha, 0, 0, 0), thickness))
                    {
                        p.LineJoin = LineJoin.Round;
                        g.DrawPath(p, gp);
                    }
                    alpha += astep;
                    astep += astepstep;
                }
            }
        }


        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void Nametextbox_TextChanged(object sender, EventArgs e)
        { 
           try 
            {
                if (Nametextbox.Text == "")
                {
                    Nametextbox.Text = "Enter username ";
                    return;
                
                }
             Nametextbox.ForeColor=Color.White;
           
            } catch { }
          
        }

        private void Nametextbox_Click(object sender, EventArgs e)
        {
            Nametextbox.SelectAll();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Namepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click_1(object sender, EventArgs e)
        {

        }

        private void mailtextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (mailtextbox.Text == "")
                {
                    mailtextbox.Text = "demo@gmail.com ";
                    return;

                }
                mailtextbox.ForeColor = Color.White;

            }
            catch { }
        }

        private void mailtextbox_Click(object sender, EventArgs e)
        {
            mailtextbox.SelectAll();
        }

        private void hobbies_label_Click(object sender, EventArgs e)
        {

        }

        private void hobbies_textBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
               if(hobbies_textBox.Text == "")
                {
                    hobbies_textBox.Text = "Ex : Painting ";
                    return;

                }
                hobbies_textBox.ForeColor = Color.White;

            }
            catch { }
        }

        private void hobbies_textBox_Click(object sender, EventArgs e)
        {
            hobbies_textBox.SelectAll();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Mainform_Paint(object sender, PaintEventArgs e)
        {
            if (shadowBmp == null || shadowBmp.Size != this.Size)
            {
                shadowBmp?.Dispose();
                shadowBmp = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
            }
            foreach (Control control in shadowControls)
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddRectangle(new Rectangle(control.Location.X, control.Location.Y, control.Size.Width, control.Size.Height));
                    DrawShadowSmooth(gp, 100, 100, shadowBmp);
                }
                e.Graphics.DrawImage(shadowBmp, new Point(0, 0));
            }
        }

        private void phone_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (phone_textBox.Text == "")
                {
                    phone_textBox.Text = "enter mobile number";
                    return;

                }
                phone_textBox.ForeColor = Color.White;

            }
            catch { }
        }

        private void phone_textBox_Click(object sender, EventArgs e)
        {
            phone_textBox.SelectAll();
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void newform_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Nametextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nametextbox.Text) == true)
            {
                Nametextbox.Focus();
                MessageBox.Show("Enter your name");
            }
        }

        private void mailtextbox_Leave(object sender, EventArgs e)
        {
           
        }

        private void phone_textBox_Leave(object sender, EventArgs e)
        {

           
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            // to check the values in the radiobutton

            if (radiobuttonval == "Male")
            {
                radiobuttonva = "Male";

            }
            else
            {

                radiobuttonva = "Female";

            }


            dt.Columns["ID"].AutoIncrement = true;
            dt.Columns["ID"].AutoIncrementSeed = 1;
            dt.Columns["ID"].AutoIncrementStep = 1;
            dt.Rows.Add(null, Nametextbox.Text, mailtextbox.Text,phone_textBox.Text ,radiobuttonva, dateTimePicker.Text,hobbies_textBox.Text ,comboBox1.Text);



            //for regular expression


            Regex pattern = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool isvalid = pattern.IsMatch(mailtextbox.Text);
            Regex phonepattern = new Regex( "^[1-9]{10}");
            bool isvalid2 = phonepattern.IsMatch(phone_textBox.Text);

            if (!isvalid)
            {
                mailtextbox.Focus();
                MessageBox.Show("Invalid email");

            }
            
            if (!isvalid2)
            { 
               phone_textBox.Focus();
                MessageBox.Show("Invalid phone number");

               
            }


            else
            {
                MessageBox.Show("Your Form is succesfully registredy ");

            }


            ///text clear///
            Nametextbox.Text = "";
            mailtextbox.Text = "";
            phone_textBox.Text = "";
            radiobuttonva = "";
            dateTimePicker.Text = "";
            hobbies_textBox.Text = "";
            comboBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            
            foreach(RadioButton rb in panel1.Controls) 
            {
                rb.Checked = false;
            
            }

           

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", Type.GetType("System.Int32"));
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Email", Type.GetType("System.String"));
            dt.Columns.Add("MObile number", Type.GetType("System.Int64"));
            dt.Columns.Add("Gender", Type.GetType("System.String"));
           dt.Columns.Add("DOB", Type.GetType("System.String"));
            dt.Columns.Add("Hobbies", Type.GetType("System.String"));
            dt.Columns.Add("Qualifications", Type.GetType("System.String"));
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonval = "Male";
        }

        private void Female_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            radiobuttonval = "Female";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
              hobbies_textBox.Text = checkBox1.Text;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { hobbies_textBox.Text = checkBox2.Text; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked) { hobbies_textBox.Text=checkBox3.Text; }
        }
    }
}
