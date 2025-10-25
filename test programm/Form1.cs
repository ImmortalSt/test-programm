using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace test_programm
{
    public partial class Form1 : Form
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        //��������� �������
        private void LoadCustomFont()
        {
            try
            {
                // ������ 1: �������� �� ���������� �������� �������
                byte[] fontData = Properties.Resources.Comforter_Regular; // "MyCustomFont" - ��� �������
                byte[] fontData2 = Properties.Resources.ofont_ru_LeoHand;

                // ��������� ����� � ������
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                privateFonts.AddMemoryFont(fontPtr, fontData.Length);
                Marshal.FreeCoTaskMem(fontPtr);

                // ��������� ������ �����
                IntPtr fontPtr2 = Marshal.AllocCoTaskMem(fontData2.Length);
                Marshal.Copy(fontData2, 0, fontPtr2, fontData2.Length);
                privateFonts.AddMemoryFont(fontPtr2, fontData2.Length);
                Marshal.FreeCoTaskMem(fontPtr2);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������� ������: {ex.Message}");
                // ���������� ����������� ����� � ������ ������
                //privateFonts.AddFontFamily("Arial");
            }
        }

        private bool isDragging = false;
        private Point startPoint;


        private int isForm = 1600;

        public Form1()
        {
            InitializeComponent();
            LoadCustomFont();

            MainStr();
            RegisterStr();
            TestMain();
            MainAdmin();
            AddTesting();
            AllRatingStr();
            SelectionTest();
            PassingTheTest();
            OnOffRegisterStr(false);
            OnOffTestMain(false);
            OnOffMainAdmin(false);
            OnOffAllRatingStr(false);
            OnOffSelectionTest(false);
            OnOffAddTesting(false);
            OnOffPassingTheTest(false);

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


        private void OnOffMainStr(bool isOn)
        {
            Enter.Enabled = isOn;
            Enter.Visible = isOn;
            Exit.Enabled = isOn;
            Exit.Visible = isOn;
            Registr.Enabled = isOn;
            Registr.Visible = isOn;
            Recover.Enabled = isOn;
            Recover.Visible = isOn;

            fon.Enabled = isOn;
            fon.Visible = isOn;
            login.Enabled = isOn;
            login.Visible = isOn;
            pass.Enabled = isOn;
            pass.Visible = isOn;
            eye.Enabled = isOn;
            eye.Visible = isOn;
            nameTest.Enabled = isOn;
            nameTest.Visible = isOn;
            nameStart.Enabled = isOn;
            nameStart.Visible = isOn;
            loginStart.Enabled = isOn;
            loginStart.Visible = isOn;
        }

        private void OnOffRegisterStr(bool isOn)
        {
            AddReg.Enabled = isOn;
            AddReg.Visible = isOn;
            ReturnReg.Enabled = isOn;
            ReturnReg.Visible = isOn;

            fonRegistr.Enabled = isOn;
            fonRegistr.Visible = isOn;
            nameReg.Enabled = isOn;
            nameReg.Visible = isOn;
            loginReg.Enabled = isOn;
            loginReg.Visible = isOn;
            passReg.Enabled = isOn;
            passReg.Visible = isOn;
            nameRegStr.Enabled = isOn;
            nameRegStr.Visible = isOn;
        }

        private void OnOffTestMain(bool isOn)
        {
            TEST.Enabled = isOn;
            TEST.Visible = isOn;
            OtherUser.Enabled = isOn;
            OtherUser.Visible = isOn;
            AllRating.Enabled = isOn;
            AllRating.Visible = isOn;
            MyRating.Enabled = isOn;
            MyRating.Visible = isOn;
            Administrator.Enabled = isOn;
            Administrator.Visible = isOn;
            ExitTest.Enabled = isOn;
            ExitTest.Visible = isOn;

            fonTest.Enabled = isOn;
            fonTest.Visible = isOn;
            user.Enabled = isOn;
            user.Visible = isOn;
            nameUser.Enabled = isOn;
            nameUser.Visible = isOn;
        }

        private void OnOffMainAdmin(bool isOn)
        {
            AddTest.Enabled = isOn;
            AddTest.Visible = isOn;
            RedactedTest.Enabled = isOn;
            RedactedTest.Visible = isOn;
            DeleteTest.Enabled = isOn;
            DeleteTest.Visible = isOn;
            ReturnAdmin.Enabled = isOn;
            ReturnAdmin.Visible = isOn;
            ExitAdmin.Enabled = isOn;
            ExitAdmin.Visible = isOn;

            fonMenuAdmin.Enabled = isOn;
            fonMenuAdmin.Visible = isOn;
            MenuAdmin.Enabled = isOn;
            MenuAdmin.Visible = isOn;
            userAdmin.Enabled = isOn;
            userAdmin.Visible = isOn;
            nameUserAdmin.Enabled = isOn;
            nameUserAdmin.Visible = isOn;
        }

        private void OnOffAllRatingStr(bool isOn)
        {
            ReturnAllRating.Enabled = isOn;
            ReturnAllRating.Visible = isOn;

            fonAllRating.Enabled = isOn;
            fonAllRating.Visible = isOn;
            userAllRating.Enabled = isOn;
            userAllRating.Visible = isOn;
            nameUserAllRating.Enabled = isOn;
            nameUserAllRating.Visible = isOn;

            lineHoriz.Enabled = isOn;
            lineHoriz.Visible = isOn;
            lineVert.Enabled = isOn;
            lineVert.Visible = isOn;
        }

        //��������� ��������
        PictureBox Enter = new PictureBox();        //����
        PictureBox Exit = new PictureBox();         //�����
        PictureBox Registr = new PictureBox();      //�����������
        PictureBox Recover = new PictureBox();      //������������ ������

        PictureBox fon = new PictureBox();
        PictureBox login = new PictureBox();
        PictureBox pass = new PictureBox();
        PictureBox eye = new PictureBox();
        Label nameTest = new Label();
        TextBox nameStart = new TextBox();
        Label loginStart = new Label();

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);


        private void MainStr()
        {
            // �������� ���������
            nameTest.Text = "����������� ���������";
            nameTest.Location = new Point(30, 20);
            nameTest.Name = "nameTest";
            nameTest.AutoSize = true;
            nameTest.Font = new Font(privateFonts.Families[0], 72, FontStyle.Bold);
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
            login.Location = new Point(76, 185 + 20);
            login.Name = "login";
            login.Size = new Size(481, 95);
            login.SizeMode = PictureBoxSizeMode.AutoSize;
            login.TabIndex = 0;
            login.TabStop = false;

            this.Controls.Add(login);

            // ���� ������
            nameStart.Text = "�����";
            nameStart.PlaceholderText = "�����";
            nameStart.Location = new Point(110, 220);
            nameStart.Name = "nameStart";
            nameStart.Size = new Size(415, 40);
            nameStart.Font = new Font(privateFonts.Families[1], 20, FontStyle.Bold);
            nameStart.BackColor = Color.FromArgb(104, 201, 190); // ��������� �����
            nameStart.BorderStyle = BorderStyle.None;   // ������� �����
            nameStart.ForeColor = Color.Gray;           // ���� ���������
            nameStart.BringToFront();

            this.Controls.Add(nameStart);
            this.Controls.SetChildIndex(nameStart, 0);

            // ������� ����� ��� �����������
            nameStart.GotFocus += (sender, e) =>
            {
                if (nameStart.Text == "�����")
                {
                    nameStart.Text = "";
                    nameStart.ForeColor = Color.Black;
                    HideCaret(nameStart.Handle); // ������ ������
                }
            };

            // ���������� ���������, ���� ���� ������
            nameStart.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(nameStart.Text))
                {
                    nameStart.Text = "�����";
                    nameStart.ForeColor = Color.Gray;
                }
            };

            // ������
            pass.Image = Image.FromFile("object/entry_cell.png");
            pass.Location = new Point(76, 293 + 20);
            pass.Name = "pass";
            pass.Size = new Size(481, 95);
            pass.SizeMode = PictureBoxSizeMode.AutoSize;
            pass.TabIndex = 0;
            pass.TabStop = false;

            this.Controls.Add(pass);

            // �������� ������            
            eye.Image = Image.FromFile("button/eye.png");
            eye.Location = new Point(561, 303 + 20);
            eye.Name = "eye";
            eye.Size = new Size(481, 95);
            eye.SizeMode = PictureBoxSizeMode.AutoSize;
            eye.TabIndex = 0;
            eye.TabStop = false;

            this.Controls.Add(eye);

            // ������ �����
            Enter.Location = new Point(144, 426);
            Enter.Name = "Enter";
            Enter.Size = new Size(305 + 20, 74 + 20);
            Enter.TabIndex = 0;
            Enter.Image = Image.FromFile("button/Enter.png");

            this.Controls.Add(Enter);

            // ���������� �������� ���������
            Enter.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                Enter.Image = Image.FromFile("button/EnterColor.png");
            };

            Enter.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                Enter.Image = Image.FromFile("button/Enter.png");
            };

            Enter.Click += (sender, e) =>
            {
                OnOffMainStr(false);
                OnOffTestMain(true);
                nameStart.Clear();
            };

            // ������ �����������
            Registr.Location = new Point(144, 540);
            Registr.Name = "Registr";
            Registr.Size = new Size(305 + 20, 74 + 20);
            Registr.TabIndex = 0;
            Registr.Image = Image.FromFile("button/Register.png");

            this.Controls.Add(Registr);

            // ���������� �������� ���������
            Registr.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                Registr.Image = Image.FromFile("button/RegisterColor.png");
            };

            Registr.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                Registr.Image = Image.FromFile("button/Register.png");
            };

            Registr.Click += (sender, e) =>
            {
                OnOffMainStr(false);
                OnOffRegisterStr(true);
            };



            // ������ ������������
            Recover.Location = new Point(144, 652);
            Recover.Name = "Recover";
            Recover.Size = new Size(305 + 20, 74 + 20);
            Recover.TabIndex = 0;
            Recover.Image = Image.FromFile("button/Recover.png");

            this.Controls.Add(Recover);

            // ���������� �������� ���������
            Recover.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                Recover.Image = Image.FromFile("button/RecoverColor.png");
            };

            Recover.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                Recover.Image = Image.FromFile("button/Recover.png");
            };

            // ������ �����
            Exit.Location = new Point(144, 757);
            Exit.Name = "Exit";
            Exit.Size = new Size(305 + 20, 74 + 20);
            Exit.TabIndex = 0;
            Exit.Image = Image.FromFile("button/Exit.png");

            this.Controls.Add(Exit);

            // ���������� �������� ���������
            Exit.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                Exit.Image = Image.FromFile("button/ExitColor.png");
            };

            Exit.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                Exit.Image = Image.FromFile("button/Exit.png");
            };

            Exit.Click += (sender, e) => { this.Close(); }; //���������� ������� Click

        }

        PictureBox AddReg = new PictureBox();        //�������
        PictureBox ReturnReg = new PictureBox();     //����� � ���� �����������

        PictureBox fonRegistr = new PictureBox();
        PictureBox nameReg = new PictureBox();
        PictureBox loginReg = new PictureBox();
        PictureBox passReg = new PictureBox();
        Label nameRegStr = new Label();

        private void RegisterStr()
        {
            // �������� ��������
            nameRegStr.Text = "�����������";
            nameRegStr.Location = new Point(100, 20);
            nameRegStr.Name = "nameRegStr";
            nameRegStr.AutoSize = true;
            nameRegStr.Font = new Font(privateFonts.Families[0], 72, FontStyle.Regular);
            nameRegStr.BringToFront();

            this.Controls.Add(nameRegStr);

            // ��� ���� �����������
            fonRegistr.Image = Image.FromFile("img/RegistName.png");
            fonRegistr.Location = new Point(668, 30);
            fonRegistr.Name = "FonRegistr";
            fonRegistr.Size = new Size(983, 900);
            fonRegistr.SizeMode = PictureBoxSizeMode.Zoom;
            fonRegistr.TabIndex = 0;
            fonRegistr.TabStop = false;
            fonRegistr.SendToBack();

            this.Controls.Add(fonRegistr);

            // ��� ��� �����������
            nameReg.Image = Image.FromFile("object/entry_cell.png");
            nameReg.Location = new Point(80, 205);
            nameReg.Name = "nameReg";
            nameReg.Size = new Size(481, 95);
            nameReg.SizeMode = PictureBoxSizeMode.AutoSize;
            nameReg.TabIndex = 0;
            nameReg.TabStop = false;

            this.Controls.Add(nameReg);

            // �����
            loginReg.Image = Image.FromFile("object/entry_cell.png");
            loginReg.Location = new Point(80, 354);
            loginReg.Name = "login";
            loginReg.Size = new Size(481, 95);
            loginReg.SizeMode = PictureBoxSizeMode.AutoSize;
            loginReg.TabIndex = 0;
            loginReg.TabStop = false;

            this.Controls.Add(loginReg);

            // ������
            passReg.Image = Image.FromFile("object/entry_cell.png");
            passReg.Location = new Point(80, 522);
            passReg.Name = "passReg";
            passReg.Size = new Size(481, 95);
            passReg.SizeMode = PictureBoxSizeMode.AutoSize;
            passReg.TabIndex = 0;
            passReg.TabStop = false;

            this.Controls.Add(passReg);

            // ������ �������
            AddReg.Location = new Point(128, 650);
            AddReg.Name = "Enter";
            AddReg.Size = new Size(357 + 20, 75 + 20);
            AddReg.TabIndex = 0;
            AddReg.Image = Image.FromFile("button/Registration.png");

            this.Controls.Add(AddReg);

            // ���������� �������� ���������
            AddReg.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                AddReg.Image = Image.FromFile("button/RegistrationColor.png");
            };

            AddReg.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                AddReg.Image = Image.FromFile("button/Registration.png");
            };

            // ������ �����
            ReturnReg.Location = new Point(128, 760);
            ReturnReg.Name = "ReturnReg";
            ReturnReg.Size = new Size(357 + 20, 75 + 20);
            ReturnReg.TabIndex = 0;
            ReturnReg.Image = Image.FromFile("button/ReturnReg.png");

            this.Controls.Add(ReturnReg);

            // ���������� �������� ���������
            ReturnReg.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ReturnReg.Image = Image.FromFile("button/ReturnRegColor.png");
            };

            ReturnReg.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ReturnReg.Image = Image.FromFile("button/ReturnReg.png");
            };

            ReturnReg.Click += (sender, e) =>
            {
                OnOffRegisterStr(false);
                OnOffMainStr(true);
            };

        }


        // ������� �������� ���������
        PictureBox TEST = new PictureBox();          //������ ������
        PictureBox OtherUser = new PictureBox();     //������� ������������
        PictureBox AllRating = new PictureBox();     //������� ���� �������������
        PictureBox MyRating = new PictureBox();      //��� �������
        PictureBox Administrator = new PictureBox(); //�����������������
        PictureBox ExitTest = new PictureBox();

        PictureBox fonTest = new PictureBox();
        Label user = new Label();
        Label nameUser = new Label();

        private void TestMain()
        {
            //user
            user.Text = "User";
            user.Location = new Point(0, 20);
            user.Name = "user";
            user.AutoSize = true;
            user.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold); ;
            user.BringToFront();

            this.Controls.Add(user);

            nameUser.Text = "...";
            nameUser.Location = new Point(70, 20);
            nameUser.Name = "userName";
            nameUser.AutoSize = true;
            nameUser.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold); ;
            nameUser.BringToFront();

            this.Controls.Add(nameUser);

            this.Controls.SetChildIndex(user, 0);
            this.Controls.SetChildIndex(nameUser, 0);

            // ��� test
            fonTest.Image = Image.FromFile("img/fonTestMain.png");
            fonTest.Location = new Point(0, 30);
            fonTest.Name = "testFon";
            fonTest.Size = new Size(1600, 875);
            fonTest.SizeMode = PictureBoxSizeMode.Zoom;
            fonTest.TabIndex = 0;
            fonTest.TabStop = false;
            fonTest.SendToBack();

            this.Controls.Add(fonTest);

            // ��������� ������ ������ PictureBox
            using (Graphics g = Graphics.FromImage(fonTest.Image))
            {
                using (Font font = new Font(privateFonts.Families[0], 96, FontStyle.Bold))
                {
                    g.DrawString("����������� ���������", font, Brushes.Black, new PointF(350, 0));
                }
            }
            fonTest.Invalidate(); // ��������� PictureBox, ����� ��������� ������������

            // ������ TEST
            TEST.Location = new Point(411, 170);
            TEST.Name = "TEST";
            TEST.Size = new Size(305 + 20, 52 + 20);
            TEST.BackColor = Color.FromArgb(252, 243, 224); // ��������� �����
            TEST.TabIndex = 0;
            TEST.Image = Image.FromFile("button/Test.png");

            this.Controls.Add(TEST);
            TEST.BringToFront();

            // ���������� �������� ���������
            TEST.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                TEST.Image = Image.FromFile("button/TestColor.png");
            };

            TEST.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                TEST.Image = Image.FromFile("button/Test.png");
            };

            TEST.Click += (sender, e) =>
             {
                 OnOffTestMain(false);
                 OnOffSelectionTest(true);
             };

            // ������ ������� ������������
            OtherUser.Location = new Point(617, 260);
            OtherUser.Name = "OtherUser";
            OtherUser.Size = new Size(305 + 20, 74 + 20);
            OtherUser.BackColor = Color.FromArgb(252, 243, 224); // ��������� �����
            OtherUser.TabIndex = 0;
            OtherUser.Image = Image.FromFile("button/OtherUser.png");

            this.Controls.Add(OtherUser);
            OtherUser.BringToFront();

            // ���������� �������� ���������
            OtherUser.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                OtherUser.Image = Image.FromFile("button/OtherUserColor.png");
            };

            OtherUser.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                OtherUser.Image = Image.FromFile("button/OtherUser.png");
            };

            OtherUser.Click += (sender, e) =>
            {
                OnOffTestMain(false);
                OnOffMainStr(true);

            };

            // ������ �����
            ExitTest.Location = new Point(617, 360);
            ExitTest.Name = "ExitTest";
            ExitTest.Size = new Size(305 + 20, 74 + 20);
            ExitTest.BackColor = Color.FromArgb(252, 243, 224); // ��������� �����
            ExitTest.TabIndex = 0;
            ExitTest.Image = Image.FromFile("button/ExitTestMain.png");

            this.Controls.Add(ExitTest);
            ExitTest.BringToFront();

            // ���������� �������� ���������
            ExitTest.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ExitTest.Image = Image.FromFile("button/ExitTestMainColor.png");
            };

            ExitTest.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ExitTest.Image = Image.FromFile("button/ExitTestMain.png");
            };

            ExitTest.Click += (sender, e) => { this.Close(); }; //���������� ������� Click

            // ������ Admin
            Administrator.Location = new Point(1127, 373);
            Administrator.Name = "Admin";
            Administrator.Size = new Size(305 + 20, 52 + 20);
            Administrator.BackColor = Color.FromArgb(252, 243, 224); // ��������� �����
            Administrator.TabIndex = 0;
            Administrator.Image = Image.FromFile("button/Admin.png");

            this.Controls.Add(Administrator);
            Administrator.BringToFront();

            // ���������� �������� ���������
            Administrator.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                Administrator.Image = Image.FromFile("button/AdminColor.png");
            };

            Administrator.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                Administrator.Image = Image.FromFile("button/Admin.png");
            };

            Administrator.Click += (sender, e) =>
            {
                OnOffMainAdmin(true);
                OnOffTestMain(false);
            };

            // ������ MyRating
            MyRating.Location = new Point(430, 454);
            MyRating.Name = "MyRating";
            MyRating.Size = new Size(305 + 20, 52 + 20);
            MyRating.BackColor = Color.FromArgb(252, 243, 224); // ��������� �����
            MyRating.TabIndex = 0;
            MyRating.Image = Image.FromFile("button/MyRating.png");

            this.Controls.Add(MyRating);
            MyRating.BringToFront();

            // ���������� �������� ���������
            MyRating.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                MyRating.Image = Image.FromFile("button/MyRatingColor.png");
            };

            MyRating.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                MyRating.Image = Image.FromFile("button/MyRating.png");
            };

            // ������ Rating
            AllRating.Location = new Point(697, 792);
            AllRating.Name = "Rating";
            AllRating.Size = new Size(305 + 20, 52 + 20);
            AllRating.BackColor = Color.FromArgb(252, 243, 224); // ��������� �����
            AllRating.TabIndex = 0;
            AllRating.Image = Image.FromFile("button/AllRating.png");

            this.Controls.Add(AllRating);
            AllRating.BringToFront();

            // ���������� �������� ���������
            AllRating.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                AllRating.Image = Image.FromFile("button/AllRatingColor.png");
            };

            AllRating.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                AllRating.Image = Image.FromFile("button/AllRating.png");
            };

            AllRating.Click += (sender, e) =>
            {
                OnOffTestMain(false);
                OnOffAllRatingStr(true);
            };


        }

        // ������ ��������������
        PictureBox AddTest = new PictureBox();           //�������� ����
        PictureBox RedactedTest = new PictureBox();      //������������� ����
        PictureBox DeleteTest = new PictureBox();        //������� ����
        PictureBox ReturnAdmin = new PictureBox();       //������� � ������� �����
        PictureBox ExitAdmin = new PictureBox();

        PictureBox MenuAdmin = new PictureBox();
        PictureBox fonMenuAdmin = new PictureBox();
        Label userAdmin = new Label();
        Label nameUserAdmin = new Label();

        private void MainAdmin()
        {
            //user
            userAdmin.Text = "User";
            userAdmin.Location = new Point(0, 20);
            userAdmin.Name = "userAdmin";
            userAdmin.AutoSize = true;
            userAdmin.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold); ;
            userAdmin.BringToFront();

            this.Controls.Add(userAdmin);

            nameUserAdmin.Text = "...";
            nameUserAdmin.Location = new Point(70, 20);
            nameUserAdmin.Name = "userNameAdmin";
            nameUserAdmin.AutoSize = true;
            nameUserAdmin.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold); ;
            nameUserAdmin.BringToFront();

            this.Controls.Add(nameUserAdmin);

            fonMenuAdmin.Image = Image.FromFile("img/fonMenuAdmin.png");
            fonMenuAdmin.Location = new Point(0, 30);
            fonMenuAdmin.Name = "fonMenuAdmin";
            fonMenuAdmin.Size = new Size(1600, 875);
            fonMenuAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            fonMenuAdmin.TabIndex = 0;
            fonMenuAdmin.TabStop = false;
            fonMenuAdmin.SendToBack();

            this.Controls.Add(fonMenuAdmin);

            MenuAdmin.Image = Image.FromFile("img/MenuAdmin.png");
            MenuAdmin.Location = new Point(260, 140);
            MenuAdmin.Name = "MenuAdmin";
            MenuAdmin.Size = new Size(1052, 613);
            MenuAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            MenuAdmin.TabIndex = 0;
            MenuAdmin.TabStop = false;
            MenuAdmin.BringToFront();

            this.Controls.Add(MenuAdmin);

            // ��������� ������ ������ PictureBox
            using (Graphics g = Graphics.FromImage(MenuAdmin.Image))
            {
                using (Font font = new Font(privateFonts.Families[0], 96, FontStyle.Bold))
                {
                    g.DrawString("���� ������", font, Brushes.Black, new PointF(170, 0));
                }
            }
            MenuAdmin.Invalidate(); // ��������� PictureBox, ����� ��������� ������������

            this.Controls.SetChildIndex(fonMenuAdmin, 1000);
            this.Controls.SetChildIndex(MenuAdmin, 0);

            // ������ AddTest
            AddTest.Location = new Point(958, 193);
            AddTest.Name = "AddTest";
            AddTest.Size = new Size(305 + 20, 71 + 20);
            AddTest.BackColor = Color.FromArgb(49, 136, 242); // ��������� �����
            AddTest.TabIndex = 0;
            AddTest.Image = Image.FromFile("button/AddTest.png");

            this.Controls.Add(AddTest);
            AddTest.BringToFront();

            // ���������� �������� ���������
            AddTest.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                AddTest.Image = Image.FromFile("button/AddColor.png");
            };

            AddTest.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                AddTest.Image = Image.FromFile("button/AddTest.png");
            };

            AddTest.Click += (sender, e) =>
            {
                OnOffMainAdmin(false);
                OnOffAddTesting(true);
            };


            // ������ RedactedTest
            RedactedTest.Location = new Point(958, 290);
            RedactedTest.Name = "RedactedTest";
            RedactedTest.Size = new Size(305 + 20, 71 + 20);
            RedactedTest.BackColor = Color.FromArgb(49, 136, 242); // ��������� �����
            RedactedTest.TabIndex = 0;
            RedactedTest.Image = Image.FromFile("button/Redaction.png");

            this.Controls.Add(RedactedTest);
            RedactedTest.BringToFront();

            // ���������� �������� ���������
            RedactedTest.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                RedactedTest.Image = Image.FromFile("button/RedactionColor.png");
            };

            RedactedTest.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                RedactedTest.Image = Image.FromFile("button/Redaction.png");
            };

            // ������ DeleteTest
            DeleteTest.Location = new Point(958, 390);
            DeleteTest.Name = "DeleteTest";
            DeleteTest.Size = new Size(305 + 20, 71 + 20);
            DeleteTest.BackColor = Color.FromArgb(49, 136, 242); // ��������� �����
            DeleteTest.TabIndex = 0;
            DeleteTest.Image = Image.FromFile("button/DeleteTest.png");

            this.Controls.Add(DeleteTest);
            DeleteTest.BringToFront();

            // ���������� �������� ���������
            DeleteTest.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                DeleteTest.Image = Image.FromFile("button/DeleteColor.png");
            };

            DeleteTest.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                DeleteTest.Image = Image.FromFile("button/DeleteTest.png");
            };


            // ������ Return
            ReturnAdmin.Location = new Point(958, 497);
            ReturnAdmin.Name = "Admin";
            ReturnAdmin.Size = new Size(305 + 20, 71 + 20);
            ReturnAdmin.BackColor = Color.FromArgb(49, 136, 242); // ��������� �����
            ReturnAdmin.TabIndex = 0;
            ReturnAdmin.Image = Image.FromFile("button/Return.png");

            this.Controls.Add(ReturnAdmin);
            ReturnAdmin.BringToFront();

            // ���������� �������� ���������
            ReturnAdmin.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ReturnAdmin.Image = Image.FromFile("button/ReturnColor.png");
            };

            ReturnAdmin.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ReturnAdmin.Image = Image.FromFile("button/Return.png");
            };

            ReturnAdmin.Click += (sender, e) =>
            {
                OnOffMainAdmin(false);
                OnOffTestMain(true);
            };

            // ������ �����
            ExitAdmin.Location = new Point(958, 642);
            ExitAdmin.Name = "ExitTest";
            ExitAdmin.Size = new Size(305 + 20, 71 + 20);
            ExitAdmin.BackColor = Color.FromArgb(49, 136, 242); // ��������� �����
            ExitAdmin.TabIndex = 0;
            ExitAdmin.Image = Image.FromFile("button/ExitTestMain.png");

            this.Controls.Add(ExitAdmin);
            ExitAdmin.BringToFront();

            // ���������� �������� ���������
            ExitAdmin.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ExitAdmin.Image = Image.FromFile("button/ExitTestMainColor.png");
            };

            ExitAdmin.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ExitAdmin.Image = Image.FromFile("button/ExitTestMain.png");
            };

            ExitAdmin.Click += (sender, e) => { this.Close(); }; //���������� ������� Click         

        }

        // �������� ����
        PictureBox ButtonAddThema = new PictureBox();           //�������� ����
        PictureBox ButtonPictureThema = new PictureBox();       //�������� �������� � ����
        PictureBox ButtonAddQuestion = new PictureBox();        //�������� ������
        PictureBox ButtonAddAnswers = new PictureBox();         //������� �������� �������
        PictureBox ButtonAddRAnswers = new PictureBox();        //�������� �������� ���������� �������
        PictureBox ButtonMenuAdminAdd = new PictureBox();       //������ �������� � ���� ������
        PictureBox ButtonReturnAdd = new PictureBox();          //������ �������� � ������� ���� ���������
        PictureBox ButtonExitAdd = new PictureBox();            //������ ����� �� ���������

        PictureBox AddThema = new PictureBox();                 //����
        PictureBox AddQuestion = new PictureBox();              //������
        PictureBox AddAnswer1 = new PictureBox();               //�������� ������� ������ 1
        PictureBox AddAnswer2 = new PictureBox();               //�������� ������� ������ 2
        PictureBox AddAnswer3 = new PictureBox();               //�������� ������� ������ 3
        PictureBox AddRAnswer1 = new PictureBox();              //�������� ������� ����������� ������ 1
        PictureBox AddRAnswer2 = new PictureBox();              //������� ������� ����������� ������ 2

        PictureBox fonAddAdmin = new PictureBox();
        Label userAddAdmin = new Label();
        Label nameUserAddAdmin = new Label();

        // ��������� �������� �������� ����
        private void OnOffAddTesting(bool isOn)
        {
            ButtonAddThema.Enabled = isOn; ButtonAddThema.Visible = isOn;
            ButtonPictureThema.Enabled = isOn; ButtonPictureThema.Visible = isOn;
            ButtonAddQuestion.Enabled = isOn; ButtonAddQuestion.Visible = isOn;
            ButtonAddAnswers.Enabled = isOn; ButtonAddAnswers.Visible = isOn;
            ButtonAddRAnswers.Enabled = isOn; ButtonAddRAnswers.Visible = isOn;
            ButtonMenuAdminAdd.Enabled = isOn; ButtonMenuAdminAdd.Visible = isOn;
            ButtonReturnAdd.Enabled = isOn; ButtonReturnAdd.Visible = isOn;
            ButtonExitAdd.Enabled = isOn; ButtonExitAdd.Visible = isOn;

            AddThema.Enabled = isOn; AddThema.Visible = isOn;
            AddQuestion.Enabled = isOn; AddQuestion.Visible = isOn;
            AddAnswer1.Enabled = isOn; AddAnswer1.Visible = isOn;
            AddAnswer2.Enabled = isOn; AddAnswer2.Visible = isOn;
            AddAnswer3.Enabled = isOn; AddAnswer3.Visible = isOn;
            AddRAnswer1.Enabled = isOn; AddRAnswer1.Visible = isOn;
            AddRAnswer2.Enabled = isOn; AddRAnswer2.Visible = isOn;

            fonAddAdmin.Enabled = isOn; fonAddAdmin.Visible = isOn;
            userAddAdmin.Enabled = isOn; userAddAdmin.Visible = isOn;
            nameUserAddAdmin.Enabled = isOn; nameUserAddAdmin.Visible = isOn;
        }

        private void AddTesting()
        {
            //user
            userAddAdmin.Text = "User";
            userAddAdmin.Location = new Point(0, 20);
            userAddAdmin.Name = "userAddAdmin";
            userAddAdmin.AutoSize = true;
            userAddAdmin.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold);
            userAddAdmin.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����

            this.Controls.Add(userAddAdmin);

            nameUserAddAdmin.Text = "...";
            nameUserAddAdmin.Location = new Point(70, 20);
            nameUserAddAdmin.Name = "nameUserAddAdmin";
            nameUserAddAdmin.AutoSize = true;
            nameUserAddAdmin.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold);
            nameUserAddAdmin.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����

            this.Controls.Add(nameUserAddAdmin);

            this.Controls.SetChildIndex(userAddAdmin, 0);
            this.Controls.SetChildIndex(nameUserAddAdmin, 0);

            //��� AddAdmin
            fonAddAdmin.Image = Image.FromFile("img/fonAddTest.png");
            fonAddAdmin.Location = new Point(0, 20);
            fonAddAdmin.Name = "fonAddAdmin";
            fonAddAdmin.Size = new Size(1600, 900);
            fonAddAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            fonAddAdmin.TabIndex = 0;
            fonAddAdmin.TabStop = false;
            fonAddAdmin.SendToBack();

            this.Controls.Add(fonAddAdmin);
            this.Controls.SetChildIndex(fonAddAdmin, 1000);

            using (Graphics g = Graphics.FromImage(fonAddAdmin.Image))
            {
                using (Font font = new Font(privateFonts.Families[0], 96, FontStyle.Bold))
                {
                    g.DrawString("�������� ����", font, Brushes.Black, new PointF(350, 0));
                }
            }
            fonAddAdmin.Invalidate(); // ��������� PictureBox, ����� ��������� ������������

            // Add Thema
            AddThema.Location = new Point(42, 145);
            AddThema.Name = "AddThema";
            AddThema.Size = new Size(593 + 20, 60 + 20);
            AddThema.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            AddThema.TabIndex = 0;
            AddThema.Image = Image.FromFile("object/AddThema.png");

            this.Controls.Add(AddThema);
            AddThema.BringToFront();

            // Add Question
            AddQuestion.Location = new Point(42, 255);
            AddQuestion.Name = "AddQuestion";
            AddQuestion.Size = new Size(593 + 20, 229 + 20);
            AddQuestion.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            AddQuestion.TabIndex = 0;
            AddQuestion.Image = Image.FromFile("object/AddQuestion.png");

            this.Controls.Add(AddQuestion);
            AddQuestion.BringToFront();

            // Add Answer
            AddAnswer1.Location = new Point(42, 590);
            AddAnswer1.Name = "AddAnswer1";
            AddAnswer1.Size = new Size(458 + 20, 67 + 20);
            AddAnswer1.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            AddAnswer1.TabIndex = 0;
            AddAnswer1.Image = Image.FromFile("object/AddAnswer.png");

            this.Controls.Add(AddAnswer1);
            AddAnswer1.BringToFront();

            AddAnswer2.Location = new Point(42, 690);
            AddAnswer2.Name = "AddAnswer2";
            AddAnswer2.Size = new Size(458 + 20, 67 + 20);
            AddAnswer2.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            AddAnswer2.TabIndex = 0;
            AddAnswer2.Image = Image.FromFile("object/AddAnswer.png");

            this.Controls.Add(AddAnswer2);
            AddAnswer2.BringToFront();

            AddAnswer3.Location = new Point(42, 790);
            AddAnswer3.Name = "AddAnswer3";
            AddAnswer3.Size = new Size(458 + 20, 67 + 20);
            AddAnswer3.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            AddAnswer3.TabIndex = 0;
            AddAnswer3.Image = Image.FromFile("object/AddAnswer.png");

            this.Controls.Add(AddAnswer3);
            AddAnswer3.BringToFront();

            // Add Right Answer
            AddRAnswer1.Location = new Point(558, 590);
            AddRAnswer1.Name = "AddRAnswer1";
            AddRAnswer1.Size = new Size(458 + 20, 67 + 20);
            AddRAnswer1.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            AddRAnswer1.TabIndex = 0;
            AddRAnswer1.Image = Image.FromFile("object/AddAnswer.png");

            this.Controls.Add(AddRAnswer1);
            AddRAnswer1.BringToFront();

            AddRAnswer2.Location = new Point(558, 690);
            AddRAnswer2.Name = "AddRAnswer2";
            AddRAnswer2.Size = new Size(458 + 20, 67 + 20);
            AddRAnswer2.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            AddRAnswer2.TabIndex = 0;
            AddRAnswer2.Image = Image.FromFile("object/AddAnswer.png");

            this.Controls.Add(AddRAnswer2);
            AddRAnswer2.BringToFront();

            // ������ �������� ����
            ButtonAddThema.Location = new Point(671, 145);
            ButtonAddThema.Name = "ButtonAddThema";
            ButtonAddThema.Size = new Size(258 + 20, 58 + 20);
            ButtonAddThema.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            ButtonAddThema.TabIndex = 0;
            ButtonAddThema.Image = Image.FromFile("button/AddThema.png");

            this.Controls.Add(ButtonAddThema);
            ButtonAddThema.BringToFront();

            // ���������� �������� ���������
            ButtonAddThema.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ButtonAddThema.Image = Image.FromFile("button/AddThemaColor.png");
            };

            ButtonAddThema.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ButtonAddThema.Image = Image.FromFile("button/AddThema.png");
            };

            ButtonAddThema.Click += (sender, e) =>
            {
                // �������� � ���� ������
            };

            // ������ �������� �������� � ����
            ButtonPictureThema.Location = new Point(960, 145);
            ButtonPictureThema.Name = "ButtonPictureThema";
            ButtonPictureThema.Size = new Size(258 + 20, 58 + 20);
            ButtonPictureThema.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            ButtonPictureThema.TabIndex = 0;
            ButtonPictureThema.Image = Image.FromFile("object/imgThema.png");

            this.Controls.Add(ButtonPictureThema);
            ButtonPictureThema.BringToFront();

            ButtonPictureThema.Click += (sender, e) =>
            {
                // �������� � �������� � ����
            };

            // ������ �������� ������
            ButtonAddQuestion.Location = new Point(680, 275);
            ButtonAddQuestion.Name = "ButtonAddQuestion";
            ButtonAddQuestion.Size = new Size(258 + 20, 58 + 20);
            ButtonAddQuestion.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            ButtonAddQuestion.TabIndex = 0;
            ButtonAddQuestion.Image = Image.FromFile("button/AddQuest.png");

            this.Controls.Add(ButtonAddQuestion);
            ButtonAddQuestion.BringToFront();

            // ���������� �������� ���������
            ButtonAddQuestion.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ButtonAddQuestion.Image = Image.FromFile("button/AddQuestColor.png");
            };

            ButtonAddQuestion.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ButtonAddQuestion.Image = Image.FromFile("button/AddQuest.png");
            };

            ButtonAddQuestion.Click += (sender, e) =>
            {
                // �������� � ������ � ��
            };

            // ������ �������� ������� ������� � ��
            ButtonAddAnswers.Location = new Point(155, 510);
            ButtonAddAnswers.Name = "ButtonAddAnswers";
            ButtonAddAnswers.Size = new Size(258 + 20, 58 + 20);
            ButtonAddAnswers.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            ButtonAddAnswers.TabIndex = 0;
            ButtonAddAnswers.Image = Image.FromFile("button/AddAnswer.png");

            this.Controls.Add(ButtonAddAnswers);
            ButtonAddAnswers.BringToFront();

            // ���������� �������� ���������
            ButtonAddAnswers.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ButtonAddAnswers.Image = Image.FromFile("button/AddAnswerColor.png");
            };

            ButtonAddAnswers.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ButtonAddAnswers.Image = Image.FromFile("button/AddAnswer.png");
            };

            ButtonAddAnswers.Click += (sender, e) =>
            {
                // �������� � �������� ������� � ��
            };

            // ������ �������� �������� ���������� ������� � ��
            ButtonAddRAnswers.Location = new Point(655, 510);
            ButtonAddRAnswers.Name = "ButtonAddRAnswers";
            ButtonAddRAnswers.Size = new Size(258 + 20, 58 + 20);
            ButtonAddRAnswers.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            ButtonAddRAnswers.TabIndex = 0;
            ButtonAddRAnswers.Image = Image.FromFile("button/AddRAnsw.png");

            this.Controls.Add(ButtonAddRAnswers);
            ButtonAddRAnswers.BringToFront();

            // ���������� �������� ���������
            ButtonAddRAnswers.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ButtonAddRAnswers.Image = Image.FromFile("button/AddRAnswColor.png");
            };

            ButtonAddRAnswers.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ButtonAddRAnswers.Image = Image.FromFile("button/AddRAnsw.png");
            };

            ButtonAddRAnswers.Click += (sender, e) =>
            {
                // �������� � �������� ���������� ������� � ��
            };


            // ������ ButtonMenuAdminAdd
            ButtonMenuAdminAdd.Location = new Point(1174, 598);
            ButtonMenuAdminAdd.Name = "ButtonMenuAdminAdd";
            ButtonMenuAdminAdd.Size = new Size(305 + 20, 71 + 20);
            ButtonMenuAdminAdd.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            ButtonMenuAdminAdd.TabIndex = 0;
            ButtonMenuAdminAdd.Image = Image.FromFile("button/Menu.png");

            this.Controls.Add(ButtonMenuAdminAdd);
            ButtonMenuAdminAdd.BringToFront();

            // ���������� �������� ���������
            ButtonMenuAdminAdd.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ButtonMenuAdminAdd.Image = Image.FromFile("button/MenuAdminColor.png");
            };

            ButtonMenuAdminAdd.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ButtonMenuAdminAdd.Image = Image.FromFile("button/Menu.png");
            };

            ButtonMenuAdminAdd.Click += (sender, e) =>
            {
                OnOffAddTesting(false);
                OnOffMainAdmin(true);
            };

            // ������ Return
            ButtonReturnAdd.Location = new Point(1174, 701);
            ButtonReturnAdd.Name = "ButtonReturnAdd";
            ButtonReturnAdd.Size = new Size(305 + 20, 71 + 20);
            ButtonReturnAdd.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            ButtonReturnAdd.TabIndex = 0;
            ButtonReturnAdd.Image = Image.FromFile("button/Return.png");

            this.Controls.Add(ButtonReturnAdd);
            ButtonReturnAdd.BringToFront();

            // ���������� �������� ���������
            ButtonReturnAdd.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ButtonReturnAdd.Image = Image.FromFile("button/ReturnColor.png");
            };

            ButtonReturnAdd.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ButtonReturnAdd.Image = Image.FromFile("button/Return.png");
            };

            ButtonReturnAdd.Click += (sender, e) =>
            {
                OnOffAddTesting(false);
                OnOffTestMain(true);
            };

            // ������ �����
            ButtonExitAdd.Location = new Point(1173, 795);
            ButtonExitAdd.Name = "ButtonExitAdd";
            ButtonExitAdd.Size = new Size(305 + 20, 71 + 20);
            ButtonExitAdd.BackColor = Color.FromArgb(178, 219, 241); // ��������� �����
            ButtonExitAdd.TabIndex = 0;
            ButtonExitAdd.Image = Image.FromFile("button/ExitTestMain.png");

            this.Controls.Add(ButtonExitAdd);
            ButtonExitAdd.BringToFront();

            // ���������� �������� ���������
            ButtonExitAdd.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ButtonExitAdd.Image = Image.FromFile("button/ExitTestMainColor.png");
            };

            ButtonExitAdd.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ButtonExitAdd.Image = Image.FromFile("button/ExitTestMain.png");
            };

            ButtonExitAdd.Click += (sender, e) => { this.Close(); }; //���������� ������� Click     

        }


        // ����� �������
        PictureBox ReturnAllRating = new PictureBox();       //������� � ������� �����

        PictureBox fonAllRating = new PictureBox();
        Label userAllRating = new Label();
        Label nameUserAllRating = new Label();

        PictureBox lineHoriz = new PictureBox();
        PictureBox lineVert = new PictureBox();

        private void AllRatingStr()
        {
            //user
            userAllRating.Text = "User";
            userAllRating.Location = new Point(0, 20);
            userAllRating.Name = "userAllRating";
            userAllRating.AutoSize = true;
            userAllRating.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold);

            this.Controls.Add(userAllRating);

            nameUserAllRating.Text = "...";
            nameUserAllRating.Location = new Point(70, 20);
            nameUserAllRating.Name = "userNameAllRating";
            nameUserAllRating.AutoSize = true;
            nameUserAllRating.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold);

            this.Controls.Add(nameUserAllRating);
            this.Controls.SetChildIndex(userAllRating, 0);
            this.Controls.SetChildIndex(nameUserAllRating, 0);

            //��� admin
            fonAllRating.Image = Image.FromFile("img/win.png");
            fonAllRating.Location = new Point(0, 30);
            fonAllRating.Name = "fonAllRating";
            fonAllRating.Size = new Size(1600, 875);
            fonAllRating.SizeMode = PictureBoxSizeMode.Zoom;
            fonAllRating.TabIndex = 0;
            fonAllRating.TabStop = false;
            fonAllRating.SendToBack();

            this.Controls.Add(fonAllRating);

            using (Graphics g = Graphics.FromImage(fonAllRating.Image))
            {
                using (Font font = new Font(privateFonts.Families[0], 96, FontStyle.Bold))
                {
                    g.DrawString("�������", font, Brushes.Black, new PointF(350, 0));
                }
            }
            fonAllRating.Invalidate(); // ��������� PictureBox, ����� ��������� ������������

            // ������ Return
            ReturnAllRating.Location = new Point(1126, 798);
            ReturnAllRating.Name = "ReturnAllRating";
            ReturnAllRating.Size = new Size(305 + 20, 71 + 20);
            ReturnAllRating.BackColor = Color.FromArgb(252, 242, 239); // ��������� �����
            ReturnAllRating.TabIndex = 0;
            ReturnAllRating.Image = Image.FromFile("button/ReturnAllRating.png");

            this.Controls.Add(ReturnAllRating);
            this.Controls.SetChildIndex(ReturnAllRating, 0);

            ReturnAllRating.BringToFront();

            // ���������� �������� ���������
            ReturnAllRating.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ReturnAllRating.Image = Image.FromFile("button/ReturnAllRatingColor.png");
            };

            ReturnAllRating.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ReturnAllRating.Image = Image.FromFile("button/ReturnAllRating.png");
            };

            ReturnAllRating.Click += (sender, e) =>
            {
                OnOffAllRatingStr(false);
                OnOffTestMain(true);
            };

            lineHoriz.Location = new Point(37, 295);
            lineHoriz.Name = "lineHoriz";
            lineHoriz.Size = new Size(767, 2);
            lineHoriz.SizeMode = PictureBoxSizeMode.Zoom;
            lineHoriz.TabIndex = 0;
            lineHoriz.TabStop = false;
            lineHoriz.BackColor = Color.Black;
            lineHoriz.BringToFront();

            this.Controls.Add(lineHoriz);
            this.Controls.SetChildIndex(lineHoriz, 0);

            lineVert.Location = new Point(852, 40);
            lineVert.Name = "lineVert";
            lineVert.Size = new Size(2, 852);
            lineVert.SizeMode = PictureBoxSizeMode.Zoom;
            lineVert.TabIndex = 0;
            lineVert.TabStop = false;
            lineVert.BackColor = Color.Black;
            lineVert.BringToFront();

            this.Controls.Add(lineVert);
            this.Controls.SetChildIndex(lineVert, 0);
        }

        // �������� ����� �����
        PictureBox ReturnSelectionTest = new PictureBox();       //������� � ������� �����

        PictureBox fonSelectionTest = new PictureBox();
        PictureBox fonSelectionTest2 = new PictureBox();
        Label userSelectionTest = new Label();
        Label nameUserSelectionTest = new Label();

        PictureBox test1 = new PictureBox();
        PictureBox test11 = new PictureBox();
        Label nameTest1 = new Label();

        PictureBox test2 = new PictureBox();
        PictureBox test21 = new PictureBox();
        Label nameTest2 = new Label();

        // ��������� ��������
        private void OnOffSelectionTest(bool isOn)
        {
            ReturnSelectionTest.Enabled = isOn;
            ReturnSelectionTest.Visible = isOn;

            fonSelectionTest.Enabled = isOn;
            fonSelectionTest.Visible = isOn;
            fonSelectionTest2.Enabled = isOn;
            fonSelectionTest2.Visible = isOn;

            userSelectionTest.Enabled = isOn;
            userSelectionTest.Visible = isOn;
            nameUserSelectionTest.Enabled = isOn;
            nameUserSelectionTest.Visible = isOn;

            test1.Enabled = isOn;
            test1.Visible = isOn;
            test11.Enabled = isOn;
            test11.Visible = isOn;
            nameTest1.Enabled = isOn;
            nameTest1.Visible = isOn;

            test2.Enabled = isOn;
            test2.Visible = isOn;
            test21.Enabled = isOn;
            test21.Visible = isOn;
            nameTest2.Enabled = isOn;
            nameTest2.Visible = isOn;

            timer1.Enabled = isOn;

        }

        private int originalY; // �������� ���������� Y
        private int originalX; // �������� ���������� X
        private int targetY;    // ������� ���������� Y (�����)
        private int targetX;    // ������� ���������� X (�����)
        private bool isAnimatingVertically = false;
        private bool isAnimatingHorizontally = false;
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();

        //��������
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isAnimatingVertically)
            {
                int step = (test11.Top < targetY) ? -1 : 1; // �������� �����
                test11.Top += step;

                if ((step < 0 && test11.Top <= targetY) || (step > 0 && test11.Top >= targetY))
                {
                    test11.Top = targetY;
                    isAnimatingVertically = false;
                    timer1.Stop();

                    // ����� ���������� ������������ �������� ��������� ��������������
                    if (test11.Top == originalY - 20) // ���� �������� ����� ���������
                    {
                        isAnimatingHorizontally = true;
                        targetX = originalX - 20;
                        timer2.Start();
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isAnimatingHorizontally)
            {
                int step = (test11.Left < targetX) ? -1 : 1; // �������� ����� ��� ������
                test11.Left += step;

                if ((step < 0 && test11.Left <= targetX) || (step > 0 && test11.Left >= targetX))
                {
                    test11.Left = targetX;
                    isAnimatingHorizontally = false;
                    timer2.Stop();
                }
            }
        }

        private void SelectionTest()
        {
            //user
            userSelectionTest.Text = "User";
            userSelectionTest.Location = new Point(0, 20);
            userSelectionTest.Name = "userSelectionTest";
            userSelectionTest.AutoSize = true;
            userSelectionTest.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold); ;
            userSelectionTest.BringToFront();

            this.Controls.Add(userSelectionTest);

            nameUserSelectionTest.Text = "...";
            nameUserSelectionTest.Location = new Point(70, 20);
            nameUserSelectionTest.Name = "nameUserSelectionTest";
            nameUserSelectionTest.AutoSize = true;
            nameUserSelectionTest.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold); ;
            nameUserSelectionTest.BringToFront();

            this.Controls.Add(nameUserSelectionTest);
            this.Controls.SetChildIndex(userSelectionTest, 0);
            this.Controls.SetChildIndex(nameUserSelectionTest, 0);

            //��� ����� �����
            fonSelectionTest.Image = Image.FromFile("img/TestMainAll.png");
            fonSelectionTest.Location = new Point(0, 30);
            fonSelectionTest.Name = "fonSelectionTest";
            fonSelectionTest.Size = new Size(1600, 875);
            fonSelectionTest.SizeMode = PictureBoxSizeMode.Zoom;
            fonSelectionTest.TabIndex = 0;
            fonSelectionTest.TabStop = false;
            fonSelectionTest.SendToBack();

            this.Controls.Add(fonSelectionTest);
            this.Controls.SetChildIndex(fonSelectionTest, 10000);

            // ��������� ������ ������ PictureBox
            using (Graphics g = Graphics.FromImage(fonSelectionTest.Image))
            {
                using (Font font = new Font(privateFonts.Families[0], 96, FontStyle.Bold))
                {
                    g.DrawString("����� �����", font, Brushes.Black, new PointF(350, 0));
                }
            }
            fonSelectionTest.Invalidate(); // ��������� PictureBox, ����� ��������� ������������

            // ������ Return
            ReturnSelectionTest.Location = new Point(1251, 48);
            ReturnSelectionTest.Name = "ReturnSelectionTest";
            ReturnSelectionTest.Size = new Size(305 + 20, 71 + 20);
            ReturnSelectionTest.BackColor = Color.FromArgb(252, 242, 239); // ��������� �����
            ReturnSelectionTest.TabIndex = 0;
            ReturnSelectionTest.Image = Image.FromFile("button/ReturnAllRating.png");

            this.Controls.Add(ReturnSelectionTest);
            this.Controls.SetChildIndex(ReturnSelectionTest, 0);

            // ���������� �������� ���������
            ReturnSelectionTest.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ReturnSelectionTest.Image = Image.FromFile("button/ReturnAllRatingColor.png");
            };

            ReturnSelectionTest.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ReturnSelectionTest.Image = Image.FromFile("button/ReturnAllRating.png");
            };

            ReturnSelectionTest.Click += (sender, e) =>
            {
                OnOffSelectionTest(false);
                OnOffTestMain(true);
            };

            // test # 1
            test1.Location = new Point(56, 168);
            test1.Name = "test1";
            test1.Size = new Size(150, 150);
            test1.BackColor = Color.FromArgb(252, 242, 239); // ��������� �����
            test1.TabIndex = 0;
            test1.Image = Image.FromFile("object/test.png");
            test1.SendToBack();

            this.Controls.Add(test1);

            test11.Location = new Point(56, 168);
            test11.Name = "test11";
            test11.Size = new Size(100, 100);
            test11.BackColor = Color.FromArgb(252, 242, 239); // ��������� �����
            test11.TabIndex = 0;
            test11.Image = Image.FromFile("object/MathPrimers1.png");
            test11.BringToFront();

            this.Controls.Add(test11);

            nameTest1.Text = "Math Primers Level 1";
            nameTest1.Location = new Point(56, 265);
            nameTest1.Name = "nameTest";
            nameTest1.Size = new Size(150, 50);         // ������� ������� �� ��������� ������
            nameTest1.AutoSize = true;
            nameTest1.Font = new Font(privateFonts.Families[1], 14, FontStyle.Italic);
            nameTest1.BackColor = Color.FromArgb(254, 242, 239); // ��������� �����
            nameTest1.BringToFront();

            this.Controls.Add(nameTest1);

            this.Controls.SetChildIndex(test11, 0);
            this.Controls.SetChildIndex(nameTest1, 0);
            this.Controls.SetChildIndex(test1, 1000);

            // ��������
            originalY = test11.Top;
            timer1.Interval = 70;
            timer1.Tick += timer1_Tick;

            originalX = test11.Left;
            timer2.Interval = 70;
            timer2.Tick += timer2_Tick;

            // ����������� �������
            test11.MouseEnter += (s, ev) =>
            {
                test11.Image = Image.FromFile("object/MathPrimers1.png");

                // ������� ��������� �������� �����
                isAnimatingVertically = true;
                targetY = originalY - 20;
                timer1.Start();
            };

            test11.MouseLeave += (s, ev) =>
            {
                // ������� �������� �������� ������
                isAnimatingHorizontally = true;
                targetX = originalX;
                timer2.Start();

                // ����� ���������� �������������� �������� �������� �������� ����
                timer2.Tick += (sender, e) =>
                {
                    if (!isAnimatingHorizontally && test11.Left == originalX)
                    {
                        isAnimatingVertically = true;
                        targetY = originalY;
                        timer1.Start();
                        timer2.Tick -= (sender, e) => { }; // ������� ��������� ����������
                    }
                };
            };

            test11.Click += (sender, e) =>
            {
                OnOffSelectionTest(false);
                OnOffPassingTheTest(true);
            };




        }


        // �������� ����������� �����
        PictureBox ReturnPassingTheTest = new PictureBox();     //������� � ������� �����
        PictureBox ButtonAnswer = new PictureBox();             //������ ����� �� ������
        PictureBox answer1 = new PictureBox();
        PictureBox answer2 = new PictureBox();
        PictureBox answer3 = new PictureBox();

        PictureBox fonPassingTheTest = new PictureBox();        //��� ��������
        Label userPassingTheTest = new Label();                 //�����������
        Label nameUserPassingTheTest = new Label();             //��� ������

        Label testThema = new Label();                          //����
        Label testThemaName = new Label();                      //�������� ����

        Label testNumQuestion = new Label();                    //��������� ������
        Label testNumQuest = new Label();                       //����
        Label testNumQuestionAll = new Label();                 //����� ��������

        Label testQuestion = new Label();                       //������
        Label testQuestionName = new Label();                   //����� �������

        bool isFirstImage = true;                               //������������ ����� ���������� ��������
        Label testAnswer1 = new Label();                        //������� ������ 1
        Label testAnswer2 = new Label();                        //������� ������ 2
        Label testAnswer3 = new Label();                        //������� ������ 3

        // ��������� �������� �������� ����
        private void OnOffPassingTheTest(bool isOn)
        {
            ReturnPassingTheTest.Enabled = isOn; ReturnPassingTheTest.Visible = isOn;
            ButtonAnswer.Enabled = isOn; ButtonAnswer.Visible = isOn;
            answer1.Enabled = isOn; answer1.Visible = isOn;
            answer2.Enabled = isOn; answer2.Visible = isOn;
            answer3.Enabled = isOn; answer3.Visible = isOn;

            testThema.Enabled = isOn; testThema.Visible = isOn;
            testThemaName.Enabled = isOn; testThemaName.Visible = isOn;
            testNumQuestion.Enabled = isOn; testNumQuestion.Visible = isOn;
            testNumQuest.Enabled = isOn; testNumQuest.Visible = isOn;
            testNumQuestionAll.Enabled = isOn; testNumQuestionAll.Visible = isOn;
            testQuestion.Enabled = isOn; testQuestion.Visible = isOn;
            testQuestionName.Enabled = isOn; testQuestionName.Visible = isOn;

            testAnswer1.Enabled = isOn; testAnswer1.Visible = isOn;
            testAnswer2.Enabled = isOn; testAnswer2.Visible = isOn;
            testAnswer3.Enabled = isOn; testAnswer3.Visible = isOn;

            fonPassingTheTest.Enabled = isOn; fonPassingTheTest.Visible = isOn;
            userPassingTheTest.Enabled = isOn; userPassingTheTest.Visible = isOn;
            nameUserPassingTheTest.Enabled = isOn; nameUserPassingTheTest.Visible = isOn;
        }


        private void PassingTheTest()
        {
            //user
            userPassingTheTest.Text = "User";
            userPassingTheTest.Location = new Point(10, 20);
            userPassingTheTest.Name = "userPassingTheTest";
            userPassingTheTest.AutoSize = true;
            userPassingTheTest.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold);
            userPassingTheTest.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            userPassingTheTest.BringToFront();

            this.Controls.Add(userPassingTheTest);

            nameUserPassingTheTest.Text = "...";
            nameUserPassingTheTest.Location = new Point(70, 20);
            nameUserPassingTheTest.Name = "nameUserSelectionTest";
            nameUserPassingTheTest.AutoSize = true;
            nameUserPassingTheTest.Font = new Font(privateFonts.Families[0], 24, FontStyle.Bold);
            nameUserPassingTheTest.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            nameUserPassingTheTest.BringToFront();

            this.Controls.Add(nameUserPassingTheTest);
            this.Controls.SetChildIndex(userPassingTheTest, 0);
            this.Controls.SetChildIndex(nameUserPassingTheTest, 0);

            //��� ����� �����
            fonPassingTheTest.Image = Image.FromFile("img/fonPassingTheTest.png");
            fonPassingTheTest.Location = new Point(0, 20);
            fonPassingTheTest.Name = "fonPassingTheTest";
            fonPassingTheTest.Size = new Size(1600, 875);
            fonPassingTheTest.SizeMode = PictureBoxSizeMode.Zoom;
            fonPassingTheTest.TabIndex = 0;
            fonPassingTheTest.TabStop = false;
            fonPassingTheTest.SendToBack();

            this.Controls.Add(fonPassingTheTest);
            this.Controls.SetChildIndex(fonPassingTheTest, 10000);

            // ��������� ������ ������ PictureBox
            using (Graphics g = Graphics.FromImage(fonPassingTheTest.Image))
            {
                using (Font font = new Font(privateFonts.Families[0], 96, FontStyle.Bold))
                {
                    g.DrawString("T���", font, Brushes.Black, new PointF(500, 0));
                }
            }
            fonPassingTheTest.Invalidate(); // ��������� PictureBox, ����� ��������� ������������

            // ������ Return
            ReturnPassingTheTest.Location = new Point(1250, 600);
            ReturnPassingTheTest.Name = "ReturnPassingTheTest";
            ReturnPassingTheTest.Size = new Size(304 + 20, 70 + 20);
            ReturnPassingTheTest.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            ReturnPassingTheTest.TabIndex = 0;
            ReturnPassingTheTest.Image = Image.FromFile("button/ReturnPassingTheTest.png");

            this.Controls.Add(ReturnPassingTheTest);
            this.Controls.SetChildIndex(ReturnPassingTheTest, 0);

            // ���������� �������� ���������
            ReturnPassingTheTest.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ReturnPassingTheTest.Image = Image.FromFile("button/ReturnPassingTheTestColor.png");
            };

            ReturnPassingTheTest.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ReturnPassingTheTest.Image = Image.FromFile("button/ReturnPassingTheTest.png");
            };

            ReturnPassingTheTest.Click += (sender, e) =>
            {
                OnOffPassingTheTest(false);
                OnOffSelectionTest(true);
            };

            // ������ ButtonAnswer
            ButtonAnswer.Location = new Point(76, 800);
            ButtonAnswer.Name = "ButtonAnswer";
            ButtonAnswer.Size = new Size(300 + 20, 52 + 20);
            ButtonAnswer.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            ButtonAnswer.TabIndex = 0;
            ButtonAnswer.Image = Image.FromFile("button/ButtonAnswer.png");

            this.Controls.Add(ButtonAnswer);
            this.Controls.SetChildIndex(ButtonAnswer, 0);

            // ���������� �������� ���������
            ButtonAnswer.MouseEnter += (sender, e) =>
            {
                // �������� ����������� �� ������ (��������, � ����������)
                ButtonAnswer.Image = Image.FromFile("button/ButtonAnswerColor.png");
            };

            ButtonAnswer.MouseLeave += (sender, e) =>
            {
                //���������� �������� �����������
                ButtonAnswer.Image = Image.FromFile("button/ButtonAnswer.png");
            };

            ButtonAnswer.Click += (sender, e) =>
            {

            };

            // ���� �����
            testThema.Text = "����:";
            testThema.Location = new Point(44, 140);
            testThema.Name = "testThema";
            testThema.AutoSize = true;
            testThema.Font = new Font(privateFonts.Families[1], 22, FontStyle.Bold);
            testThema.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testThema.BringToFront();

            this.Controls.Add(testThema);

            testThemaName.Text = "...";
            testThemaName.Location = new Point(100, 140);
            testThemaName.Name = "testThemaName";
            testThemaName.AutoSize = true;
            testThemaName.Font = new Font(privateFonts.Families[1], 22, FontStyle.Bold);
            testThemaName.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testThemaName.BringToFront();

            this.Controls.Add(testThemaName);

            //����� �������
            testNumQuestion.Text = "...";
            testNumQuestion.Location = new Point(44, 185);
            testNumQuestion.Name = "testNumQuestion";
            testNumQuestion.AutoSize = true;
            testNumQuestion.Font = new Font(privateFonts.Families[1], 22, FontStyle.Bold);
            testNumQuestion.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testNumQuestion.BringToFront();

            this.Controls.Add(testNumQuestion);

            testNumQuest.Text = "/";
            testNumQuest.Location = new Point(84, 185);
            testNumQuest.Name = "testNumQuest";
            testNumQuest.AutoSize = true;
            testNumQuest.Font = new Font(privateFonts.Families[1], 22, FontStyle.Bold);
            testNumQuest.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testNumQuest.BringToFront();

            this.Controls.Add(testNumQuest);

            testNumQuestionAll.Text = "...";
            testNumQuestionAll.Location = new Point(114, 185);
            testNumQuestionAll.Name = "testNumQuestionAll";
            testNumQuestionAll.AutoSize = true;
            testNumQuestionAll.Font = new Font(privateFonts.Families[1], 22, FontStyle.Bold);
            testNumQuestionAll.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testNumQuestionAll.BringToFront();

            this.Controls.Add(testNumQuestionAll);

            // ������
            testQuestion.Text = "������:";
            testQuestion.Location = new Point(44, 230);
            testQuestion.Name = "testQuestion";
            testQuestion.AutoSize = true;
            testQuestion.Font = new Font(privateFonts.Families[1], 32, FontStyle.Bold);
            testQuestion.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testQuestion.BringToFront();

            this.Controls.Add(testQuestion);

            testQuestionName.Text = "...";
            testQuestionName.Location = new Point(44, 290);
            testQuestionName.Name = "testQuestionName";
            testQuestionName.AutoSize = true;
            testQuestionName.Font = new Font(privateFonts.Families[1], 32, FontStyle.Bold);
            testQuestionName.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testQuestionName.BringToFront();

            this.Controls.Add(testQuestionName);

            this.Controls.SetChildIndex(testThema, 0);
            this.Controls.SetChildIndex(testThemaName, 0);
            this.Controls.SetChildIndex(testNumQuestion, 0);
            this.Controls.SetChildIndex(testNumQuest, 0);
            this.Controls.SetChildIndex(testNumQuestionAll, 0);
            this.Controls.SetChildIndex(testQuestion, 0);
            this.Controls.SetChildIndex(testQuestionName, 0);

            // checkBox 1
            answer1.Location = new Point(75, 710);
            answer1.Name = "answer1";
            answer1.Size = new Size(40, 40);
            answer1.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            answer1.TabIndex = 0;
            answer1.Image = Image.FromFile("button/CheckBoxAnswer.png");

            this.Controls.Add(answer1);
            this.Controls.SetChildIndex(answer1, 0);

            answer1.Click += (sender, e) =>
            {
                if (isFirstImage)
                {
                    answer1.Image = Image.FromFile("button/CheckBoxAnswerColor.png");
                }
                else
                {
                    answer1.Image = Image.FromFile("button/CheckBoxAnswer.png");
                }
                isFirstImage = !isFirstImage;
            };

            testAnswer1.Text = "����� 1";
            testAnswer1.Location = new Point(100, 700);
            testAnswer1.Name = "testAnswer1";
            testAnswer1.AutoSize = true;
            testAnswer1.Font = new Font(privateFonts.Families[1], 32, FontStyle.Bold);
            testAnswer1.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testAnswer1.BringToFront();

            this.Controls.Add(testAnswer1);

            // checkBox 2
            answer2.Location = new Point(400, 710);
            answer2.Name = "answer2";
            answer2.Size = new Size(40, 40);
            answer2.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            answer2.TabIndex = 0;
            answer2.Image = Image.FromFile("button/CheckBoxAnswer.png");

            this.Controls.Add(answer2);
            this.Controls.SetChildIndex(answer2, 0);

            answer2.Click += (sender, e) =>
            {
                if (isFirstImage)
                {
                    answer2.Image = Image.FromFile("button/CheckBoxAnswerColor.png");
                }
                else
                {
                    answer2.Image = Image.FromFile("button/CheckBoxAnswer.png");
                }
                isFirstImage = !isFirstImage;
            };

            testAnswer2.Text = "����� 2";
            testAnswer2.Location = new Point(430, 700);
            testAnswer2.Name = "testAnswer2";
            testAnswer2.AutoSize = true;
            testAnswer2.Font = new Font(privateFonts.Families[1], 32, FontStyle.Bold);
            testAnswer2.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testAnswer2.BringToFront();

            this.Controls.Add(testAnswer2);

            // checkBox 3
            answer3.Location = new Point(775, 710);
            answer3.Name = "answer3";
            answer3.Size = new Size(40, 40);
            answer3.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            answer3.TabIndex = 0;
            answer3.Image = Image.FromFile("button/CheckBoxAnswer.png");

            this.Controls.Add(answer3);
            this.Controls.SetChildIndex(answer3, 0);

            answer3.Click += (sender, e) =>
            {
                if (isFirstImage)
                {
                    answer3.Image = Image.FromFile("button/CheckBoxAnswerColor.png");
                }
                else
                {
                    answer3.Image = Image.FromFile("button/CheckBoxAnswer.png");
                }
                isFirstImage = !isFirstImage;
            };

            testAnswer3.Text = "����� 3";
            testAnswer3.Location = new Point(800, 700);
            testAnswer3.Name = "testAnswer3";
            testAnswer3.AutoSize = true;
            testAnswer3.Font = new Font(privateFonts.Families[1], 32, FontStyle.Bold);
            testAnswer3.BackColor = Color.FromArgb(179, 206, 251); // ��������� �����
            testAnswer3.BringToFront();

            this.Controls.Add(testAnswer3);

        }

    }
}
