using BingoGo_V2.Properties;
using Guna.UI.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BingoGo_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ruta1 = Application.StartupPath;
        System.Windows.Media.MediaPlayer d = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer clock_back = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer change_number = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer two_gift = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer timer_gift = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer game_over = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer all_done = new System.Windows.Media.MediaPlayer();

        private List<List<int>> numberMaked = new List<List<int>>();
        private List<int> numberToMaked_pos = new List<int>();

        private List<int> numberListAleatorie = new List<int>();

        private List<int> ListHorizontal = new List<int>();
        private List<int> ListVertical = new List<int>();
        private bool diagonalA = false;
        private bool diagonalB = false;


        private bool flag_gift = false;

        private int table_long = 5;
        private int game_duration = 155;
        private int prog_bar_cant = 50;
        private int dice_duration = 5;
        private int mm, ss;
        private int s;

        //puntuacion y premios
        private int points = 0;

        private int mark_celd_point = 100;
        private int bingo_diagonal = 1000;
        private int bingo_corner = 1250;
        private int bingo_line = 1500;
        //extra points
        private int two_bingos = 250;
        //percent for progrees bar of the extra items 
        private int mark_celd = 20;
        private int do_bingo = 40;

        //contadores de lineas marcadas
        private List<int> winers_pos = new List<int>();
        private int diagonal1 = 0;
        private int diagonal2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void load_numbers()
        {          
            d.Open(new System.Uri(ruta1 + @"\sonidos\backSound.wav"));
            d.Play();

            for (int i = 1; i <= table_long; i++)
            {
                List<int> randomLog = new List<int>();

                for (int j = 1; j <= table_long; j++)
                {
                    int number = random_generate(randomLog, ((i - 1) * 15) + 1, i * 15);
                    randomLog.Add(number);
                    gunaElipsePanel1.Controls.Add(crearbtn(i, j, number, 10+(66*(i-1)), 10+66*j));
                    numberToMaked_pos.Add(Convert.ToInt32(string.Format("{0}{1}", i, j)));

                }
                numberMaked.Add(randomLog);                
            }
        }
        /**********************
         * functions 
         * ********************
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            ss -= 1;

            string ss1, ss2, mm1, mm2;

            if (ss <= 0)
            {
                mm -= 1;
                ss = 60;

                if (mm <= 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    btn_game_over.Visible = true;

                    gunaElipsePanel1.Enabled = false;
                    items_group.Visible = false;
                    progressBar.Visible = false;

                    game_over.Open(new System.Uri(ruta1 + @"\sonidos\Fireball+3.wav"));
                    game_over.Play();
                }
            }
            if(mm == 0 && ss <= 10)
            {
                clock_back.Open(new System.Uri(ruta1 + @"\sonidos\clock-tick1.wav"));
                clock_back.Play();

                LBL_S1.ForeColor = LBL_S2.ForeColor = LBL_dp.ForeColor = LBL_M1.ForeColor = LBL_M2.ForeColor = (LBL_M1.ForeColor == Color.Red) ? Color.BlueViolet : Color.Red;
            }
            
            ss1 = (ss < 10) ? "0" + Convert.ToString(ss) : Convert.ToString(ss);
            mm1 = (mm < 10) ? "0" + Convert.ToString(mm) : Convert.ToString(mm);

            LBL_S1.Text = (ss < 10) ? "0" : Convert.ToString(ss / 10);
            LBL_S2.Text = Convert.ToString(ss % 10);

            LBL_dp.Text = (LBL_dp.Text == "") ? ":" : "";

            LBL_M1.Text = (mm < 10) ? "0" : Convert.ToString(mm / 10);
            LBL_M2.Text = Convert.ToString(mm % 10);
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s -= 1;
            string ss1;

            if (s == 0)
            {
                change_number.Open(new System.Uri(ruta1 + @"\sonidos\lighter.wav"));
                change_number.Play();

                //cargo un nuevo numero
                load_aleatorie_number();
                s = dice_duration;
            }
            ss1 = (s < 10) ? "0" + Convert.ToString(s) : Convert.ToString(s);
            label2.Text = Convert.ToString(ss1);
        }
        private void reiniciar_game()
        {
            numberToMaked_pos.Clear();
            numberMaked.Clear();
            gunaElipsePanel1.Controls.Clear();
            items_group.Controls.Clear();

            ListHorizontal.Clear();
            ListVertical.Clear();
            diagonalA = false;
            diagonalB = false;

            lbl_punctuation.Text = "";
            lbl_numeroAleatorio.Text = "";
            label2.Text = "";
            gunaElipsePanel2.BaseColor = Color.Transparent;
            progressBar.Value = 0;

            label2.Text = "";
            label2.Text = "";

            progressBar.Visible = false;
            btn_bingo.Visible = false;
            items_group.Visible = false;

            gunaElipsePanel1.Enabled = true;
            gunaElipsePanel1.Visible = false;
            gunaPictureBox1.Visible = false;
            gunaPictureBox2.Visible = false;
            gunaPictureBox3.Visible = false;
            gunaPictureBox4.Visible = false;
            gunaPictureBox5.Visible = false;
            
            timer1.Stop();
            timer2.Stop();
            LBL_S1.ForeColor = LBL_S2.ForeColor = LBL_dp.ForeColor = LBL_M1.ForeColor = LBL_M2.ForeColor = Color.Black;
            LBL_M1.Text = "0";
            LBL_M2.Text = "0";
            LBL_S1.Text = "0";
            LBL_S2.Text = "0";
            mm = 0;
            ss = 0;
            s = 0;            
            d.Stop();
            clock_back.Stop();
            change_number.Stop();
        }
        private void new_play_Click(object sender, EventArgs e)
        {
            btn_bingo.Text = "!!BINGO!!";
            reiniciar_game();
            load_numbers();
            load_aleatorie_number();
            
            new_play.Enabled = false;
            btn_bingo.Enabled = false;

            progressBar.Visible = true;
            btn_bingo.Visible = true;
            items_group.Visible = true;
            gunaElipsePanel1.Visible = true;
            gunaPictureBox1.Visible = true;
            gunaPictureBox2.Visible = true;
            gunaPictureBox3.Visible = true;
            gunaPictureBox4.Visible = true;
            gunaPictureBox5.Visible = true;

            Thread.Sleep(20);

            ss = game_duration % 60;
            mm = game_duration / 60;
            s = dice_duration;
            timer1.Start();
            timer2.Start();
        }
        protected void button_Click(object sender, EventArgs e)
        {
            GunaButton button = sender as GunaButton;
            //sacar la posicion a la que le vamos a poner el numero que se marca
            string[] name_split = button.Name.Split('_');

            if (numberToMaked_pos.Contains(Convert.ToInt32(string.Format("{0}{1}", name_split[1], name_split[2]))))
            {
                if (flag_gift)
                {
                    mark_number(button, name_split[1], name_split[2]);
                    flag_gift = false;
                    timer1.Start();
                    timer2.Start();
                }
                else
                {
                    if (button.Text == lbl_numeroAleatorio.Text)
                    {
                        mark_number(button, name_split[1], name_split[2]);
                    }
                    else
                    {
                        if (progressBar.Value > 0)
                        {
                            int aux = progressBar.Value - 10;
                            progressBar.Value = (aux < 0) ? 0 : aux;
                        }
                        else
                        {
                            if (points > 0)
                            {
                                int aux = points - 50;
                                lbl_punctuation.Text = (aux < 0) ? "00" : Convert.ToString(aux);
                                points = (aux < 0) ? 0 : aux;
                            }
                        }
                    }
                }
            }
        }
        private void mark_number(GunaButton button, string numberA, string numberB)
        {
            button.BackColor = Color.Coral;

            //progress bar
            progress_Bar_add(mark_celd);

            points += mark_celd_point * s;
            lbl_punctuation.Text = Convert.ToString(points);

            //Namemarked es una variable que me almacena todos los numeros que tengo en la tabla de bingo, los pongo en 0 para saber cual se marco
            if (numberMaked[Convert.ToInt32(numberA) - 1][Convert.ToInt32(numberB) - 1] == Convert.ToInt32(button.Text))
            {
                numberListAleatorie.Add(numberMaked[Convert.ToInt32(numberA) - 1][Convert.ToInt32(numberB) - 1]);

                numberMaked[Convert.ToInt32(numberA) - 1][Convert.ToInt32(numberB) - 1] = 0;

                //aqui voy a buscar la poscion y eliminarla
                numberToMaked_pos.Remove(Convert.ToInt32(string.Format("{0}{1}", numberA, numberB)));

                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(ruta1 + @"\sonidos\click.wav");
                sound.Play();

            }
            button.Enabled = false;

            /***************************/
            //find lines or diagonals 
            /***************************/
            if (is_line_X(int.Parse(numberA) - 1, int.Parse(numberB) - 1))
            {
                modify_bingo_btn(true);
            }
            if (is_line_Y(int.Parse(numberA) - 1, int.Parse(numberB) - 1))
            {
                modify_bingo_btn(true);
            }
            if (is_diagonal_top(int.Parse(numberA) - 1, int.Parse(numberB) - 1))
            {
                modify_bingo_btn(true);
            }
            if (is_diagonal_bottom(int.Parse(numberA) - 1, int.Parse(numberB) - 1))
            {
                modify_bingo_btn(true);
            }
        }
        private void progress_Bar_add(int mark_celd)
        {
            int ProgBarAux = progressBar.Value;
            ProgBarAux += mark_celd * s;

            if (ProgBarAux >= prog_bar_cant)
            {
                ProgBarAux -= prog_bar_cant;
                progressBar.Value = 0;

                if(ProgBarAux > prog_bar_cant)
                {
                    ProgBarAux %= prog_bar_cant;
                }
                progressBar.Value = ProgBarAux;
                add_Giftbtn();
            }
            else
            {
                progressBar.Value = ProgBarAux;
            }
        }
        private void add_Giftbtn()
        {
            if(items_group.Controls.Count < 3)
            {
                Random rnd = new Random();
                items_group.Controls.Add(crearGiftbtn(rnd.Next(2, 2)));
            }
        }
        private void gift_action_choose()
        {
            flag_gift = true;
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("Please choose one number.");
        }
        private void gift_action_time()
        {
            game_duration = (mm * 60) + ss + 10;
            ss = game_duration % 60;
            mm = game_duration / 60;
            timer1.Stop();
            timer1.Start();
            timer_gift.Open(new System.Uri(ruta1 + @"\sonidos\electricshock.wav"));
            timer_gift.Play();
        }
        private void gift_action_choose_aleatorie()
        {
            two_gift.Open(new System.Uri(ruta1 + @"\sonidos\Swing.wav"));
            two_gift.Play();

            //Buscar las posciones a marcar
            int element_1 = 0;
            int element_2 = 0;

            int x_1, y_1, x_2, y_2 = 0;
            GunaButton btn, btn1;

            Random rnd = new Random();
            int cant = 2;

            switch (numberToMaked_pos.Count)
            {
                case 1:

                    element_1 = numberToMaked_pos[0];

                    numberToMaked_pos.Clear();
                    cant = 1;

                    x_1 = element_1 / 10;
                    y_1 = element_1 % 10;

                    btn = gunaElipsePanel1.Controls.OfType<GunaButton>().Where(btn_x => btn_x.Name == "bt_" + x_1 + "_" + y_1).FirstOrDefault();
                    mark_number(btn, Convert.ToString(x_1), Convert.ToString(y_1));

                    break;

                case 2:
                    //Elemento 1;
                    element_1 = numberToMaked_pos[0];
                    x_1 = element_1 / 10;
                    y_1 = element_1 % 10;

                    btn = gunaElipsePanel1.Controls.OfType<GunaButton>().Where(btn_x => btn_x.Name == "bt_" + x_1 + "_" + y_1).FirstOrDefault();
                    mark_number(btn, Convert.ToString(x_1), Convert.ToString(y_1));

                    //Elemento 2
                    element_2 = numberToMaked_pos[0];
                    x_2 = element_2 / 10;
                    y_2 = element_2 % 10;
                    btn1 = gunaElipsePanel1.Controls.OfType<GunaButton>().Where(btn_x => btn_x.Name == "bt_" + x_2 + "_" + y_2).FirstOrDefault();
                    mark_number(btn1, Convert.ToString(x_2), Convert.ToString(y_2));

                    numberToMaked_pos.Clear();

                    break;

                case 0:
                    goto finish;

                default:
                    //Elemento 1;
                    element_1 = numberToMaked_pos[rnd.Next(0, numberToMaked_pos.Count)];
                    x_1 = element_1 / 10;
                    y_1 = element_1 % 10;

                    btn = gunaElipsePanel1.Controls.OfType<GunaButton>().Where(btn_x => btn_x.Name == "bt_" + x_1 + "_" + y_1).FirstOrDefault();
                    mark_number(btn, Convert.ToString(x_1), Convert.ToString(y_1));

                    //Elemento 2
                    element_2 = numberToMaked_pos[1];
                    x_2 = element_2 / 10;
                    y_2 = element_2 % 10;
                    btn1 = gunaElipsePanel1.Controls.OfType<GunaButton>().Where(btn_x => btn_x.Name == "bt_" + x_2 + "_" + y_2).FirstOrDefault();
                    mark_number(btn1, Convert.ToString(x_2), Convert.ToString(y_2));
                    
                    break;
            }

            finish:
                return;

        }
        private bool is_line_X(int x, int y)
        {
            int cant_marked = 1;
            int x_aux1 = x, x_aux2 = x;
            int aux = 1;

            while(aux < table_long)
            {
                if((x_aux1 - 1) >= 0)
                    if (numberMaked[x_aux1 - 1][y] != 0) goto finish;
                    else cant_marked++;
                if ((x_aux2 + 1) < table_long)
                    if (numberMaked[x_aux2 + 1][y] != 0) goto finish;
                    else cant_marked++;

                aux++;
                x_aux1--; x_aux2++;


            }

            finish:
                if (cant_marked == table_long)
                {
                    ListHorizontal.Add( y );
                    return true;
                }
                else
                    return false;
        }
        private bool is_line_Y(int x, int y)
        {
            int cant_marked = 1;
            int y_aux1 = y, y_aux2 = y;
            int aux = 1;

            while (aux < table_long)
            {
                if ((y_aux1 - 1) >= 0)
                    if (numberMaked[x][y_aux1 - 1] != 0) goto finish;
                    else cant_marked++;
                if ((y_aux2 + 1) < table_long)
                    if (numberMaked[x][y_aux2 + 1] != 0) goto finish;
                    else cant_marked++;

                aux++;
                y_aux1--; y_aux2++;

            }

            finish:
                if (cant_marked == table_long)
                {
                    ListVertical.Add( x );
                    return true;
                }
                else
                    return false;
        }
        private bool is_diagonal_top(int x, int y)
        {
            int cant_marked = 1;
            int x_aux1 = x, x_aux2 = x;
            int y_aux1 = y, y_aux2 = y;
            int aux = 1;


            //reconoger diagonales
            if(x == y)
            {
                //entonces es diagonal top, except si es el medio
                while (aux < table_long)
                {
                    if ((x_aux1 - 1) + (y_aux1 - 1) >= 0)
                        if (numberMaked[x_aux1 - 1][y_aux1 - 1] != 0) goto finish;
                        else cant_marked++;

                    if ((x_aux2 + 1) + (y_aux2 + 1) < table_long * 2)
                        if (numberMaked[x_aux2 + 1][y_aux2 + 1] != 0) goto finish;
                        else cant_marked++;
                    
                    aux++;
                    x_aux1--; x_aux2++;
                    y_aux1--; y_aux2++;

                }
            }

            finish:
                if (cant_marked == table_long)
                {
                    diagonalA = true;
                    return true;
                }
                else
                    return false;
        }
        private bool is_diagonal_bottom(int x, int y)
        {
            int cant_marked = 1;
            int x_aux1 = x, x_aux2 = x;
            int y_aux1 = y, y_aux2 = y;
            int aux = 1;


            //recorrer diagonales
            if ((x + y) == (table_long - 1))
            {
                //entonces es diagonal top, except si es el medio
                while (aux < table_long)
                {
                    if (Math.Abs(x_aux1 - 1) + (y_aux1 + 1) < table_long)
                        if (numberMaked[x_aux1 - 1][y_aux1 + 1] != 0) goto finish;
                        else cant_marked++;

                    if ((x_aux2 + 1) + Math.Abs(y_aux2 - 1) < table_long)
                        if (numberMaked[x_aux2 + 1][y_aux2 - 1] != 0) goto finish;
                        else cant_marked++;

                    aux++;
                    x_aux1--; x_aux2++;
                    y_aux1++; y_aux2--;

                }
            }

            finish:
                if (cant_marked == table_long)
                {
                    diagonalB = true;
                    return true;
                }
                else
                    return false;
        }
        /**********************
        * functions comodins
        * ********************
        */
        private GunaButton crearGiftbtn(int id)
        {

            GunaButton guna_btn = new GunaButton();
            guna_btn.Name = "dynamicBtn_" + Convert.ToString(id);
            guna_btn.BaseColor = Color.Transparent;
            guna_btn.Cursor = Cursors.Hand;
            guna_btn.ImageAlign = HorizontalAlignment.Center;
            guna_btn.ImageSize = new Size(40, 40);
            guna_btn.Size = new Size(40, 40);
            guna_btn.OnHoverBaseColor = Color.Transparent;
            guna_btn.OnHoverBorderColor = Color.Transparent;
            guna_btn.OnHoverForeColor = Color.White;
            guna_btn.OnPressedColor = Color.WhiteSmoke;

            guna_btn.Image = imageList1.Images[id];
            guna_btn.Click += new EventHandler(Gift_button_Click);

            return guna_btn;
        }
        protected void Gift_button_Click(object sender, EventArgs e)
        {
            GunaButton button = sender as GunaButton;
            string[] action = button.Name.Split('_');

            if (action[1] == "0")
            {
                gift_action_choose();
            }
            if (action[1] == "1")
            {
                gift_action_time();
            }
            if (action[1] == "2")
            {
                gift_action_choose_aleatorie();
            }

            items_group.Controls.Remove(button);
        }
        private void load_aleatorie_number()
        {
            double v = 0;
            do
            {
                Random rnd = new Random();
                v = rnd.Next(1, 75);
            }
            while (numberListAleatorie.Contains(Convert.ToInt32(v)));

            double aux_v = v / 15;
            long aux1 = (long)aux_v;
            int decim = Convert.ToInt32((aux_v - (double)aux1) * 10);

            int position_number_color = (decim == 0 && aux1 > 0) ? Convert.ToInt32(aux1 - 1) : Convert.ToInt32(aux1);

            switch (position_number_color)
            {
                case 0:
                    gunaElipsePanel2.BaseColor = Color.Firebrick;
                    break;
                case 1:
                    gunaElipsePanel2.BaseColor = Color.Orange;
                    break;
                case 2:
                    gunaElipsePanel2.BaseColor = Color.ForestGreen;
                    break;
                case 3:
                    gunaElipsePanel2.BaseColor = Color.SteelBlue;
                    break;
                case 4:
                    gunaElipsePanel2.BaseColor = Color.DarkViolet;
                    break;

            }

            lbl_numeroAleatorio.Text = Convert.ToString(v);
        }
        private int random_generate(List<int> listRandomLog, int min, int max)
        {
            int v = 0;
            do
            {
                Random rnd = new Random();
                v = rnd.Next(min, max);
            }
            while (listRandomLog.Contains(v));

            return v;
        }
        private GunaButton crearbtn(int a, int b, int text, int location_x, int location_y)
        {
            GunaButton btn = new GunaButton();
            btn.Name = "bt_" + a + "_" + b;
            btn.Size = new Size(60, 60);
            btn.Text = Convert.ToString(text);
            btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            btn.Location = new Point(location_x, location_y);
            btn.Cursor = Cursors.Hand;

            btn.Image = null;
            btn.Radius = 5;
            btn.BackColor = Color.Transparent;
            btn.BaseColor = Color.AntiqueWhite;
            btn.TextAlign = HorizontalAlignment.Center;
            btn.ForeColor = Color.Black;

            btn.Animated = true;
            btn.AnimationHoverSpeed = 0.07F;
            btn.AnimationSpeed = 0.03F;

            btn.Click += new EventHandler(button_Click);

            return btn;

        }

        private void btn_bingo_Click(object sender, EventArgs e)
        {
            int count_bingo = 0;

            /********************************
             *busco y marco los horizontales*
             ********************************/
            for (int i = 0; i < ListHorizontal.Count; i++)
            {
                for (int j = 1; j <= table_long; j++)
                {
                    ultimate_bingo_btn(j, ListHorizontal[i] + 1);
                }
                
                count_bingo++;
            }

            /********************************
             *busco y marco los verticales*
             ********************************/
            for (int i = 0; i < ListVertical.Count; i++)
            {
                for (int j = 1; j <= table_long; j++)
                {
                    ultimate_bingo_btn(ListVertical[i] + 1, j);
                }

                count_bingo++;
            }
            /********************************
            *busco y marco los diagonales*
            ********************************/
            if (diagonalA)
            {
                for (int i = 1; i <= table_long; i++)
                {
                        ultimate_bingo_btn(i, i);
                }
                count_bingo++;
            }
            if (diagonalB)
            {
                int j = table_long;
                for (int i = 1; i <= table_long; i++)
                {
                    ultimate_bingo_btn(i, j);
                    j--;
                }
                count_bingo++;
            }
            btn_bingo.Enabled = false;

            /**Points**/
            if (diagonalA || diagonalB)
                points += (count_bingo >= 1) ? bingo_diagonal + two_bingos * count_bingo : bingo_diagonal;
            if(ListHorizontal.Count > 0 || ListVertical.Count > 0)
                points += (count_bingo >= 1) ? bingo_line + two_bingos * count_bingo : bingo_line;

            lbl_punctuation.Text = Convert.ToString(points);
            progress_Bar_add(do_bingo * count_bingo);

            //emito los sonidos aqui
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(ruta1 + @"\sonidos\1Bingo.wav");
            sound.Play();

            if(numberToMaked_pos.Count == 0)
            {
                gunaElipsePanel1.Enabled = false;
                items_group.Visible = false;
                progressBar.Visible = false;

                all_done.Open(new System.Uri(ruta1 + @"\sonidos\Fireball+3.wav"));
                all_done.Play();

                btn_full_house.Visible = true;
                timer1.Stop();
                timer2.Stop();
            }

        }

        private void ultimate_bingo_btn(int x, int y)
        {
            GunaButton btn = new GunaButton();
            btn = gunaElipsePanel1.Controls.OfType<GunaButton>().Where(btn_x => btn_x.Name == "bt_" + x + "_" + y).FirstOrDefault();

            btn.BaseColor = Color.Transparent;
            btn.Text = "";
            btn.ImageAlign = HorizontalAlignment.Center;
            btn.ImageSize = new Size(60, 60);
            
            btn.OnHoverBaseColor = Color.Transparent;
            btn.OnHoverBorderColor = Color.Transparent;
            btn.OnHoverForeColor = Color.White;
            btn.OnPressedColor = Color.WhiteSmoke;

            btn.Image = imageList1.Images[3];
        }
        private void btn_game_over_Click(object sender, EventArgs e)
        {
            reiniciar_game();
            new_play.Enabled = true;
            btn_bingo.Text = "";
            btn_game_over.Visible = false;
        }

        private void btn_full_house_Click(object sender, EventArgs e)
        {
            reiniciar_game();
            new_play.Enabled = true;
            btn_bingo.Text = "";
            btn_full_house.Visible = false;
        }

        private void modify_bingo_btn(bool action)
        {
            if (action)
            {
                btn_bingo.BaseColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                btn_bingo.BorderColor = Color.Black;
                btn_bingo.BorderSize = 3;
                btn_bingo.Enabled = true;
            }
            else
            {
                btn_bingo.BackColor = Color.Transparent;
                btn_bingo.BaseColor = Color.Transparent;
                btn_bingo.BorderColor = Color.Transparent;
                btn_bingo.BorderSize = 0;

                btn_bingo.OnHoverBaseColor = Color.Transparent;
                btn_bingo.OnHoverBorderColor = Color.Transparent;
                btn_bingo.OnHoverForeColor = Color.White;
                btn_bingo.OnPressedColor = Color.WhiteSmoke;

                btn_bingo.Enabled = false;

            }
        }

    }
}
