namespace MauiAppCalc
{
    public partial class MainPage : ContentPage
    {
        string operacao = null;

        double memoria_calc_pre_operacao = 0;
        double memoria_calc_pos_operacao = 0;

        string para_aparecer_no_visor = "";

        public MainPage()
        {
            InitializeComponent();
        }
        private void remover_sinais_visor()
        {
            if(para_aparecer_no_visor =="+" ||
                para_aparecer_no_visor =="-"||
                 para_aparecer_no_visor =="*"||
                  para_aparecer_no_visor == "/") 
            {
                para_aparecer_no_visor = "";    
            }
        }
        private void zerar_Clicked(System.Object sender, System.EventArgs e)
        {
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_calc_pre_operacao = 0;
            memoria_calc_pos_operacao = 0;
            operacao = null;
        }

        private void maismenos_Clicked(System.Object sender, System.EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor * -1;
            visor.Text = valor.ToString();

        }

        private void porcento_Clicked(System.Object sender, System.EventArgs e)
        {
            double valor= Convert.ToDouble(visor.Text);
            valor = valor /100;
            visor.Text = valor.ToString();
        }

        private void dividir_Clicked(System.Object sender, System.EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "/";
            operacao = "/";
            visor.Text = para_aparecer_no_visor;
        }

        private void num7_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num7.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num8_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num8.Text;
            visor.Text = para_aparecer_no_visor;

        }

        private void num9_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num9.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void multiplicar_Clicked(System.Object sender, System.EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "*";
            operacao = "*";
            visor.Text = para_aparecer_no_visor;

        }

        private void num4_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num4.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num5_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num5.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void num6_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num6.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void subtrair_Clicked(System.Object sender, System.EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "-";
            operacao = "-";
            visor.Text = para_aparecer_no_visor;


        }

        private void num1_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num1.Text;
            visor.Text = para_aparecer_no_visor;

        }

        private void num2_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num2.Text;
            visor.Text = para_aparecer_no_visor;

        }

        private void num3_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num3.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void somar_Clicked(System.Object sender, System.EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "+";
            operacao = "+";
            visor.Text = para_aparecer_no_visor;


        }

        private void num0_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num0.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void ponto_Clicked(System.Object sender, System.EventArgs e)
        {
            para_aparecer_no_visor += ponto.Text;
            visor.Text = para_aparecer_no_visor;
        }

        private void igual_Clicked(System.Object sender, System.EventArgs e)
        {
            try 
            {
                memoria_calc_pos_operacao = Convert.ToDouble(visor.Text);
                double resultado = 0;

                switch (operacao)
                {
                    case "+":
                        resultado = memoria_calc_pre_operacao
                            + memoria_calc_pos_operacao; break;
                    case "-":
                        resultado = memoria_calc_pre_operacao
                             - memoria_calc_pos_operacao; break;
                    case "*":
                        resultado = memoria_calc_pre_operacao
                            * memoria_calc_pos_operacao;break;
                    case "/":
                    resultado= memoria_calc_pre_operacao
                        / memoria_calc_pos_operacao;break;
                }
                visor.Text = resultado.ToString();
            }catch(Exception ex)
            {
                visor.Text = ex.Message;
            }

        }
    }

}
