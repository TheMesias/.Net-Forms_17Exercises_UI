using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class MATEMENTE : Form
    {
        Random randomizer = new Random();

        //suma 
        int addend1;
        int addend2;

        //resta 
        int minuend;
        int subtrahend;

        //multiplicacion
        int multiplicand;
        int multiplier;

        //division 
        int dividend;
        int divisor;

        //segundos partida
        int timeLeft; 


        //agregar ramdom a los labels e iniciar timer 
        public void StartTheQuiz()
        {
            //suma 
            //agregar el numero ramdon a las variables
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            //agregar el numero pasado a string en los labels sumas
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            //valor inicial de la suma en 0 al inciar
            suma.Value = 0;

            //resta 
            minuend = randomizer.Next(1, 101);
            //entre 1 y el minuendo -1 para que no salga negativo
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;


            //multiplicacion 
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //division 
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;


            //iniciar el tiempo
            timeLeft = 30;
            timeLabel.Text = "30 segundos";
            timer1.Start();
        }

        //programa
        public MATEMENTE()
        {
            InitializeComponent();
        }

        //empezar el juego 
        private void startbuton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startbuton.Enabled = false; 
        }

        //messages 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Acertaste con las Respuestas!",
                                "Felicidades!");
                  
                startbuton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " segundos";
            }
            else
            {   
                timer1.Stop();
                MessageBox.Show("Se te acabo el tiempo", "Lo siento!");
                suma.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;

                startbuton.Enabled = true;
            }
        }

        //Check de Answer 
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == suma.Value) && (minuend - subtrahend == difference.Value) && (multiplicand * multiplier == product.Value)
        && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }


       //eliminacion del 0 al momento de escribir otro numero 
        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void MATEMENTE_Load(object sender, EventArgs e)
        {
            
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
