using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game15
{
    public partial class FormGame15 : Form
    {
        Game game;
        int counter = 1;
        int size = 3;//переменная уровня
        Image[,] img;//массив для хранения нарезанной картинки
        PictureBox[,] box;

        public FormGame15()
        {
            InitializeComponent();
            label2.Text = "0";
        }

        private void Button0_Click(object sender, EventArgs e)//событие при нажатии на любую кнопку
        {
            

        }

        private void FormGame15_Load(object sender, EventArgs e)
        {
            start_game();
        }

        private void Menu_start_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void start_game()
        {
            game = new Game(size);
            crop_image();//нарезать картинку
            init_pictures();//добавит все необходимые картинки на нашу панель
            game.start();
            for (int i = 0; i < 100; i++)
                game.shift_random();
            refresh();
            label2.Text = "0";
            counter = 1;
        }

         private void crop_image() //нарезать картинку
        {
            img = new Image[size, size];//размер массива
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    img[x, y] = get_image_part(x, y);
        }

        private Bitmap get_image_part(int x, int y)
        {
            Bitmap bitmap = Properties.Resources.poselok_u_morya;//целая картинка
            int w, h;//переменные ширины и высоты
            w = bitmap.Width / size;//ширина одной нарезанной части картинки
            h = bitmap.Height / size;//высота одной нарезанной части картинки
            Rectangle crop_part = new Rectangle(x * w, y * h, w, h);
            Bitmap target = new Bitmap(w, h);//размер каждой маленькой картинки
            Graphics g = Graphics.FromImage(target);//нарисовать на target маленькую картинку
            g.DrawImage(
                bitmap,
                new Rectangle(0, 0, target.Width, target.Height),
                crop_part,
                GraphicsUnit.Pixel);//рисует указанный image, используя параметры
            return target;
        }

        private void init_pictures()//добавит все необходимые картинки на нашу панель
        {
            int w, h;//переменные ширины и высоты
            w = panel1.Width / size;
            h = panel1.Height / size;

            panel1.Controls.Clear(); //очистка панели
            box = new PictureBox[size, size];//создали нужное количество пустых элементов в массиве
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                {
                    PictureBox pb = new PictureBox();

                    pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pb.Location = new System.Drawing.Point(x * w, y * h);
                    pb.Size = new System.Drawing.Size(w, h);
                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pb.Tag = y * size + x;
                    pb.Click += new System.EventHandler(this.PictureBox1_Click);

                    panel1.Controls.Add(pb);

                    box[x, y] = pb;
                }

        }

        private void refresh ()
        {
            for (int position = 0; position < size * size; position++)
            {
                int nr = game.get_number(position);
                box[position % size, position / size].Visible = (nr >= 0);
                if (nr >= 0)
                    box [position % size, position / size].Image = img[nr % size, nr / size];
            }
        }

        private void ОкончитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_level_3_Click(object sender, EventArgs e)
        {
            size = 3;
            start_game();
        }

        private void Menu_level_4_Click(object sender, EventArgs e)
        {
            size = 4;
            start_game();
        }

        private void Menu_level_5_Click(object sender, EventArgs e)
        {
            size = 5;
            start_game();
        }

        private void Menu_level_6_Click(object sender, EventArgs e)
        {
            size = 6;
            start_game();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((PictureBox)sender).Tag);//запись в переменную position цифры кнопки из поля Tag
            game.shift(position);
            refresh();
            label2.Text = counter++.ToString();

            if (game.check_numbers())
            {
                MessageBox.Show("Победа!", "Поздравление");
                start_game();
            }
        }
    }
}
