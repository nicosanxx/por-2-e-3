using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace por_2e3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nota01.Text == "" || txt_nota02.Text == "" || txt_nota03.Text == "" || txt_nota04.Text == "")
            {

                MessageBox.Show("PREENCHER TODOS OS CAMPOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                //DECLARANDO E ATRIBUINDO VARIAVEIS
                int numero01 = Convert.ToInt32(txt_nota01.Text);
                int numero02 = Convert.ToInt32(txt_nota02.Text);
                int numero03 = Convert.ToInt32(txt_nota03.Text);
                int numero04 = Convert.ToInt32(txt_nota04.Text);

                //DIVISIVEIS POR 2
                if ((numero01 % 2)  == 0)
                {
 
                    txt_por2.Text = numero01.ToString();



                }
                if ((numero02 % 2) == 0)
                {

                    tb_por2.Text = numero02.ToString();


                }
                if((numero03 % 2) == 0)
                {

                    tb_por2_2.Text = numero03.ToString();


                }
                if ((numero04 % 2) == 0)
                {


                    tb_por2_3.Text = numero04.ToString();

                }

                //DIVISIVEIS POR 3
                if((numero01 % 3) == 0)
                {

                    txt_por3.Text = numero01.ToString();
     

                }
                if((numero02 % 3) == 0)
                {

                    tb_por3.Text = numero02.ToString();

                }
                if((numero03 % 3) == 0)
                {

                    tb_por3_2.Text = numero03.ToString();
                }
                if((numero04 % 3) == 0)
                {
                    tb_por3_3.Text = numero04.ToString();

                }
         



            }

            
        }
    }
}
