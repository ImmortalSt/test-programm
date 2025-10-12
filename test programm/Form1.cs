using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace test_programm
{
    public partial class Form1 : Form
    {
        private string fontPath = "fonts/Comforter-Regular.ttf";
        private Font customFont;

        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        private void LoadCustomFont()
        {
            try
            {
                // Способ 1: Загрузка из встроенных ресурсов проекта
                byte[] fontData = Properties.Resources.Comforter_Regular; // "MyCustomFont" - имя ресурса

                // Загружаем шрифт в память
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                privateFonts.AddMemoryFont(fontPtr, fontData.Length);
                Marshal.FreeCoTaskMem(fontPtr);

                //MessageBox.Show($"Шрифт загружен: {privateFonts.Families[0].Name}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки шрифта: {ex.Message}");
                // Используем стандартный шрифт в случае ошибки
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
            OnOffRegisterStr(false);
            OnOffTestMain(false);

            this.Size = new Size(isForm, 900);

            Panel panel = new Panel()
            {
                Width = this.Size.Width,
                Height = 30,
                //BackColor = Color.White,
            };

            this.Controls.Add(panel);

            // Обработчики перемещения
            panel.MouseDown += TitleBar_MouseDown;
            panel.MouseMove += TitleBar_MouseMove;
            panel.MouseUp += TitleBar_MouseUp;

            this.BackColor = Color.FromArgb(255, 250, 247); // установка цвета

        }


        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  // Если нажата ЛЕВАЯ кнопка мыши
            {
                isDragging = true;              // "ВКЛЮЧАЕМ РЕЖИМ ПЕРЕТАСКИВАНИЯ"
                startPoint = new Point(e.X, e.Y); // "ЗАПОМИНАЕМ, ГДЕ НАЧАЛИ"
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)  // "ЕСЛИ МЫ В РЕЖИМЕ ПЕРЕТАСКИВАНИЯ"
            {
                Point p = PointToScreen(e.Location);  // Узнаем где сейчас курсор на ЭКРАНЕ
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y); // Двигаем форму
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;  // "ВЫКЛЮЧАЕМ РЕЖИМ ПЕРЕТАСКИВАНИЯ"
        }

        Button Enter = new Button();        //вход
        Button Exit = new Button();         //выход
        Button Registr = new Button();      //регистрация
        Button Recover = new Button();      //восстановить пароль

        PictureBox fon = new PictureBox();
        PictureBox login = new PictureBox();
        PictureBox pass = new PictureBox();
        PictureBox eye = new PictureBox();
        Label nameTest = new Label();

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


        private void MainStr()
        {
            // название программы
            nameTest.Text = "Тестирующая программа";
            nameTest.Location = new Point(30, 20);
            nameTest.Name = "nameTest";
            nameTest.AutoSize = true;
            nameTest.Font = new Font(privateFonts.Families[0], 72, FontStyle.Bold);
            nameTest.BringToFront();

            this.Controls.Add(nameTest);

            // фон 1 окна
            fon.Image = Image.FromFile("img/Regist.png");
            fon.Location = new Point(668, 30);
            fon.Name = "mainFon";
            fon.Size = new Size(1008, 900);
            fon.SizeMode = PictureBoxSizeMode.Zoom;
            fon.TabIndex = 0;
            fon.TabStop = false;
            fon.SendToBack();

            this.Controls.Add(fon);

            // логин
            login.Image = Image.FromFile("object/entry_cell.png");
            login.Location = new Point(76, 185 + 20);
            login.Name = "login";
            login.Size = new Size(481, 95);
            login.SizeMode = PictureBoxSizeMode.AutoSize;
            login.TabIndex = 0;
            login.TabStop = false;

            this.Controls.Add(login);

            // пароль
            pass.Image = Image.FromFile("object/entry_cell.png");
            pass.Location = new Point(76, 293 + 20);
            pass.Name = "pass";
            pass.Size = new Size(481, 95);
            pass.SizeMode = PictureBoxSizeMode.AutoSize;
            pass.TabIndex = 0;
            pass.TabStop = false;

            this.Controls.Add(pass);

            // показать пароль            
            eye.Image = Image.FromFile("button/eye.png");
            eye.Location = new Point(561, 303 + 20);
            eye.Name = "eye";
            eye.Size = new Size(481, 95);
            eye.SizeMode = PictureBoxSizeMode.AutoSize;
            eye.TabIndex = 0;
            eye.TabStop = false;

            this.Controls.Add(eye);

            // кнопка ВОЙТИ
            Enter.Location = new Point(144, 426);
            Enter.Name = "Enter";
            Enter.Size = new Size(305 + 20, 74 + 20);
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.TabIndex = 0;
            Enter.Image = Image.FromFile("button/Enter.png");
            Enter.UseVisualStyleBackColor = true;

            this.Controls.Add(Enter);

            Registr.Click += (sender, e) =>
            {
                OnOffMainStr(false);
                OnOffTestMain(true);

            };

            // кнопка РЕГИСТРАЦИЯ
            Registr.Location = new Point(144, 540);
            Registr.Name = "Registr";
            Registr.Size = new Size(305 + 20, 74 + 20);
            Registr.FlatAppearance.BorderSize = 0;
            Registr.FlatStyle = FlatStyle.Flat;
            Registr.TabIndex = 0;
            Registr.Image = Image.FromFile("button/Register.png");
            Registr.UseVisualStyleBackColor = true;

            this.Controls.Add(Registr);
            Registr.Click += (sender, e) =>
            {
                OnOffMainStr(false);
                OnOffRegisterStr(true);
            };

            // кнопка ВОССТАНОВИТЬ
            Recover.Location = new Point(144, 652);
            Recover.Name = "Recover";
            Recover.Size = new Size(305 + 20, 74 + 20);
            Recover.FlatAppearance.BorderSize = 0;
            Recover.FlatStyle = FlatStyle.Flat;
            Recover.TabIndex = 0;
            Recover.Image = Image.FromFile("button/Recover.png");
            Recover.UseVisualStyleBackColor = true;

            this.Controls.Add(Recover);

            // кнопка ВЫХОД
            Exit.Location = new Point(144, 757);
            Exit.Name = "Exit";
            Exit.Size = new Size(305 + 20, 74 + 20);
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.TabIndex = 0;
            Exit.Image = Image.FromFile("button/Exit.png");
            Exit.UseVisualStyleBackColor = true;

            this.Controls.Add(Exit);
            Exit.Click += (sender, e) => { this.Close(); }; //обработчик события Click

        }

        Button AddReg = new Button();        //Создать
        Button ReturnReg = new Button();     //Назад в окне РЕГИСТРАЦИЯ

        PictureBox fonRegistr = new PictureBox();
        PictureBox nameReg = new PictureBox();
        PictureBox loginReg = new PictureBox();
        PictureBox passReg = new PictureBox();
        Label nameRegStr = new Label();

        private void RegisterStr()
        {
            // название страницы
            nameRegStr.Text = "Регистрация";
            nameRegStr.Location = new Point(100, 20);
            nameRegStr.Name = "nameRegStr";
            nameRegStr.AutoSize = true;
            nameRegStr.Font = new Font(privateFonts.Families[0], 72, FontStyle.Regular);
            nameRegStr.BringToFront();

            this.Controls.Add(nameRegStr);

            // фон окна регистарции
            fonRegistr.Image = Image.FromFile("img/RegistName.png");
            fonRegistr.Location = new Point(668, 30);
            fonRegistr.Name = "FonRegistr";
            fonRegistr.Size = new Size(983, 900);
            fonRegistr.SizeMode = PictureBoxSizeMode.Zoom;
            fonRegistr.TabIndex = 0;
            fonRegistr.TabStop = false;
            fonRegistr.SendToBack();

            this.Controls.Add(fonRegistr);

            // имя при регистрации
            nameReg.Image = Image.FromFile("object/entry_cell.png");
            nameReg.Location = new Point(80, 205);
            nameReg.Name = "nameReg";
            nameReg.Size = new Size(481, 95);
            nameReg.SizeMode = PictureBoxSizeMode.AutoSize;
            nameReg.TabIndex = 0;
            nameReg.TabStop = false;

            this.Controls.Add(nameReg);

            // логин
            loginReg.Image = Image.FromFile("object/entry_cell.png");
            loginReg.Location = new Point(80, 354);
            loginReg.Name = "login";
            loginReg.Size = new Size(481, 95);
            loginReg.SizeMode = PictureBoxSizeMode.AutoSize;
            loginReg.TabIndex = 0;
            loginReg.TabStop = false;

            this.Controls.Add(loginReg);

            // пароль
            passReg.Image = Image.FromFile("object/entry_cell.png");
            passReg.Location = new Point(80, 522);
            passReg.Name = "passReg";
            passReg.Size = new Size(481, 95);
            passReg.SizeMode = PictureBoxSizeMode.AutoSize;
            passReg.TabIndex = 0;
            passReg.TabStop = false;

            this.Controls.Add(passReg);

            // кнопка СОЗДАТЬ
            AddReg.Location = new Point(128, 650);
            AddReg.Name = "Enter";
            AddReg.Size = new Size(357 + 20, 75 + 20);
            AddReg.FlatAppearance.BorderSize = 0;
            AddReg.FlatStyle = FlatStyle.Flat;
            AddReg.TabIndex = 0;
            AddReg.Image = Image.FromFile("button/Registration.png");
            AddReg.UseVisualStyleBackColor = true;

            this.Controls.Add(AddReg);

            // кнопка НАЗАД
            ReturnReg.Location = new Point(128, 760);
            ReturnReg.Name = "ReturnReg";
            ReturnReg.Size = new Size(357 + 20, 75 + 20);
            ReturnReg.FlatAppearance.BorderSize = 0;
            ReturnReg.FlatStyle = FlatStyle.Flat;
            ReturnReg.TabIndex = 0;
            ReturnReg.Image = Image.FromFile("button/ReturnReg.png");
            ReturnReg.UseVisualStyleBackColor = true;

            this.Controls.Add(ReturnReg);
            ReturnReg.Click += (sender, e) =>
            {
                OnOffRegisterStr(false);
                OnOffMainStr(true);
            };

        }

        Button TEST = new Button();          //список тестов
        Button OtherUser = new Button();     //сменить пользователя
        Button AllRating = new Button();     //рейтинг всех пользователей
        Button MyRating = new Button();      //мой рейтинг
        Button Administrator = new Button(); //администрирование
        Button ExitTest = new Button();

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

            // фон test
            fonTest.Image = Image.FromFile("img/fonTestMain.png");
            fonTest.Location = new Point(0, 30);
            fonTest.Name = "testFon";
            fonTest.Size = new Size(1600, 875);
            fonTest.SizeMode = PictureBoxSizeMode.Zoom;
            fonTest.TabIndex = 0;
            fonTest.TabStop = false;
            fonTest.SendToBack();

            this.Controls.Add(fonTest);

            // Рисование текста поверх PictureBox
            using (Graphics g = Graphics.FromImage(fonTest.Image))
            {
                using (Font font = new Font(privateFonts.Families[0], 96, FontStyle.Bold))
                {
                    g.DrawString("Тестирующая программа", font, Brushes.Black, new PointF(350, 0));
                }
            }
            fon.Invalidate(); // Обновляем PictureBox, чтобы изменения отобразились

            // кнопка TEST
            TEST.Location = new Point(411, 170);
            TEST.Name = "TEST";
            TEST.Size = new Size(305 + 20, 52 + 20);
            TEST.BackColor = Color.FromArgb(252, 243, 224); // установка цвета
            TEST.FlatAppearance.BorderSize = 0;
            TEST.FlatStyle = FlatStyle.Flat;
            TEST.TabIndex = 0;
            TEST.Image = Image.FromFile("button/Test.png");
            TEST.UseVisualStyleBackColor = true;

            this.Controls.Add(TEST);
            TEST.BringToFront();

            // кнопка СМЕНИТЬ ПОЛЬЗОВАТЕЛЯ
            OtherUser.Location = new Point(617, 260);
            OtherUser.Name = "OtherUser";
            OtherUser.Size = new Size(305 + 20, 74 + 20);
            OtherUser.BackColor = Color.FromArgb(252, 243, 224); // установка цвета
            OtherUser.FlatAppearance.BorderSize = 0;
            OtherUser.FlatStyle = FlatStyle.Flat;
            OtherUser.TabIndex = 0;
            OtherUser.Image = Image.FromFile("button/OtherUser.png");
            OtherUser.UseVisualStyleBackColor = true;

            this.Controls.Add(OtherUser);
            OtherUser.BringToFront();
            Registr.Click += (sender, e) =>
            {
                OnOffTestMain(false);
                OnOffMainStr(true);

            };

            // кнопка ВЫХОД
            ExitTest.Location = new Point(617, 360);
            ExitTest.Name = "ExitTest";
            ExitTest.Size = new Size(305 + 20, 74 + 20);
            ExitTest.FlatAppearance.BorderSize = 0;
            ExitTest.BackColor = Color.FromArgb(252, 243, 224); // установка цвета
            ExitTest.FlatStyle = FlatStyle.Flat;
            ExitTest.TabIndex = 0;
            ExitTest.Image = Image.FromFile("button/ExitTestMain.png");
            ExitTest.UseVisualStyleBackColor = true;

            this.Controls.Add(ExitTest);
            ExitTest.BringToFront();
            ExitTest.Click += (sender, e) => { this.Close(); }; //обработчик события Click

            // кнопка Admin
            Administrator.Location = new Point(1127, 373);
            Administrator.Name = "Admin";
            Administrator.Size = new Size(305 + 20, 52 + 20);
            Administrator.BackColor = Color.FromArgb(252, 243, 224); // установка цвета
            Administrator.FlatAppearance.BorderSize = 0;
            Administrator.FlatStyle = FlatStyle.Flat;
            Administrator.TabIndex = 0;
            Administrator.Image = Image.FromFile("button/Admin.png");
            Administrator.UseVisualStyleBackColor = true;

            this.Controls.Add(Administrator);
            Administrator.BringToFront();

            // кнопка MyRating
            MyRating.Location = new Point(430, 454);
            MyRating.Name = "MyRating";
            MyRating.Size = new Size(305 + 20, 52 + 20);
            MyRating.BackColor = Color.FromArgb(252, 243, 224); // установка цвета
            MyRating.FlatAppearance.BorderSize = 0;
            MyRating.FlatStyle = FlatStyle.Flat;
            MyRating.TabIndex = 0;
            MyRating.Image = Image.FromFile("button/MyRating.png");
            MyRating.UseVisualStyleBackColor = true;

            this.Controls.Add(MyRating);
            MyRating.BringToFront();

            // кнопка Rating
            AllRating.Location = new Point(697, 792);
            AllRating.Name = "Rating";
            AllRating.Size = new Size(305 + 20, 52 + 20);
            AllRating.BackColor = Color.FromArgb(252, 243, 224); // установка цвета
            AllRating.FlatAppearance.BorderSize = 0;
            AllRating.FlatStyle = FlatStyle.Flat;
            AllRating.TabIndex = 0;
            AllRating.Image = Image.FromFile("button/AllRating.png");
            AllRating.UseVisualStyleBackColor = true;

            this.Controls.Add(AllRating);
            AllRating.BringToFront();

        }



    }
}
