namespace Treads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            ColorRojo();
        }

        private void ColorRojo()
        {
            int rojo = 0;   
            bool aumentar = true;
            while (true)
            {
                if (aumentar == true)
                {
                    rojo++;
                    if (rojo == 256)
                    {
                        aumentar = false;
                        rojo = 255;
                    }
                    else
                    {
                        rojo--;
                        if (rojo == -1)
                        {
                            aumentar = true;
                            rojo = 0;
                        }

                    }
                    rojo++;
                    pcb_color.BackColor = Color.FromArgb(rojo, 0, 0);
                    Thread.Sleep(10);
                }
            }
        }
    }
}
