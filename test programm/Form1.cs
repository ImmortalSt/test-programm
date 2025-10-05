using System.Drawing.Text;

namespace test_programm
{
    public partial class Form1 : Form
    {
        private string fontPath = "fonts/Comforter-Regular.ttf";
        private Font customFont;

        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        //// ��������� ����� � ��������� ���������
        //privateFonts.AddFontFile(fontPath);

        //// ������� ������ Font �� ������������ ������
        //// ������ �������� - ������, ������ - �����
        //customFont = new Font(privateFonts.Families[0], 150f, FontStyle.Regular, GraphicsUnit.Point);


        private bool isDragging = false;
        private Point startPoint;


        private int isForm = 1600;

        public Form1()
        {
            InitializeComponent();
            MainStr();
            this.Size = new Size(isForm, 900);

            Panel panel = new Panel()
            {
                Width = this.Size.Width,
                Height = 30,
                //BackColor = Color.White,
            };

            this.Controls.Add(panel);

            // ����������� �����������
            panel.MouseDown += TitleBar_MouseDown;
            panel.MouseMove += TitleBar_MouseMove;
            panel.MouseUp += TitleBar_MouseUp;

            this.BackColor = Color.FromArgb(255, 250, 247); // ��������� �����


        }


        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  // ���� ������ ����� ������ ����
            {
                isDragging = true;              // "�������� ����� ��������������"
                startPoint = new Point(e.X, e.Y); // "����������, ��� ������"
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)  // "���� �� � ������ ��������������"
            {
                Point p = PointToScreen(e.Location);  // ������ ��� ������ ������ �� ������
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y); // ������� �����
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;  // "��������� ����� ��������������"
        }

        Button Enter = new Button();        //����
        Button Exit = new Button();         //�����
        Button Registr = new Button();      //�����������
        Button Recover = new Button();      //������������ ������

        PictureBox fon = new PictureBox();
        PictureBox login = new PictureBox();
        PictureBox pass = new PictureBox();
        PictureBox eye = new PictureBox();
        Label nameTest = new Label();

        private void MainStr()
        {
            // �������� ���������
            nameTest.Text = "����������� ���������";
            nameTest.Location = new Point(30, 31);
            nameTest.Name = "nameTest";
            nameTest.AutoSize = true;
            nameTest.Font = new Font("Comforter-Regular", 42, FontStyle.Bold); ;
            nameTest.BringToFront();
            this.Controls.Add(nameTest);

            // ��� 1 ����
            fon.Image = Image.FromFile("img/Regist.png");
            fon.Location = new Point(668, 30);
            fon.Name = "mainFon";
            fon.Size = new Size(1008, 900);
            fon.SizeMode = PictureBoxSizeMode.Zoom;
            fon.TabIndex = 0;
            fon.TabStop = false;
            fon.SendToBack();


            this.Controls.Add(fon);

            // �����
            login.Image = Image.FromFile("object/entry_cell.png");
            login.Location = new Point(76, 185);
            login.Name = "login";
            login.Size = new Size(481, 95);
            login.SizeMode = PictureBoxSizeMode.AutoSize;
            login.TabIndex = 0;
            login.TabStop = false;

            this.Controls.Add(login);

            // ������
            pass.Image = Image.FromFile("object/entry_cell.png");
            pass.Location = new Point(76, 293);
            pass.Name = "pass";
            pass.Size = new Size(481, 95);
            pass.SizeMode = PictureBoxSizeMode.AutoSize;
            pass.TabIndex = 0;
            pass.TabStop = false;

            this.Controls.Add(pass);

            // �������� ������            
            eye.Image = Image.FromFile("button/eye.png");
            eye.Location = new Point(561, 303);
            eye.Name = "eye";
            eye.Size = new Size(481, 95);
            eye.SizeMode = PictureBoxSizeMode.AutoSize;
            eye.TabIndex = 0;
            eye.TabStop = false;

            this.Controls.Add(eye);

            // ������ �����
            Enter.Location = new Point(142, 426);
            Enter.Name = "Enter";
            Enter.Size = new Size(305 + 20, 74 + 20);
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.TabIndex = 0;
            Enter.Image = Image.FromFile("button/Enter.png");
            Enter.UseVisualStyleBackColor = true;

            this.Controls.Add(Enter);
            Enter.GotFocus += (sender, e) =>
            {
                this.ActiveControl = null; // ������� ����� � ������.
            };

            // ������ �����������
            Registr.Location = new Point(144, 540);
            Registr.Name = "Registr";
            Registr.Size = new Size(305 + 20, 74 + 20);
            Registr.FlatAppearance.BorderSize = 0;
            Registr.FlatStyle = FlatStyle.Flat;
            Registr.TabIndex = 0;
            Registr.Image = Image.FromFile("button/Register.png");
            Registr.UseVisualStyleBackColor = true;

            this.Controls.Add(Registr);

            // ������ ������������
            Recover.Location = new Point(144, 652);
            Recover.Name = "Recover";
            Recover.Size = new Size(305 + 20, 74 + 20);
            Recover.FlatAppearance.BorderSize = 0;
            Recover.FlatStyle = FlatStyle.Flat;
            Recover.TabIndex = 0;
            Recover.Image = Image.FromFile("button/Recover.png");
            Recover.UseVisualStyleBackColor = true;

            this.Controls.Add(Recover);

            // ������ �����
            Registr.Location = new Point(144, 757);
            Registr.Name = "Exit";
            Registr.Size = new Size(305 + 20, 74 + 20);
            Registr.FlatAppearance.BorderSize = 0;
            Registr.FlatStyle = FlatStyle.Flat;
            Registr.TabIndex = 0;
            Registr.Image = Image.FromFile("button/Exit.png");
            Registr.UseVisualStyleBackColor = true;

            this.Controls.Add(Exit);


        }


    }
}
