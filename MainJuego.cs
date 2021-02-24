using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace JuegoTragamonedas
{
    //Elaborado por Juan Sebastian Camargo
    public partial class MainJuego : Form

       
    {
        // Se crean nuevos objetivos tipo List<PictureBox>
        List<PictureBox> 
        GrupoFichasUno = new List<PictureBox>(),
        GrupoFichasDos = new List<PictureBox>(),
        GrupoFichasTres = new List<PictureBox>();

        //Variables
        int movimientoY = 0, posicionSiguiente, longitudFicha, posicionEjeX = 10;
        bool indicador1 = false, indicador2 = false, indicador3 = false;
        string nombreFicha1 = "", nombreFicha2 = "", nombreFicha3 = "";

        public MainJuego()
        {
            InitializeComponent();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            MessageBox.Show("-Bienvenidos al Slot Machine:\n-Para jugar presionar el boton 'Play'\n-Seguido a esto para detener cada una de las casillas presione los botones 'Stop' de izquierda a derecha\n(NO PRESIONAR LOS BOTONES 'Stop' SIN DARLE 'Play' ANTES)\n-Juego elaborado por: Juan Sebastian Camargo Prieto");

        }


        private void MainJuego_Load(object sender, EventArgs e)
            //Panel que carga las imagenes al cargar el programa
        {
            CrearImagenes(GrupoFichasUno, panelJuego1, "Uno");
            CrearImagenes(GrupoFichasDos, panelJuego2, "Dos");
            CrearImagenes(GrupoFichasTres, panelJuego3, "Tres");
                
        }

        public int NumeroFicha(string N)
            //traer el valor del cada Ficha
        {
            string[] Pos = N.Split("_".ToCharArray());
            return Convert.ToInt32(Pos[1]);
        }


        public List<PictureBox> CrearImagenes(List<PictureBox> Lista, Panel panel, string nombreTag) {
        //Metodo para asignarle el valor a cada imagen y para asignarle al panel cada imagen (9 imagenes)
        
            longitudFicha = 190;
            for (int i = 0; i < 9; i++) {
                PictureBox picbox = new PictureBox();
                picbox.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("sm" + (i + 1)); //Se traen todos los objetos que tengan el nombre 'sm' y con el 'for' se van sumando las imagenes
                picbox.Size = new Size(longitudFicha, longitudFicha); //Declarar nuevo size para las imagenes
                picbox.SizeMode = PictureBoxSizeMode.StretchImage; // Hacer que las imagenes queden en formato Scretch
                picbox.Name = string.Format("{0}", i + nombreTag);
                picbox.Tag = nombreTag + "_" + i;
                int movim = picbox.Location.Y;
                picbox.Location = new Point(posicionEjeX, i * longitudFicha);
                Lista.Add(picbox);
                panel.Controls.Add(Lista[i]);

            }
            return Lista;
        }

        public String GirarFichas(List<PictureBox> Lista, Panel panel, Timer timer, bool bandera) {
        //Metodo para Girar las fichas con la lista
            string fichaSeleccionada = "";
            for (int i = 0; i < Lista.Count; i++) {

                movimientoY = Lista[i].Location.Y;
                Lista[i].Location = new Point(posicionEjeX, movimientoY - 10);

                if (Lista[i].Location.Y <= -longitudFicha) {
                    posicionSiguiente = Lista[((Lista.Count) - 1)].Location.Y;
                    Lista[i].Location = new Point(posicionEjeX, posicionSiguiente + longitudFicha);
                    Lista.Add(Lista[i]);
                    panel.Controls.Add(Lista[i]);
                    Lista.RemoveAt(i);

                }

                if (bandera){
                    if (Lista[i].Location.Y == -10){
                        timer.Stop();
                        fichaSeleccionada = Lista[i].Tag.ToString();
                    }
                }
                else {

                    fichaSeleccionada = "";
                
                }
            }

            return fichaSeleccionada;
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
            //Panel Help
        {
            MessageBox.Show("-Bienvenidos al Slot Machine:\n-Para jugar presionar el boton 'Play'\n-Seguido a esto para detener cada una de las casillas presione los botones 'Stop' de izquierda a derecha\n(NO PRESIONAR LOS BOTONES 'Stop' SIN DARLE 'Play' ANTES)\n-Juego elaborado por: Juan Sebastian Camargo Prieto");
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
            //Panel Exit
        {
            MessageBox.Show("Gracias por Jugar!");
            this.Close();

        }

        //TIMERS
        private void timer1_Tick(object sender, EventArgs e) 
        {
            nombreFicha1 = GirarFichas(GrupoFichasUno, panelJuego1,timer1,indicador1);
        }
        private void timer2_Tick(object sender, EventArgs e) 
        {
            nombreFicha2 = GirarFichas(GrupoFichasDos, panelJuego2, timer2, indicador2);
        }   
        private void timer3_Tick(object sender, EventArgs e) 
        {
            nombreFicha3 = GirarFichas(GrupoFichasTres, panelJuego3, timer3, indicador3);
            if (nombreFicha3 != "")
            { 
                imagenBotonPlay.Image = Properties.Resources.Play_Blanco;
                //VALIDAR GANADOR
                if ((NumeroFicha(nombreFicha1) == NumeroFicha(nombreFicha2) && NumeroFicha(nombreFicha2) == NumeroFicha(nombreFicha3)))
                {
                    MessageBox.Show("Ganaste, felicidades!");

                }
                //V
                else 
                {
                    MessageBox.Show("Perdiste, intenta de nuevo!");

                }


            }
        }

        //Paneles Play y Stop

        private void imagenBotonPlay_Click(object sender, EventArgs e)
        {
            indicador1 = false;
            indicador2 = false;
            indicador3 = false;
            timer1.Start();
            imagenBotonPlay.Image = Properties.Resources.Play_Negro;
            pictureBoxStop1.Image = Properties.Resources.Stop_Negro;


        }

        private void pictureBoxStop1_Click(object sender, EventArgs e)
        {
            indicador1 = true;
            timer2.Start();
            pictureBoxStop1.Image = Properties.Resources.Stop_Blanco;
            pictureBoxStop2.Image = Properties.Resources.Stop_Negro;

        }

        private void pictureBoxStop2_Click(object sender, EventArgs e)
        {
            indicador2 = true;
            timer3.Start();
            pictureBoxStop2.Image = Properties.Resources.Stop_Blanco;
            pictureBoxStop3.Image = Properties.Resources.Stop_Negro;
        }
        private void pictureBoxStop3_Click(object sender, EventArgs e)
        {
            indicador3 = true;
            pictureBoxStop3.Image = Properties.Resources.Stop_Blanco;

        }

       

        private void pictureTragaMonedas_Click(object sender, EventArgs e)
        {

        }
    }
}
